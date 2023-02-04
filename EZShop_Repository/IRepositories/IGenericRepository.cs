using EZShop_DataAccess;

namespace EZShop_Repository.IRepositories;

public interface IGenericRepository<T> where T : class
{
    Task<List<T>> All();
    Task<T?> GetById(int id);
    Task<T> Add(T entity);
    Task<bool> Delete(int id);
    Task<bool> Upsert(T entity);
}