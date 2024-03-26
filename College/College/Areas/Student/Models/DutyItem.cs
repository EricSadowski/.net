using System.ComponentModel.DataAnnotations;

namespace College.Areas.Student.Models
{
    public class DutyItem
    {
        [Key]
        public string? Code { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; } = string.Empty;

        public string Status { get; set; }
    }
}
