using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BookStore.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BookStoreContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "The Power of Your Subconscious Mind",
                        Genre = "Self Help",
                        PublishDate = new DateTime(2015,2,1),
                        Price = 105
                    },

                    new Book
                    {
                        Title = "The Alchemist",
                        Genre = "Self Help",
                        PublishDate = new DateTime(2005, 10, 17),
                        Price = 227
                    },

                    new Book
                    {
                        Title = "One Small Mistake",
                        Genre = "Thriller",
                        PublishDate = new DateTime(2021, 12, 1),
                        Price = 800,
                    },

                    new Book
                    {
                        Title = "All the Light we Cannot See",
                        Genre = "Fiction",
                        PublishDate = new DateTime(2015, 12, 10),
                        Price = 306,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}