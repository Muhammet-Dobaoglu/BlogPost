using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogPost.ViewComponents.Blog
{
	public class WriterLastBlog : ViewComponent
	{
		BlogManager blogManager = new BlogManager(new EFBlogDal());
		public IViewComponentResult Invoke(int id)
		{
			var values = blogManager.TGetListWithWriter(id);
			return View(values);
		}
	}
}
