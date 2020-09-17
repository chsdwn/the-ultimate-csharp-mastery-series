using System;

namespace ultimate_csharp_mastery
{
    class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number); // 1

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age); // 30
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
