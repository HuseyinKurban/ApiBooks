﻿using ApiBooks.BusinessLayer.Abstract;
using ApiBooks.DataAccessLayer.Abstract;
using ApiBooks.EntityLayer.Concrete;
using ApiBooks.WebUI.Areas.Admin.Dto.WriterDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBooks.BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {

        private readonly IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void TDelete(int id)
        {
            _writerDal.Delete(id);
        }

        public List<Writer> TGetAll()
        {
            return _writerDal.GetAll();
        }

        public Writer TGetById(int id)
        {
            return _writerDal.GetById(id);
        }

        public List<Writer> TGetLastWriter()
        {
           return _writerDal.GetLastWriter();
        }

        public void TInsert(Writer entity)
        {
           _writerDal.Insert(entity);
        }

        public void TUpdate(Writer entity)
        {
            _writerDal.Update(entity);
        }
    }
}
