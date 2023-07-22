using MediatR;
using Microsoft.EntityFrameworkCore;
using Kalles.Domain.Models.DataContexts;
using Kalles.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kalles.Domain.Business.ProductModule
{
    public class ProductReleatedQuery : IRequest<Product>
    {
        public int Id { get; set; }

        public class ProductReleatedQueryHandler : IRequestHandler<ProductReleatedQuery, Product>
        {
            private readonly KallesDbContext db;

            public ProductReleatedQueryHandler(KallesDbContext db)
            {
                this.db = db;
            }
            public async Task<Product> Handle(ProductReleatedQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Products
                    .Include(p => p.Images.Where(i => i.DeletedUserId == null))
                    .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                return data;
            }
        }
    }
}
