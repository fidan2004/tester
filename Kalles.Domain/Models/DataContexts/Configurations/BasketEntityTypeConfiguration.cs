using Kalles.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalles.Domain.Models.DataContexts.Configurations
{
    internal class BasketEntityTypeConfiguration :IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {
            builder.HasKey(k => new { k.UserId, k.ProductId });

            builder.ToTable("Basket");
        }
    }
}
