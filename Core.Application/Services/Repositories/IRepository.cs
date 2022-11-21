using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Domain.Entities;


namespace Core.Application.Repositories
{
    public interface IRepository<TEntity>
    where TEntity : Entity, new()
    {
        public List<TEntity> GetListBy(Expression<Func<TEntity, bool>>? filter = null, bool isSearchPattern = false);
        public TEntity GetBy(Expression<Func<TEntity, bool>> predicate);
        public void Insert(TEntity entity);
        public void Delete(int id);
        public void Update(TEntity entity);


    }
}