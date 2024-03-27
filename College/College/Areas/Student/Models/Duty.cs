using System.ComponentModel.DataAnnotations;

namespace College.Areas.Student.Models
{
    public class Duty
    {
        [Key]
        [RegularExpression(@"^(?=(?:.*[0-9]){2})(?=(?:.*[A-Z]){2})[0-9A-Z]{4}$", ErrorMessage = "The Code field must have exactly 4 characters containing 2 digits and 2 letters")]
        public string? Code { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; } = string.Empty;

        public string Status { get; set; }
    }
}
