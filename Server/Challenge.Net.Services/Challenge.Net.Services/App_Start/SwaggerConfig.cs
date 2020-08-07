using System.Web.Http;
using WebActivatorEx;
using Challenge.Net.Services;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Challenge.Net.Services
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
              .EnableSwagger(c =>
              {
                  c.SingleApiVersion("v1", "Challenge.Net.Services");
                  c.UseFullTypeNameInSchemaIds();
                  c.SchemaId(x => x.FullName);
              })

              .EnableSwaggerUi(c => { });
        }
    }
}