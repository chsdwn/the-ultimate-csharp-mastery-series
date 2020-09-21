using System;
using System.Collections.Generic;
using System.IO;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1990, 1, 1));
            Console.WriteLine(person.Age);
        }
    }
}
