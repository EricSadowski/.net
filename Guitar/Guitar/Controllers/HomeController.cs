using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Guitar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Views/Home/Index.cshtml
        }
    }
}
 