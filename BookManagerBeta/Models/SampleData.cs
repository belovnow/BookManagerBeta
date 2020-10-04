using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagerBeta.Models
{
    public class SampleData
    {
        public static void Initialize(BookContext context)
        {
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book { Title = "Surely You're Joking, Mr. Feynman!", Author = "Richard Feynman", Description = "Feynman description", Pages = 350 },
                    new Book { Title = "Nausea", Author = "Jean-Paul Sartre", Description = "Sartre description", Pages = 253 },
                    new Book { Title = "A Russian Journal", Author = "John Steinbeck", Description = "Steinbeck description", Pages = 120 }
                    );
                
                context.SaveChanges();
            }
        }
    }
}
