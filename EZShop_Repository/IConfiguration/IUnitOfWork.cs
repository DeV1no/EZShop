using EZShop_Repository.IRepositories;
using EZShop_Repository.Repositories;

namespace EZShop_Repository.IConfiguration;

public interface IUnitOfWork
{
    ICategoryRepository CategoryRepository { get; }
    IProductRepository ProductRepository { get; }
    Task CompleteAsync();
}