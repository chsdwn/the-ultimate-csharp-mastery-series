using System.Collections.Generic;

namespace ultimate_csharp_mastery
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "A", Price = 5},
                new Book() {Title = "B", Price = 7},
                new Book() {Title = "C", Price = 17}
            };
        }
    }
}