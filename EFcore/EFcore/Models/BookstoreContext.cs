using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace EFcore.Models
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Author> Authors { get; set; } = null!;
        protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
        {
            // code that configures the DbContext goes here
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(
        ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfig());
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>()
.HasOne(b => b.Genre) // nav property in Book class
.WithMany(g => g.Books); // nav property in Genre class

            /* modelBuilder.Entity<Book>().HasKey(b => b.ISBN);
             modelBuilder.Entity<Book>()
             .Property(b => b.Title).IsRequired().HasMaxLength(200);
             // code that configures the DbSet entities goes here
             base.OnModelCreating(modelBuilder);

             modelBuilder.Entity<Book>().HasData(
                 new Book
                 {
                     ISBN = "1548547298",
                     Title = "The Hobbit"
                 },
                 new Book
                 {
                     ISBN = "0312283709",
                     Title = "Running With Scissors"
                 });*/
        }
    }
}
