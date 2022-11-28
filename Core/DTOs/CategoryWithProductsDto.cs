using Core.Models;

namespace Core.DTOs
{
    public class CategoryWithProductsDto : CategoryDto
    {
        public List<Product> Products { get; set; }
    }
}
