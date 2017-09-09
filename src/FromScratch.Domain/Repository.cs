using FromScratch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FromScratch.Domain
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly IDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;
        public Repository(IDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }
        public TEntity Add(TEntity entity)
        {
            return _dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(object id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
