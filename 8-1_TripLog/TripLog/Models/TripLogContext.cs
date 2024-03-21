using Microsoft.EntityFrameworkCore;

namespace TripLog.Models
{
    public class TripLogContext : DbContext
    {
        public TripLogContext(DbContextOptions<TripLogContext> options)
            : base(options)
        { }

        public DbSet<Trip> Trips { get; set; } = null!;

        public DbSet<Destination> Destinations { get; set; } = null!;

        public DbSet<Accommodation> Accommodations { get; set; } = null!;

        protected override void OnModelCreating(
ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TripConfig());
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Trip>()
            .HasOne(b => b.Destination) // nav property in Book class
            .WithMany(g => g.Trips)
            .HasForeignKey(t => t.DestinationId)
            .OnDelete(DeleteBehavior.Restrict);

             modelBuilder.Entity<Trip>()
             .HasOne(t => t.Accommodation)
             .WithMany(a => a.Trips)
             .HasForeignKey(t => t.AccommodationId)
             .OnDelete(DeleteBehavior.Restrict);
    
            
        }
    }
}