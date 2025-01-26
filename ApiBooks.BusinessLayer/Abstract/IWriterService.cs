using ApiBooks.EntityLayer.Concrete;
using ApiBooks.WebUI.Areas.Admin.Dto.WriterDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBooks.BusinessLayer.Abstract
{
    public interface IWriterService:IGenericService<Writer>
    {
        List<Writer> TGetLastWriter();
    }
}
