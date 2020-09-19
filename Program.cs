using System;
using System.Collections.Generic;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a few numbers 
            // separated by a hyphen. If the user simply presses Enter,
            // without supplying an input, exit immediately; otherwise,
            // check to see if there are duplicates. If so, 
            // display "Duplicate" on the console.

            Console.Write("Enter numbers: ");
            var input = Console.ReadLine();

            if (String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input))
                return;
            else
            {
                var numberArray = input.Split('-');
                var numbers = new List<int>();

                foreach (var num in numberArray)
                    numbers.Add(Convert.ToInt32(num));

                for (int i = 0; i < numbers.Count; i++)
                {
                    var currentNumber = numbers[i];
                    numbers.Remove(currentNumber);

                    if (numbers.Contains(currentNumber))
                    {
                        Console.WriteLine("Duplicate");
                        break;
                    }
                }
            }
        }
    }
}
