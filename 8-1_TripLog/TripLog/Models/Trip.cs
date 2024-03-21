using System.ComponentModel.DataAnnotations;

namespace TripLog.Models
{
    public class Trip
    {
        public int TripId { get; set; }

        public Destination Destination { get; set; } = null!;

        [Required(ErrorMessage = "Please enter a destination.")]
        public int DestinationId { get; set; }

        public Accommodation Accommodation { get; set; } = null!;

        [Required(ErrorMessage = "Please enter an accommodation.")]
        public int AccommodationId { get; set; }


        [Required(ErrorMessage = "Please enter the date your trip starts.")]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "Please enter the date your trip ends.")]
        public DateTime? EndDate { get; set; }

        // optional fields
        public string? AccommodationPhone { get; set; }
        public string? AccommodationEmail { get; set; }

        public string? Activity1 { get; set; }
        public string? Activity2 { get; set; }
        public string? Activity3 { get; set; }
    }
}
