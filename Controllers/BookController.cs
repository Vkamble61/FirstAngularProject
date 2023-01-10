using FirstAngularProject.Data.Models;
using FirstAngularProject.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstAngularProject.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        IBookService _service;

        public BookController(IBookService service)
        {
            _service = service;
        }

        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody] Book newBook)
        {
            _service.AddBook(newBook);
            return Ok("Added");
        }

        [HttpGet("action")]
        public IActionResult GetAllBooks()
        {
            return Ok(_service.GetAllBooks());
        }

        [HttpGet("SingleBook/{id}")]
        public IActionResult GetBookById(int id)
        {
            return Ok(_service.GetBookById(id));
        }

        [HttpDelete("DeleteBook/{id}")]
        public IActionResult DeleteBookById(int id)
        {
            _service.DeleteBook(id);
            return Ok();
        }

        [HttpPut("UpdateBook/{id}")]
        public IActionResult UpdateBookById(int id, [FromBody] Book newBook)
        {
            var book = _service.UpdateBook(id, newBook);
            if (book == null)
                return NotFound();
            return Ok(book);
        }
    }
}
