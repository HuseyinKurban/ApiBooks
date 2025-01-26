using ApiBooks.BusinessLayer.Abstract;
using ApiBooks.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiBooks.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WriterController : ControllerBase
    {
        private readonly IWriterService _writerService;

        public WriterController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        [HttpGet]
        public IActionResult WriterList()
        {
            var values = _writerService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateWriter(Writer Writer)
        {
            _writerService.TInsert(Writer);
            return Ok("Ekleme Başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteWriter(int id)
        {
            {
                _writerService.TDelete(id);
                return Ok("Silme Başarılı");
            }
        }

        [HttpPut]
        public IActionResult UpdateWriter(Writer Writer)
        {
            _writerService.TUpdate(Writer);
            return Ok("Güncelleme yapıldı");
        }

        [HttpGet("GetWriter")]
        public IActionResult GetWriter(int id)
        {
            var value = _writerService.TGetById(id);
            return Ok(value);
        }

        [HttpGet("GetLastWriter")]
        public IActionResult GetLastWriter()
        {
            var value = _writerService.TGetLastWriter();
            return Ok(value);
        }
    }
}
