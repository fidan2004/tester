using Kalles.Application.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace Kalles.Domain.Models.Entities
{
    public class Faq : BaseEntity
    {
        [Required]
        public string Question { get; set; }
        [Required]
        public string Answer { get; set; }
    }
}
