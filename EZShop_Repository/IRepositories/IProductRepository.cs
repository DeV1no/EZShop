using EZShop_DataAccess;

namespace EZShop_Repository.IRepositories;

public interface IProductRepository : IGenericRepository<Product>
{
    public new Task<Product?> GetById(int id);
}