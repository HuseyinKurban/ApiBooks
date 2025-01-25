using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBooks.EntityLayer.Concrete
{
    public class Quote
    {
        public int QuoteId { get; set; }

        public string Description { get; set; }

        public string WriterNameSurname { get; set; }
    }
}
