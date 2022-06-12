using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EZShop_DataAccess;

public class ProductConfiguration
{
    public ProductConfiguration(EntityTypeBuilder<Product> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
        builder.Property(x => x.Description).HasMaxLength(1500).IsRequired();
    }
}