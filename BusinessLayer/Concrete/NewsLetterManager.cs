using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsLetterDal;
        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public void TDelete(NewsLetter t)
        {
            _newsLetterDal.Delete(t);
        }

        public List<NewsLetter> TGetList()
        {
            return _newsLetterDal.GetList();
        }

        public NewsLetter TGetByID(int id)
        {
            return _newsLetterDal.GetByID(id);
        }

        public void TInsert(NewsLetter newsLetter)
        {
            _newsLetterDal.Insert(newsLetter);
        }

        public void TUpdate(NewsLetter newsLetter)
        {
            _newsLetterDal.Update(newsLetter);
        }

    }
}
