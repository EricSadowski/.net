using College.Areas.Staff.Models;
using College.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace College.Areas.Staff.Controllers
{
    [Area("Staff")]
    public class HomeController : Controller
    {
        private CollegeContext context { get; set; }
        public HomeController(CollegeContext ctx) => context = ctx;

        [Authorize(Roles = "Staff")]
        public IActionResult Index()
        {
            var tasks = context.Tasks.ToList();

            var viewModel = new TaskListViewModel
            {
                Tasks = tasks
            };


            return View(viewModel);
        }

       [Authorize(Roles = "Staff")]
       [HttpGet]
       public IActionResult Add()
      {

           return View();
       }
       [Authorize(Roles = "Staff")]
       [HttpPost]
       public IActionResult Add(TaskItemViewModel vm)
       {
          if (ModelState.IsValid)
         {

              context.Tasks.Add(vm.TaskItem);
             context.SaveChanges();
           TempData["message"] = $"Book {vm.TaskItem.Description} added.";
            return RedirectToAction("Index", "Home");
        }
           else
        {
           return View(vm);
          }
       }

        [Authorize(Roles = "Staff")]
        [HttpPost]
        public IActionResult Delete(string id)
        {
            var task = context.Tasks.Find(id);
            if (task == null)
            {
                return NotFound();
            }

            context.Tasks.Remove(task);
            context.SaveChanges();
            TempData["message"] = $"Task {task.Description} deleted.";
            return RedirectToAction("Index", "Home");
        }


    }
}
