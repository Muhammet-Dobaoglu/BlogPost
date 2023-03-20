using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogPost.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EFCommentDal());
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }


    }
}
