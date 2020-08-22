using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListAssociations.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace BookListAssociations.Models
{
    public class SeedDb
    {
        public static void InitializeBooks(IServiceProvider serviceProvider)
        {
            using (var context = new BookListAssociationsContext(serviceProvider.GetRequiredService<DbContextOptions<BookListAssociationsContext>>()))
            {
                if (context.Book.Any())
                {
                    return;
                }
                context.Book.AddRange(
                    new Book
                    {
                        Title = "Harry Potter",
                        Author = "J.K Rowling",
                        ReleaseDate = DateTime.Parse("1998-1-1"),
                        Genere = "Fantasy",
                        Price = "10.99"
                    },
                     new Book
                     {
                         Title = "Some Other Book",
                         Author = "By a person",
                         ReleaseDate = DateTime.Parse("1998-1-1"),
                         Genere = "something",
                         Price = "11.99"
                     },
                      new Book
                      {
                          Title = "something",
                          Author = "someting",
                          ReleaseDate = DateTime.Parse("1998-1-1"),
                          Genere = "something",
                          Price = "69.69"
                      }
                    );
                context.SaveChanges();
            }
        }
    }
}
