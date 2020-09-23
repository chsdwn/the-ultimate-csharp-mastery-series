using System;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "A";
            // obj.GetHashCode();

            /*
                Reflection
            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);
            */

            // Dynamic
            // dynamic excelObject = "E";
            // excelObject.Optimize();

            dynamic name = "Ab";
            Console.WriteLine(name);
            name = 1;
            Console.WriteLine(name);

            dynamic a = 10;
            dynamic b = 5;
            var result = a + b;
            Console.WriteLine(result);
        }
    }
}
