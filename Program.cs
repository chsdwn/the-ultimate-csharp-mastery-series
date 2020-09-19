using System;
using System.Collections.Generic;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a few words separated by a space.
            // Use the words to create a variable name with PascalCase. For example, 
            // if the user types: "number of students", display "NumberOfStudents". 
            // Make sure that the program is not dependent on the input. So, if the user
            // types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            Console.Write("Enter a few words: ");
            var input = Console.ReadLine();
            input = input.ToLower();

            var words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                word = word[0].ToString().ToUpper() + word.Substring(1);
                words[i] = word;
            }

            var result = "";

            foreach (var word in words)
                result += word;

            Console.WriteLine(result);
        }
    }
}
