using College.Areas.Student.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace College.Areas.Staff.Models
{
    internal class ConfigureTasks : IEntityTypeConfiguration<TaskItem>
    {

        public void Configure(EntityTypeBuilder<TaskItem> entity)
        {

            // seed initial data
            entity.HasData(
                new { Code = "A10", Description = "Go to work", Location="Online", Status = "Done" },
                new { Code = "A60", Description = "Go to school", Location = "In Person", Status = "In Progress" }
            );
        }
    }
}
