using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace College.Areas.Student.Models
{
    internal class ConfigureDuties : IEntityTypeConfiguration<DutyItem>
    {

            public void Configure(EntityTypeBuilder<DutyItem> entity)
            {

                // seed initial data
                entity.HasData(
                    new { Code="AB10", Description="Go to work", Status="Done"},
                    new { Code = "AB60", Description = "Go to school", Status = "Done" }
                );
            }
        }
    }

