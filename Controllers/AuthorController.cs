using book_api.Repository;
using book_api.models;
using Microsoft.AspNetCore.Mvc;

namespace book_api.Controllers
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
            return Ok(_repository.GetBooks());
        }
    }
}