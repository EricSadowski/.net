using static FAQapp.Models.Question;

namespace FAQapp.Models
{
    public class QuestionsRepository
    {

            private static List<Question> _questions = new List<Question>()
        {
            new Question { Id = 1, Q =  "What is bootstrap?", Answer = "A frontend framework ya doink", 
                Category = "General", Topic = "Bootstrap"},

            new Question { Id = 2, Q =  "What is Javascript?", Answer = "ITS JS LOL",
            Category  = "General", Topic = "Javascript"},

            new Question { Id = 2, Q =  "What is C#?", Answer = "ITS FRIGGIN MICROSOFT",
            Category  = "General", Topic = "CSharp"},

            new Question { Id = 2, Q =  "What happened on Sept 11 2001", Answer = "We don't talk about that JK terroism",
            Category  = "History", Topic = "CSharp"},

        };

            //public static void AddCategory(Category category)
            //{
            //    var maxId = _categories.Max(x => x.Id);
            //    category.Id = maxId + 1;
            //    _categories.Add(category);
            //}

            public static List<Question> GetQuestions() => _questions;

        public static Question? GetQuestionById(int qId)
        {
            var question = _questions.FirstOrDefault(x => x.Id == qId);
            if (question != null)
            {
                return new Question
                {
                    Id = question.Id,
                    Q = question.Q,
                    Answer = question.Answer,
                    Topic = question.Topic,
                    Category = question.Category
                };
            }
            return null;
        }


            //public static void UpdateCategory(int categoryId, Category category)
            //{
            //    if (categoryId != category.Id) return;
            //    var categoryToUpdate = _categories.FirstOrDefault(x => x.Id == categoryId);
            //    if (categoryToUpdate != null)
            //    {
            //        categoryToUpdate.Name = category.Name;
            //        categoryToUpdate.Description
            //        =
            //        category.Description;

            //    }
            //}

            //public static void DeleteCategory(int categoryId)
            //{
            //    var category = _categories.FirstOrDefault(x => x.Id == categoryId);
            //    if (category != null)
            //    {
            //        _categories.Remove(category);
            //    }
            //}
        }
    }

