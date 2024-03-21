using Microsoft.AspNetCore.Mvc;
using TripLog.Models;

namespace TripLog.Controllers
{
    public class TripController : Controller
    {
        private TripLogContext context { get; set; }
        public TripController(TripLogContext ctx) => context = ctx;

        public RedirectToActionResult Index() => RedirectToAction("Add", new { id = "page1"});

        [HttpGet]
        public ViewResult Add(string id = "")
        {
            var vm = new TripViewModel();

            /*********************************************************************
            * use Peek() method to read TempData values and make sure they persist
            **********************************************************************/
            if (id.ToLower() == "page2")
            {
                vm.PageNumber = 2;
                vm.Trip.Accommodation.Name = TempData.Peek(nameof(Trip.Accommodation.Name))?.ToString()!;
                return View("Add2", vm);  
            }  
            else if (id.ToLower() == "page3") 
            {
                vm.PageNumber = 3;
                vm.Trip.Destination.Name = TempData.Peek(nameof(Trip.Destination.Name))?.ToString()!;
                return View("Add3", vm);
            }
            else 
            {
                vm.PageNumber = 1;
                vm.Destinations = context.Destinations.ToList();
                vm.Accommodations = context.Accommodations.ToList();
                return View("Add1", vm);
            }      
        }



        [HttpPost]
        public IActionResult Add(TripViewModel vm)
        {
            if (vm.PageNumber == 1)
            {
                if (ModelState.IsValid) // only page 1 has required data
                {
                    /***************************************************
                    * Store data in TempData and redirect (PRG pattern)
                    ****************************************************/
                    TempData[nameof(Trip.DestinationId)] = vm.Trip.DestinationId;
                    TempData[nameof(Trip.AccommodationId)] = vm.Trip.AccommodationId;
                    TempData[nameof(Trip.StartDate)] = vm.Trip.StartDate;
                    TempData[nameof(Trip.EndDate)] = vm.Trip.EndDate;
                    return RedirectToAction("Add", new { id = "Page2" });
                }
                else
                {
                    return View("Add1", vm);
                }
            }
            else if (vm.PageNumber == 2)
            {
                /***************************************************
                * Store data in TempData and redirect (PRG pattern)
                ****************************************************/
                TempData[nameof(Trip.AccommodationPhone)] = vm.Trip.AccommodationPhone;
                TempData[nameof(Trip.AccommodationEmail)] = vm.Trip.AccommodationEmail;
                return RedirectToAction("Add", new { id = "Page3" });
            }
            else if (vm.PageNumber == 3)
            {
                /***************************************************
                * Don't need data in TempData to persist after 
                * updating database, so do straight read.
                ****************************************************/
                vm.Trip.Destination.Name = TempData[nameof(Trip.Destination.Name)]?.ToString()!;
                vm.Trip.Accommodation.Name = TempData[nameof(Trip.Accommodation.Name)]?.ToString()!;
                vm.Trip.StartDate = (DateTime)TempData[nameof(Trip.StartDate)]!;
                vm.Trip.EndDate = (DateTime)TempData[nameof(Trip.EndDate)]!;
                vm.Trip.AccommodationPhone = TempData[nameof(Trip.AccommodationPhone)]?.ToString()!;
                vm.Trip.AccommodationEmail = TempData[nameof(Trip.AccommodationEmail)]?.ToString()!;

                context.Trips.Add(vm.Trip);
                context.SaveChanges();
                TempData["message"] = $"Trip to {vm.Trip.Destination.Name} added.";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        public RedirectToActionResult Cancel()
        {
            TempData.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}