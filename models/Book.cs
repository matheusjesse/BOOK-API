namespace book_api.models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Book 
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; } 
        public int ReleaseYear { get; set; }
        [ForeignKey("AuthorID")]
        public int AuthorId { get; set; }
    }
}