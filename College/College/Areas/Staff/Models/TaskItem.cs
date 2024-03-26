using System.ComponentModel.DataAnnotations;

namespace College.Areas.Staff.Models
{
    public class TaskItem
    {
        [Key]
        public string? Code { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
