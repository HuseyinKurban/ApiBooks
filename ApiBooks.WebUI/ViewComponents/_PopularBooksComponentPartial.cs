using Microsoft.AspNetCore.Mvc;

namespace ApiBooks.WebUI.ViewComponents
{
    public class _PopularBooksComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _PopularBooksComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
