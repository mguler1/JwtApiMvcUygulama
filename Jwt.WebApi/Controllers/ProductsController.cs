﻿using Business.Interfaces;
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
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
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
            await _productService.Add(new Products { Name = productAddDto.Name });
            return Created("", productAddDto);
        }
        [HttpPut]
        [ServiceFilter(typeof(ValidId<Products>))]
        public async Task<IActionResult> Update(Products product)
        {
            await _productService.Update(product);
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