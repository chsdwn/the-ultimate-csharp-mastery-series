using System;
using System.Collections.Generic;
using System.IO;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            Console.WriteLine(customer.Orders.Count);
        }
    }
}
