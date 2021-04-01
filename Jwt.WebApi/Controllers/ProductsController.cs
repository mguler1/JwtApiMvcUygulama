using AutoMapper;
using Business.Interfaces;
using Entities.Concrete;
using Entities.DTOs.ProductDto;
using Jwt.WebApi.CustomFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jwt.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
       private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAll();
            return Ok(products);
        }
        [HttpGet("{id}")]
        [ServiceFilter(typeof(ValidId<Products>))]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetById(id);
            return Ok(product);
        }
        [HttpPost]
        [ValidModel]
        public async Task<IActionResult> Add(ProductAddDto productAddDto)
        {
            await _productService.Add(_mapper.Map<Products>(productAddDto));
            return Created("", productAddDto);
        }
        [HttpPut]
        [ServiceFilter(typeof(ValidId<Products>))]
        public async Task<IActionResult> Update(ProductUpdateDto productUpdateDto)
        {
            await _productService.Update(_mapper.Map<Products>(productUpdateDto));
            return NoContent();
        }
        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidId<Products>))]
        public async Task<IActionResult> Delete(int id)
        {
            await _productService.Remove(new Products { Id = id });
            return NoContent();
        }
    }
}