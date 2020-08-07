using Challenge.Net.Services.Features.Review;
using Challenge.Net.Services.Features.User;
using Challenge.Net.Services.Infraestructure.Data.Data.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Challenge.Net.Services.Infraestructure.Data.DataContext.UnitOfWork
{
    public class UnitOfWork : BCUnitOfWork, IQueryableUnitOfWork
    {
        public UnitOfWork() : base("Clallenge")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<UnitOfWork>());
        }

        public DbSet<ReviewAgg> Review { get; set; }
        public DbSet<UserAgg> UserAgg { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ReviewMap());
            modelBuilder.Configurations.Add(new UserMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}