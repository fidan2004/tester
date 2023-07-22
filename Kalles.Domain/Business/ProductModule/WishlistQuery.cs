using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Kalles.Application.Infrastructure;
using Kalles.Domain.Models.DataContexts;
using Kalles.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Kalles.Domain.Business.ProductModule
{
    public class WishlistQuery : PaginateModel, IRequest<IEnumerable<Product>>
    {
        public class WishlistQueryHandler : IRequestHandler<WishlistQuery, IEnumerable<Product>>
        {
            private readonly KallesDbContext db;
            private readonly IActionContextAccessor ctx;

            public WishlistQueryHandler(KallesDbContext db,IActionContextAccessor ctx)
            {
                this.db = db;
                this.ctx = ctx;
            }

            public async Task<IEnumerable<Product>> Handle(WishlistQuery request, CancellationToken cancellationToken)
            {
                //if (request.PageSize < 5)
                //{
                //    request.PageSize = 5;
                //}
                var favorites = ctx.ActionContext.HttpContext.Request.Cookies["favorites"]?
                .Split(",", System.StringSplitOptions.RemoveEmptyEntries)
                .Where(x => Regex.IsMatch(x, @"\d+"))
                .Select(x => int.Parse(x))
                .ToArray();

                if (favorites == null || favorites.Length == 0)
                {
                    return Enumerable.Empty<Product>();
                }


                var favs = await db.Products
                    .Include(p => p.Images.Where(i => i.DeletedUserId == null))
                    .Where(p => favorites.Contains(p.Id) && p.DeletedUserId == null)
                    .ToListAsync(cancellationToken);

                return favs;
            }
        }
    }
}
