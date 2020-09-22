using System;
using System.Linq;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // LINQ Query Operators
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b;

            // LINQ Extension Methods
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            foreach (var cheapBook in cheapBooks)
                Console.WriteLine(cheapBook);

            var book = books.SingleOrDefault(b => b.Title == "Q");
            System.Console.WriteLine("Title: " + book?.Title);
        }
    }
}
