using BOOK_API.models;
using BOOK_API.DTO;

namespace BOOK_API.Repository
{
    public class BookRepository: IBookRepository
    {
        protected readonly BookContext _context;
        public BookRepository(BookContext context)
        {
            _context = context;
        }

        public Author AddAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
            return author;
        }

        public IEnumerable<Author> GetAuthors()
        {
            return _context.Authors;
        }

        public Book AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return book;
        }

        public IEnumerable<BookDTO> GetBooks()
        {
            var bookretorno = _context.Books.Select(b => new BookDTO{
                BookId = b.BookId,
                Title = b.Title,
                ReleaseYear = b.ReleaseYear,
                AuthorName = b.Author.Name
            }).ToList();
            return bookretorno;
        }
    }
}