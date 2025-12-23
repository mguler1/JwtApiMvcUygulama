using Entities.Concrete;
using Entities.DTOs.AppUserDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
   public interface IAppUserService:IGenericService<AppUser>
    {
        Task<AppUser> FindByUserName(string userName);
        Task<bool> Checkpassword(AppUserLoginDto appUserLoginDto);
       
    }
}
