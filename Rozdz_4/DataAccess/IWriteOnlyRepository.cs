using System;
using System.Collections.Generic;
using System.Text;

namespace Rozdz_4.DataAccess
{
    public interface IWriteOnlyRepository<in T> :IDisposable
    {
        void Add(T newEntity);
        void Delete(T entity);
        int Commit();
    }
}
