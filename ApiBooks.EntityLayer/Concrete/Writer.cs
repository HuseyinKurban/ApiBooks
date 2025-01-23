using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiBooks.EntityLayer.Concrete
{
    public class Writer
    {
        public int WriterId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string About { get; set; }
        public string ImageUrl { get; set; }

        // Nullable yaparak opsiyonel hale getiriyoruz yani zorunlu olmuyor
     
        public List<Book>? Books { get; set; }

    }
}
