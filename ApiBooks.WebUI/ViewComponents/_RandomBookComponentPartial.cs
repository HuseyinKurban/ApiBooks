using ApiBooks.WebUI.Areas.Admin.Dto.BookDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiBooks.WebUI.ViewComponents
{
    public class _RandomBookComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _RandomBookComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7051/api/Book/GetRandomBook");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetRandomBookDto>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
