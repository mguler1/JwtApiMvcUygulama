using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Concrete;
using Entities.DTOs.AppUserDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   public class AppUserManager :GenericManager<AppUser>,IAppUserService
    {
        private readonly IAppUserDal _appUserDal;
        public AppUserManager(IGenericDal<AppUser> genericDal, IAppUserDal appUserDal) :base(genericDal)
        {
            _appUserDal = appUserDal;
        }

        public async Task<bool> Checkpassword(AppUserLoginDto appUserLoginDto)
        {
          var appUser =await  _appUserDal.GetByFilter(x => x.UserName == appUserLoginDto.UserName);
            return appUser.Password == appUserLoginDto.Password ? true : false;
          
        }

        public async Task<AppUser> FindByUserName(string userName)
        {
            return await _appUserDal.GetByFilter(x => x.UserName == userName);
        }
    }
}
