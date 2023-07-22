
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Kalles.Domain.Models.Entities.Membership;

namespace Kalles.Domain.Models.DataContexts.Configurations
{
    public class KallesRoleClaimEntityTypeConfiguration : IEntityTypeConfiguration<KallesRoleClaim>
    {
        public void Configure(EntityTypeBuilder<KallesRoleClaim> builder)
        {
            builder.ToTable("RolesClaims", "Membership");
        }
    }
}
