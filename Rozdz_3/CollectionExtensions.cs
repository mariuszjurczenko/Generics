using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Rozdz_3
{
    public static class CollectionExtensions
    {
        public static IEnumerable<TOutput> AsEnumerableOf<T, TOutput>(this IMyCollection<T> collection)
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));

            foreach (var item in collection)
            {
                TOutput result = (TOutput)converter.ConvertTo(item, typeof(TOutput));
                yield return result;
            }
        }

        public static void WriteCollection<T>(this IMyCollection<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
