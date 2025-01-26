using ApiBooks.WebUI.Areas.Admin.Dto.BookDto;
using ApiBooks.WebUI.Areas.Admin.Dto.FeatureDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiBooks.WebUI.ViewComponents
{
    public class _SliderFeaturedBooksComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;


        public _SliderFeaturedBooksComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7051/api/Feature");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FeatureSliderDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
