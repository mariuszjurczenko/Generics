using Rozdz_4.Model;
using System.Data.Entity;
using System.Linq;

namespace Rozdz_4.DataAccess
{
    public class SqlRepository<T> : IRepository<T> where T: class, IEntity
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
            if(newEntity.IsValid())
            _dbSet.Add(newEntity);
        }

        public IQueryable<T> FindAll()
        {
            return _dbSet;
        }

        public T FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
