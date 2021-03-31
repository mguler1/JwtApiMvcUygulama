using Entities.DTOs.ProductDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class ProductAddDtoValidator:AbstractValidator<ProductAddDto>
    {
        public ProductAddDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün Adı Boş Geçilemez");
        }
    }
}
