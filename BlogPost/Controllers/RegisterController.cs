using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update;

namespace BlogPost.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager writerManager = new WriterManager(new EFWrriterDal());

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Writer writer)
		{
			WriterValidator wv = new WriterValidator();
			ValidationResult results = wv.Validate(writer);
			
			if (results.IsValid)
			{
				writer.WriterStatus = true;
				writer.WriterAbout = "Lorem";
                writerManager.TInsert(writer);
				return RedirectToAction("Index", "Blog");
			}
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

        }
	}
}
