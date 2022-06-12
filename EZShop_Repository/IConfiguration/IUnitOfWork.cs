using EZShop_Repository.IRepositories;

namespace EZShop_Repository.IConfiguration;

public interface IUnitOfWork
{
    ICategoryRepository CategoryRepository { get; }

    Task CompleteAsync();
}