using MediatR;
using Microsoft.EntityFrameworkCore;
using Kalles.Application.Infrastructure;
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
    public class ProductsPagedQuery : PaginateModel, IRequest<PagedViewModel<Product>>
    {
        public class ProductsPagedQueryHandler : IRequestHandler<ProductsPagedQuery, PagedViewModel<Product>>
        {
            private readonly KallesDbContext db;

            public ProductsPagedQueryHandler(KallesDbContext db)
            {
                this.db = db;
            }

            public async Task<PagedViewModel<Product>> Handle(ProductsPagedQuery request, CancellationToken cancellationToken)
            {
                //if (request.PageSize < 5)
                //{
                //    request.PageSize = 5;
                //}
                var query = db.Products
                    .Include(p => p.Images)
                    .Include(p => p.Brand)
                    .Include(p => p.Category)
                    .Where(m => m.DeletedDate == null)
                    .OrderByDescending(p => p.Id)
                    .AsQueryable();

                var pagedDate = new PagedViewModel<Product>(query, request);

                return pagedDate;
            }
        }
    }
}
