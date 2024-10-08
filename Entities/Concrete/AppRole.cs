﻿using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class AppRole : ITable
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public List<AppUserRole> AppUserRoles { get; set; }
    }
}
