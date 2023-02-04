using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EZShop_DataAccess;

public class ProductCategoryConfiguration
{
    public ProductCategoryConfiguration(EntityTypeBuilder<ProductCategory> builder)
    {
        // builder.HasKey(x => new { x.CategoryId, x.ProductId });
        builder.HasKey(x => x.CategoryId);

        builder.HasKey(bc => new { bc.ProductId, bc.CategoryId });

        builder.HasOne(bc => bc.Product)
             .WithMany(b => b.ProductCategories)
             .HasForeignKey(bc => bc.ProductId);

        builder.HasOne(bc => bc.Category)
             .WithMany(c => c.ProductCategories)
             .HasForeignKey(bc => bc.CategoryId);
    }
}