using ApiBooks.EntityLayer.Concrete;

namespace ApiBooks.WebUI.Areas.Admin.Dto.BookDto
{
    public class GetRandomBookDto
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Page { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int WriterId { get; set; }
        public Writer Writer { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
