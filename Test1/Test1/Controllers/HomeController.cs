using Microsoft.AspNetCore.Mvc;

namespace Test1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult About()
        {
            var about = new Dictionary<string, string> {
                { "Eric Sadowski", "2338163" },
            };
            return View();
        }

        public IActionResult Contact()
        {
            var contacts = new Dictionary<string, string> {
                { "Phone", "555-123-4567" },
                { "Email", "ericcsadowski@gmail.com" },
                { "LinkedIn", "https://www.linkedin.com/in/eric-sadowski/" }
            };
            return View(contacts);
        }
    }
}
