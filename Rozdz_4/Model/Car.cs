using System;

namespace Rozdz_4.Model
{
    public class Car : Vehicle
    {
        public int Id { get; set; }

        public virtual void DoDrive()
        {
            Console.WriteLine("You drive a car");
        }
    }
}
