using Business.Interfaces;
using Entities.DTOs.AppUserDto;
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

    public class AuthController : ControllerBase
    {
        private readonly IJwtService _jwtService;
        public AuthController(IJwtService jwtService)
        {
            _jwtService = jwtService;
        }
        [HttpGet("[action]")]
        [ValidModel]
        public IActionResult SignIn(AppUserLoginDto appUserLoginDto)
        {
            return Created("", "");
        }
    }
}
