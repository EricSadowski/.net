using GuitarShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GuitarShop.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.Categories = new List<string>
{
"Guitars", "Basses", "Drums"
};
            return View();

        }
    }
}
