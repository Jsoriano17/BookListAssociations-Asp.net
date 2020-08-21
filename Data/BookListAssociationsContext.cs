using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookListAssociations.Models;

namespace BookListAssociations.Data
{
    public class BookListAssociationsContext : DbContext
    {
        public BookListAssociationsContext (DbContextOptions<BookListAssociationsContext> options)
            : base(options)
        {
        }

        public DbSet<BookListAssociations.Models.Book> Book { get; set; }
    }
}
