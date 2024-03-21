using Microsoft.AspNetCore.Mvc;

namespace Tutorial.Areas.Help
{
    [Area("Help")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}