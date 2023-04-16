using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KUSYS.Entities.Concrete;
using System.Collections.Generic;

namespace KUSYS.Data.Concrete.EntityFramework.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(r => new { r.UserId, r.RoleId });

            builder.ToTable("AspNetUserRoles");

            var userRoleMaps = new List<UserRole>
            {
                new UserRole
                {
                    RoleId = 1,
                    UserId = 1,

                },
                new UserRole
                {
                    RoleId = 2,
                    UserId = 1
                },
                new UserRole
                {
                    RoleId = 3,
                    UserId = 1
                },
                new UserRole
                {
                    RoleId = 4,
                    UserId = 1
                },
                new UserRole
                {
                    RoleId = 2,
                    UserId = 2,

                },
                new UserRole
                {
                    RoleId = 3,
                    UserId = 2
                },
                new UserRole
                {
                    RoleId = 4,
                    UserId = 2
                },
                new UserRole
                {
                    RoleId = 4,
                    UserId = 4
                }
            };

            builder.HasData(userRoleMaps);
        }
    }
}

