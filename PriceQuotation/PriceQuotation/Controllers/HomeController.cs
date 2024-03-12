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
            ViewBag.DA = 0;
            ViewBag.Total = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(PriceQuotationModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.DA = model.CalculatePrice();
                ViewBag.Total = model.Subtotal - ViewBag.DA;
            }
            else
            {
                ViewBag.DA = 0;
                ViewBag.Total = 0;
            }
            return View(model);
        }
    }
}
