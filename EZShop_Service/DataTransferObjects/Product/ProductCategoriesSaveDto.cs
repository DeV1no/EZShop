namespace EZShop_Service.DataTransferObjects.Product;

public record ProductCategoriesSaveDto
{
    public int Id { get; set; }
    public string? Name { get; set; } = string.Empty;
}