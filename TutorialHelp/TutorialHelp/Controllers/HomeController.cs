using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Tutorial.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var contacts = new Dictionary<string, string> {
                { "Phone", "555-123-4567" },
                { "Email", "me@mywebsite.com" },
                { "Facebook", "facebook.com/mywebsite" }
            };
            return View(contacts);
        }
    }
}
