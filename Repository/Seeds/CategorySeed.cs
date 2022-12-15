using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Seeds;

public class CategorySeed : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(new Category { Id = 1, Name = "Pens" },
                        new Category { Id = 2, Name = "Notebooks" },
                        new Category { Id = 3, Name = "Books" });
    }
}
