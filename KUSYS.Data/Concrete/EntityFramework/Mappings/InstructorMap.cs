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
    public class InstructorMap : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.StartDate).IsRequired();
            builder.Property(a => a.PersonId).IsRequired();

            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();

            builder.HasOne<Person>(x => x.Person).WithMany(x => x.Instructors).HasForeignKey(x => x.PersonId);
            builder.HasOne<Department>(x => x.Department).WithMany(x => x.Instructors).HasForeignKey(x => x.DepartmentId);

            builder.ToTable("Departments");
        }
    }
}
