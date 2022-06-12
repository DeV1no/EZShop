using System.Globalization;
using EZShop_DataAccess;
using EZShop_Repository.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace EZShop_Repository.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private ApplicationDbContext _context;
    protected DbSet<T> _dbSet;

    public GenericRepository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public virtual async Task<IEnumerable<T?>> All()
        => await _dbSet.ToListAsync();

    public virtual async Task<T?> GetById(int id)
        => await _dbSet.FindAsync(id);

    public virtual async Task<T> Add(T entity)
    {
        await _dbSet.AddAsync(entity);
        return entity;
    }

    public virtual async Task<bool> Delete(int id)
    {
        var entity = await GetById(id);
        if (entity is null)
            throw new Exception($"{id} is not found");
        _dbSet.Remove(entity);
        return true;
    }

    public virtual Task<bool> Upsert(T entity)
    {
        _context.Update(entity);
        return Task.FromResult(true);
    }
}