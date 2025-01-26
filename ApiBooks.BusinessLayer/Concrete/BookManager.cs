using ApiBooks.BusinessLayer.Abstract;
using ApiBooks.DataAccessLayer.Abstract;
using ApiBooks.EntityLayer.Concrete;
using ApiBooks.WebUI.Areas.Admin.Dto.BookDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBooks.BusinessLayer.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }


        public void TDelete(int id)
        {
           _bookDal.Delete(id);
            
        }

        public List<Book> TGetAll()
        {
           return _bookDal.GetAll();
        }

        public List<Book> TGetBooksWithWriterAndCategoryList()
        {
           return _bookDal.GetBooksWithWriterAndCategoryList();
        }

        public Book TGetById(int id)
        {
            return _bookDal.GetById(id);
        }

        public List<Book> TGetLastFourBooks()
        {
            return _bookDal.GetLastFourBooks();
        }

        public Book TGetRandomBook()
        {
           return _bookDal.GetRandomBook();
        }

        public List<Book> TGetRandomBooksForSale()
        {
           return _bookDal.GetRandomBooksForSale();
        }

        public void TInsert(Book entity)
        {
            _bookDal.Insert(entity);
        }

        public void TUpdate(Book entity)
        {
           _bookDal.Update(entity);
        }
    }
}
