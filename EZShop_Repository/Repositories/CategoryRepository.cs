using EZShop_DataAccess;
using EZShop_Repository.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace EZShop_Repository.Repositories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
  

    public CategoryRepository(ApplicationDbContext context)
        : base(context)
    {
      
    }

    public override async Task<IEnumerable<Category?>> All()
        => await _dbSet.ToListAsync();

  

    /*public override async Task<bool> Upsert(Category entity)
    {
        //   await _dbSet.Update()

        return true
    }*/
}