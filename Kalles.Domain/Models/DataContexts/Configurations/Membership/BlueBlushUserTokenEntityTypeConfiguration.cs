
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Kalles.Domain.Models.Entities.Membership;

namespace Kalles.Domain.Models.DataContexts.Configurations
{
    public class KallesUserTokenEntityTypeConfiguration : IEntityTypeConfiguration<KallesUserToken>
    {
        public void Configure(EntityTypeBuilder<KallesUserToken> builder)
        {
            builder.ToTable("UserTokens", "Membership");
        }
    }
}
