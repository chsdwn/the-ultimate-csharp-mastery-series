using System;
using System.Collections.Generic;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a few numbers 
            // separated by a hyphen. Work out if the numbers are consecutive. 
            // For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
            // display a message: "Consecutive"; otherwise, display "Not Consecutive".

            Console.Write("Enter number: ");
            var userInput = Console.ReadLine();
            var numberArray = userInput.Split('-');

            var numbers = new List<int>();

            foreach (var num in numberArray)
                numbers.Add(Convert.ToInt32(num));

            if (numbers[0] < numbers[1])
                Console.WriteLine(IsConsecutive(numbers, false) ? "Consecutive" : "Not Consecutive");
            else if (numbers[0] > numbers[1])
                Console.WriteLine(IsConsecutive(numbers, true) ? "Consecutive" : "Not Consecutive");
            else
                Console.WriteLine("Not Consecutive");
        }

        static bool IsConsecutive(List<int> numbers, bool isReverse)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (!isReverse)
                {

                    if (numbers[i] + 1 != numbers[i + 1])
                        return false;
                }
                else
                {
                    if (numbers[i] != numbers[i + 1] + 1)
                        return false;
                }
            }

            return true;
        }
    }
}
