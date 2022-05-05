using Bookstore.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService service;

        public BooksController(IBookService service)
        {
            this.service = service;
        }


        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(this.service.GetBooks());
        }

        [HttpGet("{id}", Name ="GetBook")]
        public IActionResult GetBook(string id)
        {
            return Ok(this.service.GetBook(id));
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            this.service.AddBook(book);
            return CreatedAtRoute("GetBook", new { Id = book.Id}, book );
        }
    }
}
