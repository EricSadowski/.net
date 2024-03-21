using FAQapp.Models;
using Microsoft.AspNetCore.Mvc;
using static FAQapp.Models.Question;

namespace FAQapp.Controllers
{
    public class HomeController : Controller
    {

            public IActionResult Index(string topic, string category, int? id)
            {
                if (!string.IsNullOrEmpty(topic) || !string.IsNullOrEmpty(category))
                {
                    var filteredData = GetDataFilteredBy(topic, category);
                    return View(filteredData);
                }

                var questions = QuestionsRepository.GetQuestions();
                return View(questions);
            }


        //[Route("/")]
        //[Route("/home/index")]
        //public IActionResult Index()
        //    {
        //        var questions = QuestionsRepository.GetQuestions();
        //        return View(questions);
        //    }






        private IEnumerable<Question> GetDataFilteredBy(string? topic, string? category)
        {
            var data = QuestionsRepository.GetQuestions();
            var filteredData = new List<Question>();

            if (category != null && topic != null)
            {
                foreach (var item in data)
                {
                    if (topic != null && item.Topic.ToString().Equals(topic, StringComparison.OrdinalIgnoreCase) &&
                        category != null && item.Category.ToString().Equals(category, StringComparison.OrdinalIgnoreCase))
                    {
                        filteredData.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in data)
                {
                    if (topic != null && item.Topic.ToString().Equals(topic, StringComparison.OrdinalIgnoreCase))
                    {
                        filteredData.Add(item);
                    }
                    else if (category != null && item.Category.ToString().Equals(category, StringComparison.OrdinalIgnoreCase))
                    {
                        filteredData.Add(item);
                    }
                }
            }

            return filteredData;
        }
    }
}
