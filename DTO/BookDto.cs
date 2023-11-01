namespace BOOK_API.DTO
{
    public class BookDTO
    {
        public int BookId { get; set; }
        public string Title { get; set; } 
        public int ReleaseYear { get; set; }        
        public string? AuthorName {get; set; }
    }

}