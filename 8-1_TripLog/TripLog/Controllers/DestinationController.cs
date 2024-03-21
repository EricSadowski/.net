using Microsoft.AspNetCore.Mvc;
using TripLog.Models;

namespace TripLog.Controllers
{
    public class DestinationController : Controller
    {
        private TripLogContext context { get; set; }
        public DestinationController(TripLogContext ctx) => context = ctx;
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(DestinationViewModel vm)
        {
            if (ModelState.IsValid)
            {

                context.Destinations.Add(vm.Destination);
                context.SaveChanges();
                TempData["message"] = $"Destination {vm.Destination.Name} added.";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(vm);
            }
        }
    }
}
