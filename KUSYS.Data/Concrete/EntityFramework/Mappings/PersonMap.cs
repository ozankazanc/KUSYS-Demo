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
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a=> a.Address).HasMaxLength(250);
            builder.Property(a => a.FirstName).HasMaxLength(50);
            builder.Property(a => a.LastName).HasMaxLength(50);

            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();

            builder.HasOne<User>(x => x.User).WithMany(x => x.Persons).HasForeignKey(x => x.Id);

            builder.ToTable("Persons");

        }
    }
}
