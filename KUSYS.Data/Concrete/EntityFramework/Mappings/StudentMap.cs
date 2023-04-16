using KUSYS.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS.Data.Concrete.EntityFramework.Mappings
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.StartDate).IsRequired();
            builder.Property(a => a.AcademicLevel).IsRequired();
            builder.Property(a => a.PersonId).IsRequired();
            builder.Property(a => a.DepartmentId).IsRequired();

            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();

            builder.HasOne<Person>(x => x.Person).WithMany(x => x.Students).HasForeignKey(x => x.PersonId);
            builder.HasOne<Department>(x => x.Department).WithMany(x => x.Students).HasForeignKey(x => x.DepartmentId);

            builder.ToTable("Persons");
        }
    }
}
