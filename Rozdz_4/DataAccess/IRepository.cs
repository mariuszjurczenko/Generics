using System;

namespace Rozdz_4.DataAccess
{
    public interface IRepository<T> : IReadOnlyRepository<T>, IWriteOnlyRepository<T> 
    {
       
    }
}
