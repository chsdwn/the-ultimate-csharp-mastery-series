using System;

namespace ultimate_csharp_mastery
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("Car");
        }
    }
}