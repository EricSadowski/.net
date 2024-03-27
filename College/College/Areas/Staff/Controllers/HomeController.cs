using College.Areas.Staff.Models;
using College.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace College.Areas.Staff.Controllers
{
    [Area("Staff")]
    [Authorize(Roles = "Staff")]
    public class HomeController : Controller
    {
        private CollegeContext context { get; set; }
        public HomeController(CollegeContext ctx) => context = ctx;

        
        public IActionResult Index()
        {
            var tasks = context.Tasks.ToList();

            var viewModel = new TaskListViewModel
            {
                Tasks = tasks
            };


            return View(viewModel);
        }

      
       [HttpGet]
       public IActionResult Add()
      {

           return View();
       }
       
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

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var task = context.Tasks.Find(id);

            if (task == null)
            {
                return NotFound();
            }

            return View(task);
        }

        [HttpPost]
        public IActionResult Edit(TaskItem task)
        {


            context.Tasks.Update(task);

            context.SaveChanges();
            TempData["message"] = $"Task {task.Description} updated.";
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Cancel()
        {
            return RedirectToAction("Index", "Home");
        }


    }
}
