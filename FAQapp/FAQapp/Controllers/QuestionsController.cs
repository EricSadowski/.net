using Microsoft.AspNetCore.Mvc;
using FAQapp.Models;

namespace FAQapp.Controllers
{
    public class QuestionsController : Controller
    {
        public IActionResult Index()
        {
            var questions = QuestionsRepository.GetQuestions();
            return View(questions);
        }
    }
}
