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
    public class EfQuoteDal : GenericRepository<Quote>, IQuoteDal
    {
        private readonly ApiContext _context;

        public EfQuoteDal(ApiContext context) : base(context)
        {
            _context = context;
        }

        public Quote RandomQuote()
        {
            return _context.Quotes.OrderBy(q => Guid.NewGuid()).FirstOrDefault();

        }
    }
}
