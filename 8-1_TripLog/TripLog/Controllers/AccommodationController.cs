using Microsoft.AspNetCore.Mvc;
using TripLog.Models;

namespace TripLog.Controllers
{
    public class AccommodationController : Controller
    {
        private TripLogContext context { get; set; }
        public AccommodationController(TripLogContext ctx) => context = ctx;
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AccommodationViewModel vm)
        {
            if (ModelState.IsValid)
            {

                context.Accommodations.Add(vm.Accommodation);
                context.SaveChanges();
                TempData["message"] = $"Accommodation {vm.Accommodation.Name} added.";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(vm);
            }
        }
    }
}
