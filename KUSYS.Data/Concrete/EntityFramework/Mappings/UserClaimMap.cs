using KUSYS.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KUSYS.Data.Concrete.EntityFramework.Mappings
{
    class UserClaimMap : IEntityTypeConfiguration<UserClaim>
    {
        public void Configure(EntityTypeBuilder<UserClaim> builder)
        {
            builder.HasKey(uc => uc.Id);
            builder.ToTable("AspNetUserClaims");
        }
    }
}
