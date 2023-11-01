using BOOK_API.Repository;
using BOOK_API.models;
using Microsoft.AspNetCore.Mvc;

namespace BOOK_API.Controllers
{
    [ApiController]
    [Route("authors")]
    public class AuthorController : Controller
    {
        protected readonly IBookRepository _repository;
        public AuthorController(IBookRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Add ([FromBody] Author author)
        {
            return Created("", _repository.AddAuthor(author));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAuthors());
        }
    }
}