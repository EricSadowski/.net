namespace TripLog.Models
{
    public class TripViewModel
    {
        public int PageNumber { get; set; }
        public Trip Trip { get; set; } // assuming Trip class already exists
        public List<Destination> Destinations { get; set; }

        public List<Accommodation> Accommodations { get; set; }

        public TripViewModel()
        {
            Trip = new Trip();
            Destinations = new List<Destination>();
            Accommodations = new List<Accommodation>();
        }
    }
}
