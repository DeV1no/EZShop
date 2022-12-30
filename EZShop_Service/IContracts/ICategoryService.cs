using EZShop_Service.DataTransferObjects.Category;

namespace EZShop_Service.IContracts;

public interface ICategoryService
{
    public Task<CategorySaveDto> GetCategoryById(int id);
    public Task<int> AddCategory(CategorySaveDto model);
    public Task<bool> UpdateCategory(CategorySaveDto model);
    public Task<bool> DeleteCategory(int id);
}