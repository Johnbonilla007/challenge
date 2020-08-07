using Challenge.Net.Services.Features.Review;
using Challenge.Net.Services.Features.User;
using Challenge.Net.Services.Infraestructure.Data.Data.Core;
using Challenge.Net.Services.Infraestructure.Data.DataContext.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Unity;
using Unity.Lifetime;

namespace Challenge.Net.Services.App_Start
{
    public class ChallengeContainer
    {
        internal static void Configure(IUnityContainer container)
        {
            ////-> Unit of Work
            RegisterUnitOfWork(container);

            ////-> Repositories
            RegisterRepositories(container);

            ////-> Aplication Services
            RegisterAplicationServices(container);
        }

        private static void RegisterAplicationServices(IUnityContainer container)
        {
            container.RegisterType<IReviewAppService, ReviewAppService>();
            container.RegisterType<IUserAppService, UserAppService>();
        }

        private static void RegisterRepositories(IUnityContainer container)
        {
            container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }

        private static void RegisterUnitOfWork(IUnityContainer container)
        {
            container.RegisterType(typeof(UnitOfWork), new PerResolveLifetimeManager());
            container.RegisterType<IQueryableUnitOfWork, UnitOfWork>();
            container.RegisterType<DbContext, UnitOfWork>();
        }
    }
}