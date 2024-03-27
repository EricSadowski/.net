
using College.Areas.Student.Models;
using College.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace College.Areas.Student.Controllers
{

    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class HomeController : Controller
    {
        private CollegeContext context { get; set; }
        public HomeController(CollegeContext ctx) => context = ctx;


        public IActionResult Index()
        {
            var duties = context.Duties.ToList();

            var viewModel = new DutyListViewModel
            {
                Duties = duties
            };


            return View(viewModel);
        }


        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Add(DutyViewModel vm)
        {
            if (ModelState.IsValid)
            {

                context.Duties.Add(vm.Duty);
                context.SaveChanges();
                TempData["message"] = $"Duty {vm.Duty.Description} added.";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(vm);
            }
        }


        [HttpPost]
        public IActionResult Delete(string id)
        {
            var duty = context.Duties.Find(id);
            if (duty == null)
            {
                return NotFound();
            }

            context.Duties.Remove(duty);
            context.SaveChanges();
            TempData["message"] = $"Duty {duty.Description} deleted.";
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            // Retrieve the task with the given id from the database or any other data source
            var duty = context.Duties.Find(id);

            if (duty == null)
            {
                // If the task is not found, you can handle it accordingly (e.g., display an error message)
                return NotFound();
            }

            // Pass the task to the view for editing
            return View(duty);
        }

        [HttpPost]
        public IActionResult Edit(Duty duty)
        {

            // Retrieve the task with the given id from the database or any other data source
            // var taskToChange = context.Tasks.Find(task.Code);

            context.Duties.Update(duty);

            context.SaveChanges();
            TempData["message"] = $"Task {duty.Description} updated.";
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Cancel()
        {
            return RedirectToAction("Index", "Home");
        }



    }
}
