using System;

namespace Rozdz_4.DataAccess
{
    public interface IRepository<T> : IReadOnlyRepository<T>, IDisposable 
    {
        void Add(T newEntity);
        void Delete(T entity);     
        int Commit();
    }
}
