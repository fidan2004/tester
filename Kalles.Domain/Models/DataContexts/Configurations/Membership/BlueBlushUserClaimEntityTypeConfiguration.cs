
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Kalles.Domain.Models.Entities.Membership;

namespace Kalles.Domain.Models.DataContexts.Configurations
{
    public class KallesUserClaimEntityTypeConfiguration : IEntityTypeConfiguration<KallesUserClaim>
    {
        public void Configure(EntityTypeBuilder<KallesUserClaim> builder)
        {
            builder.ToTable("UserClaims", "Membership");
        }
    }
}
