using BOOK_API.models;

namespace BOOK_API.Repository
{
    public interface IBookRepository
    {
        Author AddAuthor(Author author);
        IEnumerable<Author> GetAuthors();

        Book AddBook(Book book);
        IEnumerable<Book> GetBooks();
    }
}