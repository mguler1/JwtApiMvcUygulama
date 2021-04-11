using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.AppUserDto
{
   public  class AppUserLoginDto:IDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
