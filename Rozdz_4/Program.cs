using Rozdz_4.DataAccess;
using Rozdz_4.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace Rozdz_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<CarDb>());

            using (IRepository<Car> carRepository = new SqlRepository<Car>(new CarDb()))
            {
                AddCars(carRepository);
                CountCars(carRepository);
            }
        }

        private static void CountCars(IRepository<Car> carRepository)
        {
            Console.WriteLine(carRepository.FindAll().Count());
        }

        private static void AddCars(IRepository<Car> carRepository)
        {
            carRepository.Add(new Car { Name = "Ford" });
            carRepository.Add(new Car { Name = "Opel" });
            carRepository.Add(new Car { Name = "Mazda" });
            carRepository.Add(new Car { Name = "Nisan" });
            carRepository.Add(new Car { Name = "Fiat" });
            carRepository.Commit();
        }
    }
}
