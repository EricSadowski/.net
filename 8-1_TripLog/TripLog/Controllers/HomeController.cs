using Microsoft.AspNetCore.Mvc;
using TripLog.Models;

namespace TripLog.Controllers
{
    public class HomeController : Controller
    {
        private TripLogContext context { get; set; }
        public HomeController(TripLogContext ctx) => context = ctx;

        public ViewResult Index()
        {
            var trips = context.Trips.OrderBy(t => t.StartDate).ToList();
            return View(trips);
        }
        public ViewResult Destinations()
        {
            var destinations = context.Destinations.ToList();
            return View(destinations);
        }

        public ViewResult Accommodations()
        {
            var accommodations = context.Accommodations.ToList();
            return View(accommodations);
        }
    }
}