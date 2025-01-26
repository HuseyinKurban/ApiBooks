using ApiBooks.DataAccessLayer.Abstract;
using ApiBooks.DataAccessLayer.Context;
using ApiBooks.DataAccessLayer.Repositories;
using ApiBooks.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBooks.DataAccessLayer.EntityFramework
{
    public class EfBookDal : GenericRepository<Book>, IBookDal
    {
        private readonly ApiContext _context;

        public EfBookDal(ApiContext context) : base(context)
        {
            _context = context;
        }

        public List<Book> GetBooksByCategoryId(int id)
        {
           return _context.Books.Where(x=>x.CategoryId==id).ToList();
        }

        public List<Book> GetBooksWithWriterAndCategoryList()
        {
            //yazar ve category tablosunu kitap tablosuyla birleştirmek için 
            return _context.Books.Include(y => y.Writer).Include(t => t.Category).ToList();
        }

        public List<Book> GetLastFourBooks()
        {
            //eklenen son 4 kitap için olan method.
            return _context.Books.Include(y => y.Writer).Include(v => v.Category).OrderByDescending(x => x.BookId).Take(4).ToList();
        }

        public Book GetRandomBook()
        {
            //rasgele sıralamak için bu methodu kullanıyorum.
            var book = _context.Books.Include(x => x.Writer).Include(y => y.Category).OrderBy(q => Guid.NewGuid()).FirstOrDefault();
            return book;

        }

        public List<Book> GetRandomBooksForSale()
        {
           return _context.Books.Include(x => x.Writer).Include(y => y.Category).OrderBy(q => Guid.NewGuid()).Take(4).ToList();
        }
    }
}
