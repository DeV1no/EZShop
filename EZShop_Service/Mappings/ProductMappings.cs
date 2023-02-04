using AutoMapper;
using EZShop_DataAccess;
using EZShop_Service.DataTransferObjects.Product;

namespace EZShop_Service.Mappings;

public class ProductMappings : Profile
{
    public ProductMappings()
    {
        // ProductMappings
        CreateMap<Product, ProductSaveDto>()
            .ForMember(x => x.Products, options => options.MapFrom(MapProductCategory));
            ;
        CreateMap<ProductSaveDto, Product>()
            .ForMember(x => x.Id, opt => opt.Ignore())
            .ForMember(x => x.ProductCategories, options => options.MapFrom(MapProductCategory));
        CreateMap<ProductCategoriesSaveDto, ProductCategory>()
            .ForMember(x => x.CategoryId, opt => opt.MapFrom(q => q.Id));
    }

     private static List<ProductCategory> MapProductCategory(ProductSaveDto productSaveDto, Product product)
     {
         return productSaveDto.Products
             .Select(category => new ProductCategory { CategoryId = category.Id })
             .ToList();
     }



     private static List<ProductCategoriesSaveDto> MapProductCategory(Product product, ProductSaveDto productSaveDto)
     {
         return product.ProductCategories.Select(actor 
             => new ProductCategoriesSaveDto 
                 { Id = actor.ProductId, Name = actor.Product?.Name })
             .ToList();
     }
}