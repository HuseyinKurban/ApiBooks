using ApiBooks.BusinessLayer.Abstract;
using ApiBooks.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiBooks.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult BookList()
        {
            var values = _bookService.TGetBooksWithWriterAndCategoryList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBook(Book book)
        {
            _bookService.TInsert(book);
            return Ok("Ekleme Başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteBook(int id)
        {
            {
                _bookService.TDelete(id);
                return Ok("Silme Başarılı");
            }
        }

        [HttpPut]
        public IActionResult UpdateBook(Book book)
        {
            _bookService.TUpdate(book);
            return Ok("Güncelleme yapıldı");
        }

        [HttpGet("GetBook")]
        public IActionResult GetBook(int id)
        {
            var value = _bookService.TGetById(id);
            return Ok(value);
        }
    }
}
