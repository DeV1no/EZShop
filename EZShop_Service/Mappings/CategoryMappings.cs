using AutoMapper;
using EZShop_DataAccess;
using EZShop_Service.DataTransferObjects.Category;

namespace EZShop_Service.Mappings;

public class CategoryMappings : Profile
{
    public CategoryMappings()
    {
        // CategoryMappings
        CreateMap<Category, CategorySaveDto>()
            .ForMember(x => x.ParentName, opt => opt.MapFrom(q => q.ParentCategory!.Name));
        CreateMap<CategorySaveDto, Category>()
            .ForMember(x => x.Id, opt => opt.Ignore());
        
    }
}