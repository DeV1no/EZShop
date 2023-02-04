using EZShop_DataAccess;
using EZShop_Repository.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace EZShop_Repository.Repositories;

public class ProductRepository :GenericRepository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context)
        : base(context)
    {
      
    }

    

    public override async Task<List<Product>> All()
     => await _dbSet.ToListAsync();

    public override async Task<Product?> GetById(int id)
    {
      return  await _dbSet.Include(q=>q.ProductCategories)
                  .FirstOrDefaultAsync(x => x.Id == id) 
              ?? throw new NotFoundException();
    }
}

public class NotFoundException : Exception
{
}