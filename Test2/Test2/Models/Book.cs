using Humanizer.Localisation;
using System.ComponentModel.DataAnnotations;

namespace Test2.Models
{
    public class Book
    {
        [Key]
        public string? ISBN { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [Range(0, 300, ErrorMessage = "Price must be less than 300$")]
        public double Price { get; set; }

        public DateTime Date { get; set; }

        public string Author { get; set; }


        //public int GenreId { get; set; }

        //public Genre Genre { get; set; } = null!;
    }
}

