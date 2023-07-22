using Kalles.Domain.Models.DataContexts;
using Kalles.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Kalles.Domain.Business.CategoryModule
{
    public class CategoryEditCommand : IRequest<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int? ParentId { get; set; }

        public class CategoryEditCommandHandler : IRequestHandler<CategoryEditCommand, Category>
        {
            private readonly KallesDbContext db;

            public CategoryEditCommandHandler(KallesDbContext db)
            {
                this.db = db;
            }

            public async Task<Category> Handle(CategoryEditCommand request, CancellationToken cancellationToken)
            {
                var category = await db.Categories.FirstOrDefaultAsync(c=>c.Id == request.Id && c.DeletedDate == null,cancellationToken);

                if(category == null)
                {
                    return null;
                }
                category.Name = request.Name;
                category.ParentId = request.ParentId;
                
                await db.SaveChangesAsync(cancellationToken);

                return category;
            }
        }
    }
}