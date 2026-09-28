using CRUDbooks.DTOs;
using CRUDbooks.Services.Books;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDbooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookServices _bookServices;

        public BookController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            var result = _bookServices.GetBooks();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateBook(CreateBookDto req)
        {
            var result = _bookServices.CreateBook(req);
            return Ok(result);
        }

        [HttpDelete("{bookId}")]
        public IActionResult DeleteBook(int bookId)
        {
            var result = _bookServices.DeleteBook(bookId);
            return Ok(result);
        }
        [HttpPut("{bookId}")]
        public IActionResult UpdateBook(int bookId, UpdateBookDto req)
        {
            var result = _bookServices.EditBook(bookId, req);
            return Ok(result);
        }

    }
}
