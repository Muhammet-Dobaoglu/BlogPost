using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogPost.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager CategoryManager = new CategoryManager(new EFCategoryDal());
        public IActionResult Index()
        {
            var values = CategoryManager.TGetList();
            return View(values);
        }
    }
}
