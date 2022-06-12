using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EZShop_DataAccess;

public class CategoryConfiguration
{
    public CategoryConfiguration(EntityTypeBuilder<Category> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
        builder.Property(x => x.Description).HasMaxLength(1500).IsRequired();
        builder.HasOne(q => q.ParentCategory).WithMany()
            .HasForeignKey(z => z.ParentCategoryId);
    }
}