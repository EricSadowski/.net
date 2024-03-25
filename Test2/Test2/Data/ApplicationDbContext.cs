using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Test2.Models;

namespace Test2.Data
{


    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Book> Books { get; set; } = null!;

        public DbSet<Subject> Subjects { get; set; } = null!;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(
ModelBuilder modelBuilder)
        {

             modelBuilder.Entity<Book>().HasKey(b => b.ISBN);
             modelBuilder.Entity<Book>()
             .Property(b => b.Title).IsRequired().HasMaxLength(200);
             // code that configures the DbSet entities goes here
             base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                   new Book
                   {
                       ISBN = "9781593288846",
                       Title = "Videogames",
                       Price = 6,
                       Date = new DateTime(2000, 12, 01),
                       Author = "Mario"
                   },
                   new Book
                   {
                       ISBN = "9781488957660",
                       Title = "Cheeseland",
                       Price = 30.50,
                       Date = new DateTime(2001, 05, 15),
                       Author = "Eric"
                   });

                //            modelBuilder.Entity<Subject>().HasData(
                //    new Subject
                //    {
                //        SubjectId = 1,
                //        Date = new DateTime(2023, 6, 15),
                //        Credits = 2
                //    },
                //    new Subject
                //    {
                //        SubjectId = 2,
                //        Date = new DateTime(2000, 5, 11),
                //        Credits = 4
                //    }

                //);
        }
    }
}
