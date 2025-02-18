﻿using ApiBooks.WebUI.Areas.Admin.Dto.CategoryDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiBooks.WebUI.ViewComponents
{
    public class _PopularBooksComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _PopularBooksComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
      
            var client = _httpClientFactory.CreateClient();

        
            var responseMessage = await client.GetAsync("https://localhost:7051/api/Category");

       
            if (responseMessage.IsSuccessStatusCode)
            {
           
                var jsonData = await responseMessage.Content.ReadAsStringAsync();

           
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);

                return View(values);
            }

       
            return View();
        }
    }
}
