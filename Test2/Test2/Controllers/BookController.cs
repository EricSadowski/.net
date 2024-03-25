using Microsoft.AspNetCore.Mvc;
using Test2.Data;
using Test2.Models;

namespace Test2.Controllers
{
    public class BookController : Controller
    {

        private ApplicationDbContext context { get; set; }
        public BookController(ApplicationDbContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(BookViewModel vm)
        {
            if (ModelState.IsValid)
            {

                context.Books.Add(vm.Book);
                context.SaveChanges();
                TempData["message"] = $"Book {vm.Book.Title} added.";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(vm);
            }
        }
    }
}
