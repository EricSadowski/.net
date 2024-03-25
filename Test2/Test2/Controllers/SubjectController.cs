using Microsoft.AspNetCore.Mvc;
using Test2.Data;
using Test2.Models;

namespace Test2.Controllers
{
    public class SubjectController : Controller
    {
        private ApplicationDbContext context { get; set; }
        public SubjectController(ApplicationDbContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(SubjectViewModel vm)
        {
            if (ModelState.IsValid)
            {

                context.Subjects.Add(vm.Subject);
               context.SaveChanges();
               
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(vm);
            }
        }
    }
}
