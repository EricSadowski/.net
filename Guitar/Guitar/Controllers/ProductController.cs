using Microsoft.AspNetCore.Mvc;

namespace Guitar.Controllers
{
public class ProductController : Controller
{
        public
     IActionResult List(string id = "All", int page = 1, string sortby = "Price")
     {
            return Content("id=" + id + ", page=" + page +
                ",sortby = " + sortby);
     }
        public IActionResult Detail(int id)
    {
        return Content("Product controller, Detail action, id: "
        + id);
    }
}
}