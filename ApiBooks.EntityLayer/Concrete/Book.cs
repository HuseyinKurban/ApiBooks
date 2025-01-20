using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBooks.EntityLayer.Concrete
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Page { get; set; }
        public string ImageUrl { get; set; }

        public int WriterId { get; set; }
        public Writer Writer { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
