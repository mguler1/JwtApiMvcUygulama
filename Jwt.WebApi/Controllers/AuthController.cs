using Business.Interfaces;
using Entities.DTOs.AppUserDto;
using Jwt.WebApi.CustomFilters;
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

namespace Jwt.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class AuthController : ControllerBase
    {
        private readonly IJwtService _jwtService;
        private readonly IAppUserService _appUserService;
        public AuthController(IJwtService jwtService, IAppUserService appUserService)
        {
            _appUserService = appUserService;
            _jwtService = jwtService;
        }
        [HttpGet("[action]")]
        [ValidModel]
        public async Task<IActionResult> SignIn(AppUserLoginDto appUserLoginDto)
        {
            var appUser = _appUserService.FindByUserName(appUserLoginDto.UserName);
            if (appUser == null)
            {
              return   BadRequest("Kullanıcı Adı beya Şifre Hatalıdır");
            }
            else
            {
                if (await _appUserService.Checkpassword(appUserLoginDto))
                {
                    var token = _jwtService.GenerateJwt(appUser, null);
                    return Created("", token);
                }
                return BadRequest("Kullanıcı Adı beya Şifre Hatalıdır");
            }

        }
    }
}
