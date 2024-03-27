using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using College.Models;
using College.Areas.Student.Models;
using College.Areas.Staff.Models;

namespace College.Data;

public class CollegeContext : IdentityDbContext<IdentityUser>
{
    public CollegeContext(DbContextOptions<CollegeContext> options)
        : base(options)
    {
    }

    public DbSet<Duty> Duties { get; set; } = null!;
    public DbSet<TaskItem> Tasks { get; set; } = null!;
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ConfigureDuties());
        builder.ApplyConfiguration(new ConfigureTasks());
    }
}
