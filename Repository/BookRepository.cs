using book_api.models;

namespace book_api.Repository
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
    }
}