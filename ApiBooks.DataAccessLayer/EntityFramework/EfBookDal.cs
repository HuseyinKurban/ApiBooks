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

        public List<Book> GetBooksWithWriterAndCategoryList()
        {
         return  _context.Books.Include(y=>y.Writer).Include(t=>t.Category).ToList();
        }

        public List<Book> GetLastFourBooks()
        {
            return _context.Books.OrderByDescending(x=>x.BookId).Take(4).ToList();
        }
    }
}
