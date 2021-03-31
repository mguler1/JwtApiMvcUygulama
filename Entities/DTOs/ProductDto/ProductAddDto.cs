using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.ProductDto
{
   public class ProductAddDto:IDTO
    {
        public string Name { get; set; }
    }
}
