using System;
using System.Collections.Generic;
using System.IO;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a text file and displays the longest word in the file.
            var path = "./exercise9.txt";
            var content = File.ReadAllText(path);
            var words = content.Split(' ');

            var longestWordLength = 0;
            var longestWord = "";

            foreach (var word in words)
                if (word.Length > longestWordLength)
                {
                    longestWordLength = word.Length;
                    longestWord = word;
                }

            Console.WriteLine(longestWord);
        }
    }
}
