using book_api.models;

namespace book_api.Repository
{
    public interface IBookRepository
    {
        Author AddAuthor(Author author);
        IEnumerable<Author> GetAuthors();

        Book AddBook(Book book);
        IEnumerable<Book> GetBooks();
    }
}