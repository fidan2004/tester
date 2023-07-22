using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Kalles.Domain.Models.Entities.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalles.Domain.Models.DataContexts.Configurations
{
    public class KallesUserEntityTypeConfiguration : IEntityTypeConfiguration<KallesUser>
    {
        public void Configure(EntityTypeBuilder<KallesUser> builder)
        {
            builder.ToTable("Users","Membership");
        }
    }
}
