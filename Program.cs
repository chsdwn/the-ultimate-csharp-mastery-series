using System;
using System.Collections.Generic;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EXERCISES */

            // ----1----
            // var names = new List<string>();
            // var name = "";

            // for (; ; )
            // {
            //     Console.Write("Enter name: ");
            //     name = Console.ReadLine();
            //     if (!String.IsNullOrEmpty(name) || !String.IsNullOrWhiteSpace(name))
            //         names.Add(name);
            //     else break;
            // }

            // switch (names.Count)
            // {
            //     case 0:
            //         return;
            //     case 1:
            //         Console.WriteLine($"{names[0]} likes your post");
            //         return;
            //     case 2:
            //         Console.WriteLine($"{names[0]} and {names[1]} like your post");
            //         return;
            //     default:
            //         Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post");
            //         return;
            // }

            // ----2----
            // Console.Write("Enter your name: ");
            // var name = Console.ReadLine();
            // var reversedName = "";

            // for (int i = name.Length; i > 0; i--)
            //     reversedName += name[i - 1];

            // Console.WriteLine($"Reversed name: {reversedName}");

            // ----3----
            // var numbers = new List<int>();

            // for (; ; )
            // {
            //     if (numbers.Count < 5)
            //     {
            //         Console.Write("Please enter a number: ");
            //         var number = Int32.Parse(Console.ReadLine());

            //         if (!numbers.Contains(number))
            //             numbers.Add(number);
            //     }
            //     else break;
            // }

            // numbers.Sort();

            // foreach (var number in numbers)
            //     Console.WriteLine(number);

            // ----4----
            // var numbers = new List<int>();

            // for (; ; )
            // {
            //     Console.Write("Enter a number or 'Quit': ");
            //     var value = Console.ReadLine();

            //     if (String.Equals(value, "Quit"))
            //         break;
            //     else
            //         numbers.Add(Int32.Parse(value));
            // }

            // var uniqueNumbers = new List<int>();

            // for (; ; )
            // {
            //     var index = numbers.Count - 1;

            //     var number = numbers[index];
            //     numbers.RemoveAt(index);

            //     if (!numbers.Contains(number))
            //         uniqueNumbers.Add(number);
            //     else
            //         numbers.RemoveAll(num => num == number);

            //     if (numbers.Count <= 0)
            //         break;
            // }

            // foreach (var unqNmb in uniqueNumbers)
            //     Console.WriteLine(unqNmb);

            // ----5----
            var numbers = new List<int>();

            for (; ; )
            {
                Console.Write("Enter a list of number(eg: 1,2,3,4,5): ");
                var list = Console.ReadLine();

                if (String.IsNullOrEmpty(list) || String.IsNullOrWhiteSpace(list))
                {
                    Console.WriteLine("Invalid list");
                    continue;
                }

                list = list.Trim();
                var splittedList = list.Split(',');

                if (splittedList.Length < 5)
                {
                    Console.WriteLine("Invalid list");
                    continue;
                }

                foreach (var number in splittedList)
                    numbers.Add(Int32.Parse(number));

                numbers.Sort();
                numbers.RemoveRange(3, numbers.Count - 3);
                break;
            }

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
