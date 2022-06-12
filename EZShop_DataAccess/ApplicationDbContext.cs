using System.Security.Cryptography.X509Certificates;
using EZShop_DataAccess;
using Microsoft.EntityFrameworkCore;

namespace EZShop_DataAccess;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        new ProductConfiguration(modelBuilder.Entity<Product>());
        new CategoryConfiguration(modelBuilder.Entity<Category>());
        new ProductCategoryConfiguration(modelBuilder.Entity<ProductCategory>());
    }

    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<ProductCategory> ProductCategories { get; set; }
}