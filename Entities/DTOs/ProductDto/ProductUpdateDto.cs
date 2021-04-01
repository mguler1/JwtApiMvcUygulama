using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.ProductDto
{
  public  class ProductUpdateDto:IDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
