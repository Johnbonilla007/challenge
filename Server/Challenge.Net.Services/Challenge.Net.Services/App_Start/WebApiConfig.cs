using Autofac;
using Autofac.Integration.WebApi;
using Challenge.Net.Services.App_Start;
using Challenge.Net.Services.Features.Review;
using Challenge.Net.Services.Infraestructure.Data.Data.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Swashbuckle.Application;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Reflection;
using System.Web.Http;
using Unity;
using Unity.Lifetime;

namespace Challenge.Net.Services
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Create your builder.
            var builder = new ContainerBuilder();

            // You can register controllers all at once using assembly scanning...
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var container = builder.Build();

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container); //Set the WebApi DependencyResolver

            var unityResolver = new UnityResolver(Container.Current);
            unityResolver.SetAufacContainer(container);

            GlobalConfiguration.Configuration.DependencyResolver = unityResolver;
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue(@"text/html"));
            config.Formatters.XmlFormatter.MediaTypeMappings.Add(new QueryStringMapping("type", @"xml", new MediaTypeHeaderValue(@"application/xml")));
            config.Formatters.XmlFormatter.MediaTypeMappings.Add(new QueryStringMapping("type", @"json", new MediaTypeHeaderValue(@"application/json")));

            var formatters = GlobalConfiguration.Configuration.Formatters;
            var jsonFormatter = formatters.JsonFormatter;
            var settings = jsonFormatter.SerializerSettings;
            settings.Formatting = Formatting.Indented;

            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Web API routes
            config.MapHttpAttributeRoutes();

            var redirectHandler = new RedirectHandler(message => message.RequestUri.ToString(), "swagger");

            config.Routes.MapHttpRoute(
            name: "swagger_root",
            routeTemplate: string.Empty,
            defaults: null,
            constraints: null,
            handler: redirectHandler);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //SwaggerConfig.Register();
        }
    }
}