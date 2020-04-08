using System;
using System.Collections.Generic;
using System.Linq;

namespace Rozdz_3
{
    public static class CollectionExtensions
    {
        public static IEnumerable<TOutput> Map<T, TOutput>(this IMyCollection<T> collection, Converter<T, TOutput> converter) 
        {
            return collection.Select(e => converter(e));
        }

        public static void WriteCollection<T>(this IMyCollection<T> collection, Action<T> print) 
        {
            if (collection.IsEmpty)
                Console.WriteLine("No elements to display");

            foreach (var item in collection)
            {
                print(item);
            }
        }
    }
}
