
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Kalles.Domain.Models.Entities.Membership;

namespace Kalles.Domain.Models.DataContexts.Configurations
{
    public class KallesRoleEntityTypeConfiguration : IEntityTypeConfiguration<KallesRole>
    {
        public void Configure(EntityTypeBuilder<KallesRole> builder)
        {
            builder.ToTable("Roles", "Membership");
        }
    }
}
