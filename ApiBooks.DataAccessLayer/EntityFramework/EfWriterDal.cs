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
    public class EfWriterDal : GenericRepository<Writer>, IWriterDal
    {
        private readonly ApiContext _context;
        public EfWriterDal(ApiContext context) : base(context)
        {
            _context = context;
        }

        public List<Writer> GetLastWriter()
        {
            return _context.Writers.Include(w => w.Books).OrderByDescending(w=>w.Books.Count).Take(3).ToList();
        }


    }
}
