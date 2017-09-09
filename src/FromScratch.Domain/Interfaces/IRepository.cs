using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace FromScratch.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        IQueryable<TEntity> GetAll();
        TEntity Get(object id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> filter);
        TEntity Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
