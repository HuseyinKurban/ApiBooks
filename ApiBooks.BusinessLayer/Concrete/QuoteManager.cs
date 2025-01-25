using ApiBooks.BusinessLayer.Abstract;
using ApiBooks.DataAccessLayer.Abstract;
using ApiBooks.EntityLayer.Concrete;


namespace ApiBooks.BusinessLayer.Concrete
{
    public class QuoteManager : IQuoteService
    {
        private readonly IQuoteDal _quoteDal;

        public QuoteManager(IQuoteDal quoteDal)
        {
            _quoteDal = quoteDal;
        }

        public void TDelete(int id)
        {
           _quoteDal.Delete(id);
        }

        public List<Quote> TGetAll()
        {
            return _quoteDal.GetAll();
        }

        public Quote TGetById(int id)
        {
            return _quoteDal.GetById(id);
        }

        public void TInsert(Quote entity)
        {
            _quoteDal.Insert(entity);
        }

        public Quote TRandomQuote()
        {
           return _quoteDal.RandomQuote();
        }

        public void TUpdate(Quote entity)
        {
            _quoteDal.Update(entity);
        }
    }
}
