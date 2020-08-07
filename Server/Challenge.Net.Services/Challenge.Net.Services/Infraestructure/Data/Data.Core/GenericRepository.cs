using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Challenge.Net.Services.Features.Review;
using System.Data.Entity;

namespace Challenge.Net.Services.Infraestructure.Data.Data.Core
{
    public class GenericRepository<T> : IGenericRepository<T> where T : IQueryableUnitOfWork
    {
        private readonly IQueryableUnitOfWork _unitOfWork;

        public IUnitOfWork UnitOfWork
        {
            get { return _unitOfWork; }
        }

        public GenericRepository(IQueryableUnitOfWork UnitOfWork)
        {
            _unitOfWork = UnitOfWork;
        }

        private DbSet<TEntity> GetSet<TEntity>() where TEntity : Entity
        {
            DbSet<TEntity> set = _unitOfWork.CreateSet<TEntity>();

            return set;
        }

        public void Add<TEntity>(TEntity entity) where TEntity : Entity
        {
            if (entity != null)
            {
                GetSet<TEntity>().Add(entity);
            }
        }

        public IEnumerable<TEntity> GetAll<TEntity>() where TEntity : Entity
        {
            return GetSet<TEntity>().ToList();
        }

        public IEnumerable<TEntity> GetFiltered<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : Entity
        {
            return GetSet<TEntity>().Where(predicate).ToList();
        }

        public TEntity GetSingle<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : Entity
        {
            IQueryable<TEntity> items = GetSet<TEntity>();

            return items.FirstOrDefault(predicate);
        }

        public void Remove<TEntity>(TEntity entity) where TEntity : Entity
        {
            if (entity != null)
            {
                //attach item if not exist
                _unitOfWork.Attach(entity);

                //set as "removed"
                GetSet<TEntity>().Remove(entity);
            }
        }

        public void Dispose()
        {
            if (_unitOfWork != null)
                _unitOfWork.Dispose();
        }
    }
}