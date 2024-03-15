using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Areas.Help.Controllers
{
    public class TutorialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
