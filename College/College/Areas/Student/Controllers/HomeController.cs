using College.Areas.Student.Models;
using College.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace College.Areas.Student.Controllers
{
    [Area("Student")]
    public class HomeController : Controller
    {

        private CollegeContext context { get; set; }
        public HomeController(CollegeContext ctx) => context = ctx;


        [Authorize(Roles = "Student")]
        public IActionResult Index()
        {
            var duties = context.Duties.ToList();

            var viewModel = new DutyViewModel
            {
                Duties = duties
            };


            return View(viewModel);
        }
    }
}
