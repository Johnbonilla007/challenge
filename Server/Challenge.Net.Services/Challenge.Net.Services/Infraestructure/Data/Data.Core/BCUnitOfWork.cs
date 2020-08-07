using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace Challenge.Net.Services.Infraestructure.Data.Data.Core
{
    public class BCUnitOfWork : DbContext
    {
        public BCUnitOfWork(string connectionString)
         : base(connectionString)
        {
            Database.SetInitializer<BCUnitOfWork>(null);
        }

        public BCUnitOfWork()
        {
            Database.SetInitializer<BCUnitOfWork>(null);
        }

        public void Commit()
        {
            base.SaveChanges();
        }

        public DbSet<TEntity> CreateSet<TEntity>()
            where TEntity : class
        {
            return Set<TEntity>();
        }

        public void SetModified<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void Attach<TEntity>(TEntity item) where TEntity : class
        {
            //attach and set as unchanged
            Entry(item).State = EntityState.Unchanged;
        }

        public void ApplyCurrentValues<TEntity>(TEntity original, TEntity current) where TEntity : class
        {
            //if it is not attached, attach original and set current values
            Entry(original).CurrentValues.SetValues(current);
        }
    }
}