﻿using ApiBooks.DataAccessLayer.Abstract;
using ApiBooks.DataAccessLayer.Context;
using ApiBooks.DataAccessLayer.Repositories;
using ApiBooks.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBooks.DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        private readonly ApiContext _context;

        public EfFeatureDal(ApiContext context) : base(context)
        {
            _context = context;
        }

    }
}
