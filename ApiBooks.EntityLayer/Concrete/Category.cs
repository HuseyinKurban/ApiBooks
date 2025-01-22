using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiBooks.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

       

        // Nullable yaparak opsiyonel hale getiriyoruz yani zorunlu olmuyor
        [JsonIgnore] // Sonsuz döngüyü önlemek için
        public List<Book>? Books { get; set; } 
    }
}
