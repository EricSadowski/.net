using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BigSales.Models
{
    public class SalesContext : IdentityDbContext<IdentityUser>
    {
        public SalesContext(DbContextOptions<SalesContext> options)
            : base(options)
        { }

        public DbSet<Sales> Sales { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(x => x.UserId);
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    Firstname = "Joyce",
                    Lastname = "Valdez",
                    DOB = new DateTime(1956, 12, 10),
                    DateOfHire = new DateTime(1995, 1, 1),
                    ManagerId = 0  // has no manager
                },
                new Employee
                {
                    EmployeeId = 2,
                    Firstname = "Joanna",
                    Lastname = "Griffin",
                    DOB = new DateTime(1966, 8, 26),
                    DateOfHire = new DateTime(1999, 1, 1),
                    ManagerId = 1  
                },
                new Employee
                {
                    EmployeeId = 3,
                    Firstname = "Elvin",
                    Lastname = "Vang",
                    DOB = new DateTime(1975, 12, 9),
                    DateOfHire = new DateTime(1999, 1, 1),
                    ManagerId = 1
                }
            );

            modelBuilder.Entity<Sales>().HasData(
                new Sales
                {
                    SalesId = 1,
                    Quarter = 4,
                    Year = 2021,
                    Amount = 23456,
                    EmployeeId = 2
                },
                new Sales
                {
                    SalesId = 2,
                    Quarter = 1,
                    Year = 2022,
                    Amount = 34567,
                    EmployeeId = 2
                },
                new Sales
                {
                    SalesId = 3,
                    Quarter = 4,
                    Year = 2021,
                    Amount = 19876,
                    EmployeeId = 3
                },
                new Sales
                {
                    SalesId = 4,
                    Quarter = 1,
                    Year = 2022,
                    Amount = 31009,
                    EmployeeId = 3
                }
            );
        }

    }
}
