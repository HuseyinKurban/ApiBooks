using ApiBooks.WebUI.Areas.Admin.Dto.BookDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiBooks.WebUI.ViewComponents
{
    public class _PopularBooksGetByIdComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _PopularBooksGetByIdComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7051/api/Book/GetBooksByCategoryId?id="+id);
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
