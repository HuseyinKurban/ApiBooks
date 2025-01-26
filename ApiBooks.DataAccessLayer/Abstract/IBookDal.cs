using ApiBooks.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBooks.DataAccessLayer.Abstract
{
    public interface IBookDal:IGenericDal<Book>
    {
        List<Book> GetBooksWithWriterAndCategoryList();
        List<Book> GetLastFourBooks();
        List<Book> GetRandomBooksForSale();
        Book GetRandomBook();
    }
}
