using Kalles.Application.Infrastructure;
using System.Collections.Generic;

namespace Kalles.Domain.Models.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
