using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test2.Data;
using Test2.Models;

namespace Test2.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationDbContext context { get; set; }
        public HomeController(ApplicationDbContext ctx) => context = ctx;


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [Authorize]
        public IActionResult Secret()
        {
            return View();
        }

        [Authorize]
        public IActionResult Lists()
        {

            var books = context.Books.ToList(); 
            var subjects = context.Subjects.ToList();

            var viewModel = new ListsViewModel
            {
                Books = books,
                Subjects = subjects
            };

            return View(viewModel);

        }
            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
