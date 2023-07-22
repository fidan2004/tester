using Kalles.Domain.Models.DataContexts;
using Kalles.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BigOn.Domain.Business.BlogPostModule
{
    public class CategorySingleQuery : IRequest<Category>
    {
        public int Id { get; set; }
        


        public class CategorySingleQueryHandler : IRequestHandler<CategorySingleQuery, Category>
        {
            private readonly KallesDbContext db;

            public CategorySingleQueryHandler(KallesDbContext db)
            {
                this.db = db;
            }

            public async Task<Category> Handle(CategorySingleQuery request, CancellationToken cancellationToken)
            {
               var entity = await db.Categories
                   .FirstOrDefaultAsync(m=>m.Id == request.Id && m.DeletedDate == null , cancellationToken);
                return entity;
            }
        }
    }
}