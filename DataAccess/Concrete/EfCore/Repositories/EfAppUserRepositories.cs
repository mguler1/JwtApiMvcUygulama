﻿using DataAccess.Interfaces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EfCore.Repositories
{
   public class EfAppUserRepositories :EfGenericRepositories<AppUser>,IAppUserDal
    {
    }
}
