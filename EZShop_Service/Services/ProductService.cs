using AutoMapper;
using EZShop_DataAccess;
using EZShop_Repository.IConfiguration;
using EZShop_Service.DataTransferObjects.Category;
using EZShop_Service.DataTransferObjects.Product;
using EZShop_Service.IContracts;

namespace EZShop_Service.Services;

public class ProductService:IProductService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public async Task<ProductSaveDto> GetProductById(int id)
    {
        var product = await _unitOfWork.ProductRepository.GetById(id);
        return _mapper.Map<ProductSaveDto>(product);
    }

    public async Task<int> AddProduct(ProductSaveDto model)
    {
        var product = _mapper.Map<Product>(model);
        await _unitOfWork.ProductRepository.Add(product);
        await _unitOfWork.CompleteAsync();
        return product.Id;
    }

    public async Task<bool> UpdateProduct(ProductSaveDto model)
    {
        var product = await _unitOfWork.ProductRepository.GetById(model.Id);
        product = _mapper.Map<Product>(product);
        return await _unitOfWork.ProductRepository.Upsert(product);
    }

    public async Task<bool> DeleteProduct(int id)
        => await _unitOfWork.ProductRepository.Delete(id);
}