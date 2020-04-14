using Rozdz_4.Model;
using System.Data.Entity;

namespace Rozdz_4.DataAccess
{
    public class CarDb :DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}
