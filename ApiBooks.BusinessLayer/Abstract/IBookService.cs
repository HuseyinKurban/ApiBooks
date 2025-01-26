using ApiBooks.EntityLayer.Concrete;
using ApiBooks.WebUI.Areas.Admin.Dto.BookDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBooks.BusinessLayer.Abstract
{
    public interface IBookService:IGenericService<Book>
    {
        List<Book> TGetBooksWithWriterAndCategoryList();
        List<Book> TGetLastFourBooks();
        List<Book> TGetRandomBooksForSale();
        Book TGetRandomBook();

    }
}
