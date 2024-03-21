using System.ComponentModel.DataAnnotations;

namespace EFcore.Models
{
    public class Book
    {
        [Key]
        public string? ISBN { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;
        public double Price { get; set; }

        public double Discount {  get; set; }
        
        public int GenreId { get; set; }

        public Genre Genre { get; set; } = null!;
    }
}
