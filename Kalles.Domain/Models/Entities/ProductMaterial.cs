﻿using Kalles.Application.Infrastructure;
using System.Collections.Generic;

namespace Kalles.Domain.Models.Entities
{
    public class ProductMaterial : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<ProductCatalogItem> ProductCatalog { get; set; }

    }
}
