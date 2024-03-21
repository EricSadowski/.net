using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EFcore.Models
{
    internal class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> entity)
        {
            entity.HasKey(b => b.ISBN);
            entity.Property(b => b.Title)
            .IsRequired().HasMaxLength(200);
            entity.HasData(
            new Book
            {
                ISBN = "1548547298",
                Title = "The Hobbit"
            },
            new Book
            {
                ISBN = "0312283709",
                Title = "Running With Scissors"
            }
            );
        }
    }
}
