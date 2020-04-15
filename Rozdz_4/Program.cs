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
                AddSedans(carRepository);
                CountCars(carRepository);
                QueryCars(carRepository);
                PrintAllCars(carRepository);
            }
        }

        private static void AddSedans(IWriteOnlyRepository<Sedan> carRepository)
        {
            carRepository.Add(new Sedan { Name = "Volvo" });
            carRepository.Commit();
        }

        private static void PrintAllCars(IReadOnlyRepository<Vehicle> carRepository)
        {
            var cars = carRepository.FindAll();

            foreach (var car in cars)
            {
                Console.WriteLine(car.Name);
            }
        }

        private static void QueryCars(IRepository<Car> carRepository)
        {
            var car = carRepository.FindById(1);
            Console.WriteLine(car.Name);
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
