using Autofac;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Unity;

namespace Challenge.Net.Services.App_Start
{
    public class UnityResolver : IDependencyResolver
    {
        private readonly IUnityContainer _unityContainer;
        private IContainer _autofacContainer;

        public UnityResolver(IUnityContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }

            _unityContainer = container;
        }

        public IDependencyScope BeginScope()
        {
            var child = _unityContainer.CreateChildContainer();
            return new UnityResolver(child);
        }

        public void Dispose()
        {
            _unityContainer?.Dispose();
            _autofacContainer?.Dispose();
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return _unityContainer.Resolve(serviceType);
            }
            catch (Exception ex)
            {
                return _autofacContainer.ResolveOptional(serviceType);
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _unityContainer.ResolveAll(serviceType);
        }

        internal void SetAufacContainer(IContainer container)
        {
            _autofacContainer = container;
        }
    }
}