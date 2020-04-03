using System;
using System.Collections.Generic;

namespace Rozdz_2
{
    public class CarComparer : IEqualityComparer<Car>, IComparer<Car>
    {
        public int Compare(Car x,  Car y)
        {
            return String.Compare(x.Name, y.Name);
        }

        public bool Equals(Car x,  Car y)
        {
            return String.Equals(x.Name, y.Name);
        }

        public int GetHashCode(Car obj)
        {
            return obj.Name.GetHashCode();
        }
    }

    public class BrandCollection : SortedDictionary<string, SortedSet<Car>>
    {
        public BrandCollection Add(string brandName, Car car)
        {
            if (!ContainsKey(brandName))
            {
                Add(brandName, new SortedSet<Car>(new CarComparer()));
            }
            this[brandName].Add(car);
            return this;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cars = new BrandCollection();

            cars.Add("Opel", new Car { Name = "Zafira" })
                .Add("Opel", new Car { Name = "Moka" })
                .Add("Opel", new Car { Name = "Meriva" })
                .Add("Opel", new Car { Name = "Tigra" })
                .Add("Opel", new Car { Name = "Corsa" })
                .Add("Opel", new Car { Name = "Astra" })
                .Add("Opel", new Car { Name = "Astra" })
                .Add("Opel", new Car { Name = "Astra" });
            
            cars.Add("Ford", new Car { Name = "Mondeo" })
                .Add("Ford", new Car { Name = "Puma" })
                .Add("Ford", new Car { Name = "Kuga" })
                .Add("Ford", new Car { Name = "Fiesta" })
                .Add("Ford", new Car { Name = "Ka" })
                .Add("Ford", new Car { Name = "Eskort" })
                .Add("Ford", new Car { Name = "Eskort" })
                .Add("Ford", new Car { Name = "Eskort" });

            foreach (var brand in cars)
            {
                Console.WriteLine("Brand {0} : ", brand.Key);

                foreach (var car in brand.Value)
                {
                    Console.WriteLine("\tCar {0}", car.Name);
                }
            }
        }
    }
}
