namespace EZShop_Service.DataTransferObjects.Category;

public record CategorySaveDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int? ParentCategoryId { get; set; }
    public string? ParentName { get; set; }
}