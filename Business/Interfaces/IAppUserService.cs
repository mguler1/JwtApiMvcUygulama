using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
   public interface IAppUserService:IGenericService<AppUser>
    {
        Task<AppUser> FindByUserName(string userName);
        Task<bool> Checkpassword(string userName, string password);
       
    }
}
