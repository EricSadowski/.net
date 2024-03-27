using System.ComponentModel.DataAnnotations;

namespace College.Areas.Staff.Models
{
    public class TaskItem
    {
        [Key]
        [RegularExpression(@"^(?=.*[0-9])(?=.*[a-zA-Z]{2})[0-9a-zA-Z]{3}$", ErrorMessage = "The Code field must have exactly 3 characters containing 1 digit and 2 letters")]
        public string? Code { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
