using System.ComponentModel.DataAnnotations;

namespace Test2.Models
{
    public class Subject
    {
        [Required]
        [StringLength(6, MinimumLength = 6)]
        public string Code { get; set; }
        [Required]

        public DateTime Date { get; set; }

        [Range(0, 4, ErrorMessage = "Credits must be between 0 and 4")]
        public int Credits { get; set; }

    }
}
