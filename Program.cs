using System;
using System.Collections.Generic;
using System.IO;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a text file and displays the number of words.
            var path = "./exercise9.txt";
            var content = File.ReadAllText(path);
            var words = content.Split(' ');

            Console.WriteLine(words.Length);
        }
    }
}
