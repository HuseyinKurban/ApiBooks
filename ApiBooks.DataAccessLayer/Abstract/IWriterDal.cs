﻿using ApiBooks.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBooks.DataAccessLayer.Abstract
{
    public interface IWriterDal:IGenericDal<Writer>
    {
        List<Writer> GetLastWriter();
    }
}
