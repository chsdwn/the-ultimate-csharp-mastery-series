using System;
using System.Collections.Generic;
using System.IO;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            // params
            var result = Add(new int[] { 1, 2, 3, 4 });
            var result2 = Add(1, 2, 3, 4);
            Console.WriteLine(result);
            Console.WriteLine(result2);

            // ref modifier
            var number = 2;
            Increment(ref number, 2);
            Console.WriteLine(number);

            // out modifier
            int number2;
            EqualTo(out number2, 5);
            Console.WriteLine(number2);
        }

        static int Add(params int[] numbers)
        {
            var result = 0;
            foreach (var number in numbers)
                result += number;
            return result;
        }

        static void Increment(ref int number, int value)
        {
            number += value;
        }

        static void EqualTo(out int number, int value)
        {
            number = value;
        }
    }
}
