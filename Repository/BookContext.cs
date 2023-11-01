using Microsoft.EntityFrameworkCore;
using book_api.models;

namespace book_api.Repository;

public class BookContext : DbContext, IBookContext
{
    public BookContext(DbContextOptions<BookContext> options) : base(options) {}

    public DbSet<Author> Authors {get; set;} = null!;

    public DbSet<Book> Books {get; set;} = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            var connectionString = "Server=127.0.0.1;Database=BookStore;User=SA;Password=Trybe12345*";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.books)
                .HasForeignKey( b => b.AuthorId);
    }


}