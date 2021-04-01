using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.ProductDto;

namespace Jwt.WebApi.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<ProductAddDto, Products>();
            CreateMap<Products, ProductAddDto>();

            CreateMap<ProductUpdateDto, Products>();
            CreateMap<Products, ProductUpdateDto>();
        }
    }
}
