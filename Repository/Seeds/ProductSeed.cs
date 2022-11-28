using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Seeds;

public class ProductSeed : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData(new Product { Id = 1, CategoryId = 1,Name= "Faber-Castell", Price =100, Stock=20,CreateDate=DateTime.Now },
            new Product { Id = 2, CategoryId = 1, Name = "Rotring", Price = 75, Stock = 15, CreateDate = DateTime.Now },
            new Product { Id = 3, CategoryId = 3, Name = "The Fault in Our Stars", Price = 15, Stock = 320, CreateDate = DateTime.Now }
            ) ;
    }
}
