using System;
using System.Collections.Generic;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter an English word.
            // Count the number of vowels (a, e, o, u, i) in the word.
            // So, if the user enters "inadequate", the program should display 6 on the console.

            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            Console.Write("Enter an English word: ");
            var input = Console.ReadLine();
            input = input.ToLower();

            var result = 0;

            foreach (var letter in input)
                foreach (var vowel in vowels)
                    if (letter.Equals(vowel))
                        ++result;

            Console.WriteLine(result);
        }
    }
}
