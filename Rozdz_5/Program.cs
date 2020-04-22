using System;
using System.Collections.Generic;

namespace Rozdz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var carList = CreateCollection(typeof(List<>), typeof(Car));
            Console.Write(carList.GetType().Name);
            var genericsArguments = carList.GetType().GenericTypeArguments;

            foreach (var arg in genericsArguments)
            {
                Console.WriteLine("[{0}]", arg.Name);
            }
        }

        private static object CreateCollection(Type collectionType,Type itemType) 
        {
            var closedType = collectionType.MakeGenericType(itemType);

            return Activator.CreateInstance(closedType);
        }
    }
}
