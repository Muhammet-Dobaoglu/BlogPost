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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> TGetList()
        {
            return _categoryDal.GetList().ToList();
        }

        public Category TGetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public void TInsert(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void TDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void TUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

       
    }
}