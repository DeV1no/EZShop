using System.ComponentModel.DataAnnotations;

namespace EZShop_DataAccess;

public class ProductCategory
{
    [Key] public int CategoryId { get; set; }
    public virtual Category? Category { get; set; }
     public int ProductId { get; set; }
    public virtual Product? Product { get; set; }
}