using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogPost.Controllers
{
    public class BlogController : Controller
    {
        BlogManager _blogManager = new BlogManager(new EFBlogDal());
        public IActionResult Index()
        {
            var values = _blogManager.TGetListWithCategory();
            return View(values);
        }

        public IActionResult BlogDetails(int id)
        {
            ViewBag.Id = id;
            var values = _blogManager.TGetBlogByID(id);
			return View(values);
        }

    }
}
