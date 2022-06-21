using EZShop_Repository.IConfiguration;
using EZShop_Service.DataTransferObjects.Category;
using EZShop_Service.IContracts;
using Microsoft.AspNetCore.Mvc;


namespace EZShop.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCategory(int id)
        => Ok(await _categoryService.GetCategoryById(id));

    [HttpPost]
    public async Task<IActionResult> AddCategory([FromBody] CategorySaveDto model)
        => Ok(await _categoryService.AddCategory(model));

    [HttpPost]
    public async Task<IActionResult> UpdateCategory([FromBody] CategorySaveDto model)
        => Ok(await _categoryService.UpdateCategory(model));
}