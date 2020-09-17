using System;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine($"a: {a}, b: {b}"); // a: 10, b: 11;

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine($"array1[0]: {array1[0]}, array2[0]: {array2[0]}");
            // array1[0]: 0, array2[0]: 0
        }
    }
}
