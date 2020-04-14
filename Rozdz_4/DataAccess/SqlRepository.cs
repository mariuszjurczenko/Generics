﻿using System;
using System.Data.Entity;
using System.Linq;

namespace Rozdz_4.DataAccess
{
    public class SqlRepository<T> : IRepository<T> where T: class
    {
        DbContext _dbContext;
        DbSet<T> _dbSet;
        public SqlRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public void Add(T newEntity)
        {
            _dbSet.Add(newEntity);
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public IQueryable<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public T FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
