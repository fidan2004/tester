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
    public class ProductRemoveCommand : IRequest<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public class ProductRemoveCommandHandler : IRequestHandler<ProductRemoveCommand, Product>
        {
            private readonly KallesDbContext db;

            public ProductRemoveCommandHandler(KallesDbContext db)
            {
                this.db = db;
            }
            public async Task<Product> Handle(ProductRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = await db.Products
                    .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                if (data == null)
                {
                    return null;
                }

                data.DeletedDate = DateTime.UtcNow.AddHours(4);
                await db.SaveChangesAsync(cancellationToken);


                return data;
            }
        }
    }
}
