using System;

namespace Rozdz_4.Model
{
    public class Car : Vehicle, IEntity
    {
        public int Id { get; set; }

        public virtual void DoDrive()
        {
            Console.WriteLine("You drive a car");
        }

        public bool IsValid()
        {
            return true;
        }
    }
}
