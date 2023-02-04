using EZShop_Service.DataTransferObjects.Product;

namespace EZShop_Service.IContracts;

public interface IProductService
{
    public Task<ProductSaveDto> GetProductById(int id);
    public Task<int> AddProduct(ProductSaveDto model);
    public Task<bool> UpdateProduct(ProductSaveDto model);
    public Task<bool> DeleteProduct(int id);
}