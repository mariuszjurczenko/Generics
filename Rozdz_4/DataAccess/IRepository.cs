using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozdz_4.DataAccess
{
    public interface IRepository<T> : IDisposable
    {
        void Add(T newEntity);
        void Delete(T entity);
        T FindById(int id);
        IQueryable<T> FindAll();
        int Commit();
    }
}
