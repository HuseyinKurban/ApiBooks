using ApiBooks.WebUI.Areas.Admin.Dto.WriterDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace ApiBooks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public WriterController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> WriterList()
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7051/api/Writer");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultWriterDto>>(jsonData);
                return View(values);
            }

            return View();
        }

        [HttpGet]
        public IActionResult CreateWriter()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateWriter(CreateWriterDto createWriterDto)
        {
            var client = _httpClientFactory.CreateClient();
            //string formatta gönderdiğimiz veriyi jsona dönüştürüyor
            var jsonData = JsonConvert.SerializeObject(createWriterDto);
            StringContent stringcontent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7051/api/Writer", stringcontent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return Redirect("/Admin/Writer/WriterList");

            }
            return View();
        }

        public async Task<IActionResult> DeleteWriter(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync("https://localhost:7051/api/Writer?id=" + id);

            if (responseMessage.IsSuccessStatusCode)
            {
                return Redirect("/Admin/Writer/WriterList");
            }
            return View();
        }

        public async Task<IActionResult> UpdateWriter(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7051/api/Writer/GetWriter?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateWriterDto>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateWriter(UpdateWriterDto updateWriterDto)
        {
            var client= _httpClientFactory.CreateClient();
            var jsonData=JsonConvert.SerializeObject(updateWriterDto);
            StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");

            var responseMessage = await client.PutAsync("https://localhost:7051/api/Writer/", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return Redirect("/Admin/Writer/WriterList");
            }
            return View();
        }

    }
}
