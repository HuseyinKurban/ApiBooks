using ApiBooks.WebUI.Areas.Admin.Dto.BookDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace ApiBooks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> BookList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7051/api/Book");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
 
                var values = JsonConvert.DeserializeObject<List<ResultBookDto>>(jsonData);
                return View(values);
            }
            return View();
        }



    }
}
