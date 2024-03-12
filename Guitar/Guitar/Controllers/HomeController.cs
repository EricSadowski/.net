using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Guitar.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
public IActionResult Index()
  {
      ViewBag.Categories = new List<string>
      {
       "Guitars", "Basses", "Drums"
      };
            ViewBag.ProductID = 3;
    return View();
    }
}
 
}