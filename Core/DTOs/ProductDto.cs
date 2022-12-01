using System.ComponentModel.DataAnnotations;

namespace Core.DTOs;

public class ProductDto : BaseDto
{
    //[Required(ErrorMessage =)]
    public string? Name { get; set; }
    //[Range(1,100,ErrorMessage =)]
    public int Stock { get; set; }

    public decimal Price { get; set; }

    public int CategoryId { get; set; }
}
