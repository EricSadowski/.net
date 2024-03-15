using Microsoft.AspNetCore.Mvc;
using PriceQuotation.Models;
using System.Diagnostics;

namespace PriceQuotation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Total = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(HexConvertModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Total = model.CalculateHex();
            }
            else
            {
                ViewBag.Total = 0;
            }
            return View(model);
        }
    }
}
