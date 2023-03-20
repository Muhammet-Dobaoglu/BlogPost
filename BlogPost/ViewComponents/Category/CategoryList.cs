using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogPost.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
        public IViewComponentResult Invoke()
        {
            var values = categoryManager.TGetList();
            return View(values);
        }
    }
}
