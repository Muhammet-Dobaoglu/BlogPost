using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;
        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public List<Writer> GetWriterById(int id)
        {
            //return _writerDal.GetAll(x => x.WriterId == id);
            throw new NotImplementedException();
        }

        public void TInsert(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        public void TDelete(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public List<Writer> TGetList()
        {
            return _writerDal.GetList();
        }

        public Writer TGetByID(int id)
        {
            return _writerDal.GetByID(id);
        }

        public void TUpdate(Writer writer)
        {
            _writerDal.Update(writer);
        }
    }
}