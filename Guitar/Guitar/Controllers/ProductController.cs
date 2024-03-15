using Microsoft.AspNetCore.Mvc;

namespace Guitar.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View("List"); // Views/Product/List.cshtml
        }
        public IActionResult List(string id = "All")
        {
            ViewBag.Category = id;
            return View(); // Views/Product/List.cshtml
        }
        public IActionResult Details(string id)
        {
            ViewBag.ProductSlug = id;
            return View(); // Views/Product/Details.cshtml
        }
    }
}