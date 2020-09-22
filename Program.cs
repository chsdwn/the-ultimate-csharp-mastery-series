using System;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>();
            Console.WriteLine("Has value: " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }
}
