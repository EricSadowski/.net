using System.ComponentModel.DataAnnotations;

namespace FAQapp.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        public string Q { get; set; } = string.Empty;
        [Required]
        public string Answer { get; set; } = string.Empty;

        public string Topic { get; set; }

        public string Category { get; set; }

        //public enum Topic {
        //Javascript, Bootstrap, CSharp}


        //    public enum Category
        //{
        //    General,
        //    History
        //}
    }
}
