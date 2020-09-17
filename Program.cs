using System;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 255;
            Console.WriteLine($"byte number: {number}"); // 255

            ++number;
            Console.WriteLine($"byte number + 1: {number}"); // 0

            checked
            {
                byte number2 = 255;
                Console.WriteLine($"byte number2: {number2}"); // 255

                ++number2;
                Console.WriteLine($"byte number2 + 1: {number2}");
                //Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow
            }
        }
    }
}
