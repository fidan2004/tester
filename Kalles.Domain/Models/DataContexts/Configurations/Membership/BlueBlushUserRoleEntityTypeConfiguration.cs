
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Kalles.Domain.Models.Entities.Membership;

namespace Kalles.Domain.Models.DataContexts.Configurations
{
    public class KallesUserRoleEntityTypeConfiguration : IEntityTypeConfiguration<KallesUserRole>
    {
        public void Configure(EntityTypeBuilder<KallesUserRole> builder)
        {
            builder.ToTable("UserRoles", "Membership");
        }
    }
}
