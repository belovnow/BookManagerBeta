using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagerBeta.Models
{
    public class Repository
    {
        private static List<Book> books =
            new List<Book>()
            {
                new Book {Title="Surely You're Joking, Mr. Feynman!", Author="Richard Feynman", Description="Feynman description", Pages=350},
                new Book {Title="Nausea", Author="Jean-Paul Sartre", Description="Sartre description", Pages=253},
                new Book {Title="A Russian Journal", Author="John Steinbeck", Description="Steinbeck description", Pages=120}
            };
        public static IEnumerable<Book> Responses
        {
            get
            {
                return books;
            }
        }

        public static void AddResponse(Book book)
        {
            books.Add(book);
        }
    }
}
