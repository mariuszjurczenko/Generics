using System;
using System.Linq;

namespace Rozdz_4.DataAccess
{
    public interface IReadOnlyRepository<out T> : IDisposable
    {
        T FindById(int id);
        IQueryable<T> FindAll();
    }
}
