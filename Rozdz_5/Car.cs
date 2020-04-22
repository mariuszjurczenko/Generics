using System;

namespace Rozdz_5
{
    public class Car
    {
        public string Name { get; set; }

        public void Write<T>()
        {
            Console.WriteLine(typeof(T).Name);
        }
    }
}
