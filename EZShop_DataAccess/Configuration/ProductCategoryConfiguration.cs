using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EZShop_DataAccess;

public class ProductCategoryConfiguration
{
    public ProductCategoryConfiguration(EntityTypeBuilder<ProductCategory> builder)
    {
        // builder.HasKey(x => new { x.CategoryId, x.ProductId });
        builder.HasKey(x => x.CategoryId);
        builder.HasOne(x => x.Category).WithMany(q => q.ProductCategories)
            .HasForeignKey(z => z.CategoryId);
        builder.HasOne(x => x.Product).WithMany(q => q.ProductCategories)
            .HasForeignKey(z => z.ProductId);
    }
}