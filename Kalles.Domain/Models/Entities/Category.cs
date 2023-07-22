using Kalles.Application.Infrastructure;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kalles.Domain.Models.Entities
{
    public class Category : BaseEntity
    {
        public int? ParentId { get; set; }
        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> Children { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public string ParentName 
        {
            get
            {
                return this.Parent?.Name;
            }
                


         }
        
    }
}
