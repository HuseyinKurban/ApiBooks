using ApiBooks.WebUI.Areas.Admin.Dto.QuotesDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiBooks.WebUI.ViewComponents
{
    public class _QuoteComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _QuoteComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7051/api/Quote/GetRandomQuote");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetRandomQuotesDto>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
