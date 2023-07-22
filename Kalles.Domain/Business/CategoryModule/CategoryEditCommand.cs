using Kalles.Domain.Models.DataContexts;
using Kalles.Domain.Models.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Kalles.Domain.Business.CategoryModule
{
    public class CategoryCreateCommand : IRequest<Category>
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }

        public class CategoryCreateCommandHandler : IRequestHandler<CategoryCreateCommand, Category>
        {
            private readonly KallesDbContext db;

            public CategoryCreateCommandHandler(KallesDbContext db)
            {
                this.db = db;
            }

            public async Task<Category> Handle(CategoryCreateCommand request, CancellationToken cancellationToken)
            {
                var category = new Category()
                {
                    Name = request.Name,
                    ParentId = request.ParentId,
                };

                await db.Categories.AddAsync(category, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return category;
            }
        }
    }
}