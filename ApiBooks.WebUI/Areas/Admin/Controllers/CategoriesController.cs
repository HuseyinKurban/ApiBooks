using ApiBooks.WebUI.Dto.CategoryDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiBooks.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        //bu  bizim işlemler için  bir baglantı olusturucak.
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoriesController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> CategoryList()
        {
            // HttpClient nesnesi oluşturduk
            //burda bağlantı acıyoruz.
            var client = _httpClientFactory.CreateClient();

            // API'den kategori verilerini çekmek için GET isteği gönderdik
            var responseMessage = await client.GetAsync("https://localhost:7051/api/Category");

            // API isteği başarılı (HTTP 200 OK) dönerse devam ediyoruz
            if (responseMessage.IsSuccessStatusCode)
            {
                // API'den dönen JSON formatındaki yanıt içeriğini string olarak aldık
                var jsonData = await responseMessage.Content.ReadAsStringAsync();

                // JSON formatındaki veriyi ResultCategoryDto türündeki nesnelerin listesine dönüştürdük
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);

                // Kategoriler listesini View'a göndererek ekranda görüntülenmesini sağladık
                return View(values);
            }

            // Eğer API isteği başarısız olursa, boş bir View döndürüyoruz
            return View();
        }

     
    }
}
