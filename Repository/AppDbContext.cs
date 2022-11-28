using Core.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configurations;
using System.Reflection;

namespace Repository;

public class AppDbContext:DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
	{
        //var p = new Product() { ProductFeature = new ProductFeature() { } }
		//When we create a product object, we can use it if we want it to be a product features object.
    }

    public DbSet<Category> Categories { get; set; }

	public DbSet<Product> Products { get; set; } 

	public DbSet<ProductFeature> ProductFeatures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Category>().HasKey(x => x.Id);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //modelBuilder.ApplyConfiguration(new ProductConfiguration());

        modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
        {
            Id= 1,
            Color="Blue",
            Height=20,
            Width=100,
            ProductId=1
        });

        base.OnModelCreating(modelBuilder);
    }
}
