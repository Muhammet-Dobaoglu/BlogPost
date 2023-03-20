using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public About TGetByID(int id)
        {
            return _aboutDal.GetByID(id);
        }

        public void TInsert(About about)
        {
            _aboutDal.Insert(about);
        }

        public void TDelete(About about)
        {
            _aboutDal.Delete(about);
        }

        public void TUpdate(About about)
        {
            _aboutDal.Update(about);

        }
    }
}