namespace TripLog.Models
{
    public class Accommodation
    {
        public Accommodation() => Trips = new HashSet<Trip>();
        public int AccommodationId { get; set; }
        public string Name { get; set; } = string.Empty;
        // navigation property
        public ICollection<Trip> Trips { get; set; }
    }
}
