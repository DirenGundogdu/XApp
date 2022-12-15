using Core.DTOs;
using Core.Models;

namespace Core.Services;

public interface IProductService : IService<Product>
{
    Task<List<ProductWithCategoryDto>> GetProductsWithCategory();



}
