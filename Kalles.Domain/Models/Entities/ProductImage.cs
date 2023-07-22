﻿using Kalles.Application.Infrastructure;

namespace Kalles.Domain.Models.Entities
{
    public class ProductImage : BaseEntity
    {
        public string Name { get; set; }
        public bool IsMain { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
