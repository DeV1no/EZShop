using EZShop_Repository.IConfiguration;
using Microsoft.AspNetCore.Mvc;

namespace EZShop.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoryController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetItem(int id)
        => Ok(await _unitOfWork.CategoryRepository.GetById(id));
}