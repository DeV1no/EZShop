using EZShop_DataAccess;
using Gridify;

namespace EZShop_Repository.IRepositories;

public interface IGenericRepository<T> where T : class
{
    Task<List<T>> All();
    Task<Paging<T>> GetList(GridifyQuery query);
    Task<T?> GetById(int id);
    Task<T> Add(T entity);
    Task<bool> Delete(int id);
    Task<bool> Upsert(T entity);

}