using BlogPost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPost.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult ErrorPage()
        {
            return View();
        }

    }
}
