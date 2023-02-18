using EZShop_Service.DataTransferObjects.Product;
using EZShop_Service.IContracts;
using Gridify;
using Microsoft.AspNetCore.Mvc;

namespace EZShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] GridifyQuery query)
            => Ok(await _productService.GetList(query));


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetProduct(int id)
            => Ok(await _productService.GetProductById(id));

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] ProductSaveDto model)
            => Ok(await _productService.AddProduct(model));

        [HttpPut]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductSaveDto model)
            => Ok(await _productService.UpdateProduct(model));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
            => Ok(await _productService.DeleteProduct(id));

    }
}
