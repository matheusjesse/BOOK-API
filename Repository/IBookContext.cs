using Microsoft.EntityFrameworkCore;
using BOOK_API.models;

namespace BOOK_API.Repository
{
    public interface IBookContext
    {
        public DbSet<Author> Authors {get; set;}
        public DbSet<Book> Books {get; set;}

        public int SaveChanges();
    }
}