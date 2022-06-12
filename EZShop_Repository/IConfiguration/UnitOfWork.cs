using EZShop_Repository.IConfiguration;
using EZShop_Repository.IRepositories;
using EZShop_Repository.Repositories;

namespace EZShop_DataAccess;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApplicationDbContext _context;
    public ICategoryRepository CategoryRepository { get; private set; }

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        CategoryRepository = new CategoryRepository(_context);
    }

    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}