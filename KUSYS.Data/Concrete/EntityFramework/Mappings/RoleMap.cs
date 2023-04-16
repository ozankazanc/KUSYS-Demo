using KUSYS.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace KUSYS.Data.Concrete.EntityFramework.Mappings
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            
            builder.HasKey(r => r.Id);
            builder.HasIndex(r => r.NormalizedName).HasDatabaseName("RoleNameIndex").IsUnique();
            
            builder.ToTable("AspNetRoles");
            builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken(); 
            
            builder.Property(u => u.Name).HasMaxLength(100);
            builder.Property(u => u.NormalizedName).HasMaxLength(100);
            
            builder.HasMany<UserRoleMap>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();
            builder.HasMany<RoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

            var roles = new List<Role>
            {
               new Role
               {
                   Id = 1,
                   Name = "US-1",
                   NormalizedName = "US1",
                   ConcurrencyStamp = Guid.NewGuid().ToString()
               },
               new Role
               {
                   Id = 2,
                   Name = "US-2",
                   NormalizedName = "US2",
                   ConcurrencyStamp = Guid.NewGuid().ToString()
               },
               new Role
               {
                   Id = 2,
                   Name = "US-3",
                   NormalizedName = "US3",
                   ConcurrencyStamp = Guid.NewGuid().ToString()
               },
                new Role
               {
                   Id = 2,
                   Name = "US-4",
                   NormalizedName = "US4",
                   ConcurrencyStamp = Guid.NewGuid().ToString()
               }
            };

            builder.HasData(roles);

        }
    }
}
