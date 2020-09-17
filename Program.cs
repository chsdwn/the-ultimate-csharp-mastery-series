using System;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PASSWORD_LENGTH = 15;
            var random = new Random();

            var buffer = new char[PASSWORD_LENGTH];

            for (int i = 0; i < PASSWORD_LENGTH; i++)
                buffer[i] = (char)(random.Next(33, 126));

            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
