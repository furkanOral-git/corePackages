using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.Application.Repositories;
using Core.Domain.Entities;
using SQLHelper;

namespace Core.Persistence.Repositories.SQLHelper
{
    public abstract class SQLRepository<TEntity> : IRepository<TEntity>
    where TEntity : Entity, new()
    {
        //default connection string name 'Sql' at appsettings.json
        public SQLRepository()
        {

        }

        public void Insert(TEntity entity)
        {
            using (SqlDbContext context = new())
            {
                context.Set<TEntity>().Insert(entity);
            }
        }

        public void Delete(int id)
        {
            using (SqlDbContext context = new SqlDbContext())
            {
                context.Set<TEntity>().Delete(id);
            }
        }

        public TEntity GetBy(Expression<Func<TEntity, bool>> predicate)
        {
            using (SqlDbContext context = new SqlDbContext())
            {
                return context.Set<TEntity>().GetBy(predicate);
            }
        }

        public List<TEntity> GetListBy(Expression<Func<TEntity, bool>>? filter = null, bool isSearchPattern = false)
        {
            using (SqlDbContext context = new SqlDbContext())
            {

                if (isSearchPattern)
                {
                    return context.Set<TEntity>().GetAllBy(filter, true);
                }
                return context.Set<TEntity>().GetAllBy(filter);
            }
        }

        public void Update(TEntity entity)
        {
            using (SqlDbContext context = new SqlDbContext())
            {
                context.Set<TEntity>().Update(entity);
            }
        }
    }

}