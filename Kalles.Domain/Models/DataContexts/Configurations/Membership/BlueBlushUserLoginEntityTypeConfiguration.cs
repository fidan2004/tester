
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Kalles.Domain.Models.Entities.Membership;

namespace Kalles.Domain.Models.DataContexts.Configurations
{
    public class KallesUserLoginEntityTypeConfiguration : IEntityTypeConfiguration<KallesUserLogin>
    {
        public void Configure(EntityTypeBuilder<KallesUserLogin> builder)
        {
            builder.ToTable("UserLogins", "Membership");
        }
    }
}
