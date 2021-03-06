using FluentValidation;
using Backend.Models;
using Microsoft.AspNetCore.Http;

namespace Backend.Controllers.DTO
{

    public class UpdateProductDTO
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public ProductStatus Status { get; set; }
        public string Description { get; set; }
        public float OriginalPrice { get; set; }
        public float RetailPrice { get; set; }
        public int Quantity { get; set; }
        public IFormFile File { get; set; }
        public string CategoryId { get; set; }
    }
    public class UpdateProductDTOValidator : AbstractValidator<UpdateProductDTO>
    {
        public UpdateProductDTOValidator()
        {
            RuleFor(x => x.ProductId).NotEmpty();
            RuleFor(x => x.Name).NotEmpty().NotNull().Length(3, 50);
            RuleFor(x => x.Status).IsInEnum().NotNull();
            RuleFor(x => x.Description).NotEmpty().Length(3, 500);
            RuleFor(x => x.OriginalPrice).NotEmpty().NotEmpty().InclusiveBetween(0, 1000000);
            RuleFor(x => x.RetailPrice).NotEmpty().InclusiveBetween(0, 1000000);
            RuleFor(x => x.Quantity).NotEmpty().InclusiveBetween(0, 10000);
            RuleFor(x => x.CategoryId).NotEmpty();
        }
    }

}