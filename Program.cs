using System;
using System.Collections.Generic;
using System.IO;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            System.Threading.Thread.Sleep(1000);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Duration);

            stopwatch.Start();
            System.Threading.Thread.Sleep(2000);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Duration);
            stopwatch.Stop();
        }
    }
}
