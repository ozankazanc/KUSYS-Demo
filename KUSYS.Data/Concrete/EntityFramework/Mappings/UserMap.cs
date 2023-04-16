using KUSYS.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace KUSYS.Data.Concrete.EntityFramework.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.NormalizedUserName).HasDatabaseName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasDatabaseName("EmailIndex");

            builder.ToTable("AspNetUsers");
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            builder.Property(u => u.UserName).HasMaxLength(50);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(11);
            builder.Property(u => u.Email).HasMaxLength(100);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(100);

            builder.HasMany<UserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();
            builder.HasMany<UserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();
            builder.HasMany<UserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();
            builder.HasMany<UserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();

            var beginningUsers = new List<User>
            {
                new User
                {
                    Id = 1,
                    UserName = "adminuser",
                    NormalizedUserName = "ADMINUSER",
                    Email = "adminuser@gmail.com",
                    NormalizedEmail = "ADMINUSER@GMAIL.COM",
                    PhoneNumber = "+905555555555",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString()
                }, //admin
                new User
                {
                    Id = 2,
                    UserName = "studentuser",
                    NormalizedUserName = "STUDENTUSER",
                    Email = "studentuser@gmail.com",
                    NormalizedEmail = "STUDENTUSER@GMAIL.COM",
                    PhoneNumber = "+905555555556",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString()

                }, //student
                new User
                {
                    Id = 3,
                    UserName = "studentuser2",
                    NormalizedUserName = "STUDENTUSER2",
                    Email = "studentuser2@gmail.com",
                    NormalizedEmail = "STUDENTUSER2@GMAIL.COM",
                    PhoneNumber = "+905555555557",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString()

                }, //student2
                new User
                {
                    Id = 4,
                    UserName = "teacheruser",
                    NormalizedUserName = "TEACHERUSER",
                    Email = "teacheruser@gmail.com",
                    NormalizedEmail = "TEACHERUSER@GMAIL.COM",
                    PhoneNumber = "+905555555558",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString()

                }  //teacher
            };
            
            //all users passwords are same = "KusysUser"
            foreach (var user in beginningUsers)
                user.PasswordHash = CreatePasswordHash(user, "KusysUser");
            
            builder.HasData(beginningUsers);
        }
        private string CreatePasswordHash(User user, string password)
        {
            var passwordHasher = new PasswordHasher<User>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
