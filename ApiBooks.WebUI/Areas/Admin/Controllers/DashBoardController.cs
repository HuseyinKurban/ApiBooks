using ApiBooks.WebUI.Areas.Admin.Dto.BookDto;
using ApiBooks.WebUI.Areas.Admin.Dto.CategoryDto;
using ApiBooks.WebUI.Areas.Admin.Dto.FeatureDto;
using ApiBooks.WebUI.Areas.Admin.Dto.WriterDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace ApiBooks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashBoardController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DashBoardController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> DashboardIndex()
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessageLastFour = await client.GetAsync("https://localhost:7051/api/Book/GetLastFourBooks");

            if (responseMessageLastFour.IsSuccessStatusCode)
            {
                var jsonDataLastFour = await responseMessageLastFour.Content.ReadAsStringAsync();
                var valueLastFour = JsonConvert.DeserializeObject<List<GetLastFourBookDto>>(jsonDataLastFour);

                //kitap için
                var responseMessageBook = await client.GetAsync("https://localhost:7051/api/Book");
                var jsonDataBook = await responseMessageBook.Content.ReadAsStringAsync();
                var valuesBook = JsonConvert.DeserializeObject<List<ResultBookDto>>(jsonDataBook);
                ViewBag.Book = valuesBook.Count();

                //yazar için
                var responseMessageWriter = await client.GetAsync("https://localhost:7051/api/Writer");
                var jsonDataWriter = await responseMessageWriter.Content.ReadAsStringAsync();
                var valuesWriter = JsonConvert.DeserializeObject<List<ResultWriterDto>>(jsonDataWriter);
                ViewBag.Writer = valuesWriter.Count();

                //kategori için
                var responseMessageCategory = await client.GetAsync("https://localhost:7051/api/Category");
                var JsonDataCategory = await responseMessageCategory.Content.ReadAsStringAsync();
                var valuesCategory = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(JsonDataCategory);
                ViewBag.Category = valuesCategory.Count();

                //öne cıkan kitaplar 
                var responseMessageFeature = await client.GetAsync("https://localhost:7051/api/Feature");
                var jsonDataFeature = await responseMessageFeature.Content.ReadAsStringAsync();
                var valuesFeature = JsonConvert.DeserializeObject<List<ResultFeatureDto>>(jsonDataFeature);
                ViewBag.Feature = valuesFeature.Count();

                return View(valueLastFour);

            }


            return View();
        }
    }
}
