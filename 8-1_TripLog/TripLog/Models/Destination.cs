namespace TripLog.Models
{
    public class Destination
    {
        public Destination() => Trips = new HashSet<Trip>();
        public int DestinationId { get; set; }
        public string Name { get; set; } = string.Empty;
        // navigation property
        public ICollection<Trip> Trips { get; set; }
    }
}
