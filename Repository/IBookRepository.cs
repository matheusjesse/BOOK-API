using BOOK_API.models;
using BOOK_API.DTO;

namespace BOOK_API.Repository
{
    public interface IBookRepository
    {
        Author AddAuthor(Author author);
        IEnumerable<Author> GetAuthors();

        Book AddBook(Book book);
        IEnumerable<BookDTO> GetBooks();
    }
}