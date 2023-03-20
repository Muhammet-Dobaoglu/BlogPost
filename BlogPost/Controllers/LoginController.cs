using Microsoft.AspNetCore.Mvc;

namespace BlogPost.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
