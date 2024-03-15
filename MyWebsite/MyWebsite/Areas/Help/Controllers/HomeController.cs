using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Areas.Help.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // return View(); // Views/Home/Index.cshtml
            return Content("I am hereeeeeeeeee");
        }
    }
}
