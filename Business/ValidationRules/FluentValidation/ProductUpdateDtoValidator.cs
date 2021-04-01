using Entities.DTOs.ProductDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class ProductUpdateDtoValidator:AbstractValidator<ProductUpdateDto>
    {
        public ProductUpdateDtoValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(0, int.MaxValue);
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün Adı Boş Geçilemez");
        }
    }
}
