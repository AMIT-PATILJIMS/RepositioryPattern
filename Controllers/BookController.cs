using Microsoft.AspNetCore.Mvc;
using RepositioryPattern.Models;
using RepositioryPattern.Repository.Interfaces;

namespace RepositioryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _bookRepository.Get();
        }

        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _bookRepository.GetElement(id);
        }
    }
}
