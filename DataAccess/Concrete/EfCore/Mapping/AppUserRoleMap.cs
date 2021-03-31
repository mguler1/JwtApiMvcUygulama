﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EfCore.Mapping
{
    public class AppUserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasIndex(x => new { x.AppUserId, x.AppRoleId }).IsUnique();
        }
    }
}
