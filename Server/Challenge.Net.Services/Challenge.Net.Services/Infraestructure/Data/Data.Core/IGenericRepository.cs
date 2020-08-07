using Challenge.Net.Services.Features.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Net.Services.Infraestructure.Data.Data.Core
{
    public interface IGenericRepository<T> : IDisposable
         where T : IQueryableUnitOfWork

    {
        IUnitOfWork UnitOfWork { get; }

        void Add<TEntity>(TEntity entity)
            where TEntity : Entity;

        void Remove<TEntity>(TEntity entity)
         where TEntity : Entity;

        IEnumerable<TEntity> GetAll<TEntity>()
         where TEntity : Entity;

        TEntity GetSingle<TEntity>(Expression<Func<TEntity, bool>> predicate)
        where TEntity : Entity;

        IEnumerable<TEntity> GetFiltered<TEntity>(Expression<Func<TEntity, bool>> predicate)
         where TEntity : Entity;
    }
}