namespace EZShop_Service.DataTransferObjects.Product;

public record ProductSaveDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public List<ProductCategoriesSaveDto> Products { get; set; } = new List<ProductCategoriesSaveDto>();
}