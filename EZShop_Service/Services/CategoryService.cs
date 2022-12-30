using AutoMapper;
using EZShop_DataAccess;
using EZShop_Repository.IConfiguration;
using EZShop_Service.DataTransferObjects.Category;
using EZShop_Service.IContracts;

namespace EZShop_Service.Services;

public class CategoryService : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CategorySaveDto> GetCategoryById(int id)
    {
        var category = await _unitOfWork.CategoryRepository.GetById(id);
        return _mapper.Map<CategorySaveDto>(category);
    }

    public async Task<int> AddCategory(CategorySaveDto model)
    {
        var category = _mapper.Map<Category>(model);
        await _unitOfWork.CategoryRepository.Add(category);
        await _unitOfWork.CompleteAsync();
        return category.Id;
    }

    public async Task<bool> UpdateCategory(CategorySaveDto model)
    {
        var category = await _unitOfWork.CategoryRepository.GetById(model.Id);
        category = _mapper.Map<Category>(category);
        return await _unitOfWork.CategoryRepository.Upsert(category);
    }

    public async Task<bool> DeleteCategory(int id)
        => await _unitOfWork.CategoryRepository.Delete(id);

}