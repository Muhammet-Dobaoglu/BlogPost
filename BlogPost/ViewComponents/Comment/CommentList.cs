using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace BlogPost.ViewComponents
{
	public class CommentList:ViewComponent
	{
		CommentManager commentManager = new CommentManager(new EFCommentDal());
		public IViewComponentResult Invoke(int id)
		{	
			var values = commentManager.TGetBlogByID(id);
			return View(values);
		}
	}
}
