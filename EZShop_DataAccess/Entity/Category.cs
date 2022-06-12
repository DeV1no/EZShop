namespace EZShop_DataAccess;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    //Relations
    public virtual Category? ParentCategory { get; set; }
    public int? ParentCategoryId { get; set; }
    public ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
}