using ApiBooks.BusinessLayer.Abstract;
using ApiBooks.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ApiBooks.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        private readonly IQuoteService _quoteService;

        public QuoteController(IQuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        [HttpGet]
        public IActionResult QuoteList()
        {
            var values = _quoteService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateQuote(Quote quote)
        {
            _quoteService.TInsert(quote);
            return Ok("Ekleme Başarılı");
        }


        [HttpDelete]
        public IActionResult DeleteQuote(int id)
        {
            {
                _quoteService.TDelete(id);
                return Ok("Silme Başarılı");
            }
        }

        [HttpPut]
        public IActionResult UpdateQuote(Quote quote)
        {
            _quoteService.TUpdate(quote);
            return Ok("Güncelleme yapıldı");
        }

        [HttpGet("GetQuote")]
        public IActionResult GetQuote(int id)
        {
            var value = _quoteService.TGetById(id);
            return Ok(value);
        }


        [HttpGet("GetRandomQuote")]
        public IActionResult GetRandomQuote()
        {
            var value = _quoteService.TRandomQuote();
            return Ok(value);
        }
    }
}
