using ApiBooks.WebUI.Areas.Admin.Dto.BookDto;
using ApiBooks.WebUI.Areas.Admin.Dto.CategoryDto;
using ApiBooks.WebUI.Areas.Admin.Dto.WriterDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;


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

        public async Task<IActionResult> CreateBook()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessageCategory = await client.GetAsync("https://localhost:7051/api/Category");

            if (responseMessageCategory.IsSuccessStatusCode)
            {
                var jsonDatacategory = await responseMessageCategory.Content.ReadAsStringAsync();
                var valuescategory = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonDatacategory);

                List<SelectListItem> categories = (from x in valuescategory
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
                ViewBag.Category = categories;
            }

            var responseMessageWriter = await client.GetAsync("https://localhost:7051/api/Writer");

            if (responseMessageWriter.IsSuccessStatusCode)
            {
                var jsonDatawriter = await responseMessageWriter.Content.ReadAsStringAsync();
                var valueswriter = JsonConvert.DeserializeObject<List<ResultWriterDto>>(jsonDatawriter);

                List<SelectListItem> writer = (from x in valueswriter
                                               select new SelectListItem
                                               {
                                                   Text = x.Name + " " + x.Surname,
                                                   Value = x.WriterId.ToString()
                                               }).ToList();
                ViewBag.Writer = writer;
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(CreateBookDto createBookDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBookDto);
            StringContent stringcontent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7051/api/Book", stringcontent);


            if (responseMessage.IsSuccessStatusCode)
            {
                return Redirect("/Admin/Book/BookList");

            }
            return View();
        }

        public async Task<IActionResult> DeleteBook(int id)
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync("https://localhost:7051/api/Book?id=" + id);

            if (responseMessage.IsSuccessStatusCode)
            {
                return Redirect("/Admin/Book/BookList");

            }
            return View();

        }

        public async Task<IActionResult> UpdateBook(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessageCategory = await client.GetAsync("https://localhost:7051/api/Category");

            if (responseMessageCategory.IsSuccessStatusCode)
            {
                var jsonDatacategory = await responseMessageCategory.Content.ReadAsStringAsync();
                var valuescategory = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonDatacategory);

                List<SelectListItem> categories = (from x in valuescategory
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
                ViewBag.Category = categories;
            }

            var responseMessageWriter = await client.GetAsync("https://localhost:7051/api/Writer");

            if (responseMessageWriter.IsSuccessStatusCode)
            {
                var jsonDatawriter = await responseMessageWriter.Content.ReadAsStringAsync();
                var valueswriter = JsonConvert.DeserializeObject<List<ResultWriterDto>>(jsonDatawriter);

                List<SelectListItem> writer = (from x in valueswriter
                                               select new SelectListItem
                                               {
                                                   Text = x.Name + " " + x.Surname,
                                                   Value = x.WriterId.ToString()
                                               }).ToList();
                ViewBag.Writer = writer;
            }

            var responseMessage = await client.GetAsync("https://localhost:7051/api/Book/GetBook?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateBookDto>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBook(UpdateBookDto updateBookDto)
        {
            var client=_httpClientFactory.CreateClient();
            var jsonData=JsonConvert.SerializeObject(updateBookDto);
            StringContent stringcontent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7051/api/Book/", stringcontent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return Redirect("/Admin/Book/BookList");

            }
            return View();
        }
    }
}
