using Microsoft.AspNetCore.Mvc;
using QuarterlySales.Models;

namespace QuarterlySales.Controllers
{
    public class EmployeeController : Controller
    {
        private SalesContext context { get; set; }
        public EmployeeController(SalesContext ctx) => context = ctx;

        public IActionResult Index() => RedirectToAction("Index", "Home");

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Employees = context.Employees.OrderBy(e => e.Firstname).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            // server side checks for remote validation
            string msg = Validate.CheckEmployee(context, employee);
            if (!string.IsNullOrEmpty(msg)) { 
                ModelState.AddModelError(nameof(Employee.DOB), msg);
            }
            msg = Validate.CheckManagerEmployeeMatch(context, employee);
            if (!string.IsNullOrEmpty(msg)) { 
                ModelState.AddModelError(nameof(Employee.ManagerId), msg);
            }

            if (ModelState.IsValid) {
                context.Employees.Add(employee);
                context.SaveChanges();
                TempData["message"] = $"Employee {employee.Fullname} added";
                return RedirectToAction("Index", "Home");
            }
            else {
                ViewBag.Employees = context.Employees.OrderBy(e => e.Firstname).ToList();
                return View();
            }
        }
    }
}