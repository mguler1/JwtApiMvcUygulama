using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
   public interface IJwtService
    {
          string GenerateJwt(AppUser appUser, List<AppRole> roles);
        object GenerateJwt(Task<AppUser> appUser, object p);
    }
}
