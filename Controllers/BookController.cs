using book_api.Repository;
using book_api.models;
using Microsoft.AspNetCore.Mvc;

namespace book_api.Controllers
{
    [ApiController]
    [Route("books")]
    public class BooksController : Controller
    {
        protected readonly IBookRepository _repository;
        public BooksController(IBookRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Add ([FromBody] Book book)
        {
            return Created("", _repository.AddBook(book));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetBooks());
        }
    }
}