using Kalles.Domain.Models.DataContexts;
using Kalles.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kalles.Domain.Business.CategoryModule
{
    public class CategoryAllQuery :IRequest<List<Category>>
    {
        public class CategoryAllQueryHandler : IRequestHandler<CategoryAllQuery, List<Category>>
        {
            private readonly KallesDbContext db;

            public CategoryAllQueryHandler(KallesDbContext db)
            {
                this.db = db;
            }
            public async Task<List<Category>> Handle(CategoryAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Categories
                    .Include(c=> c.Parent)
                    .Where(m => m.DeletedDate == null)
                    .ToListAsync(cancellationToken);
                return data;
            }
        }
    }
}
