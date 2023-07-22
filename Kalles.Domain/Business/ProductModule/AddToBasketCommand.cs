using Kalles.Application.Infrastructure;
using Kalles.Domain.AppCode.Extensions;
using Kalles.Domain.Models.DataContexts;
using Kalles.Domain.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kalles.Domain.Business.ProductModule
{
    public class AddToBasketCommand : IRequest<JsonResponse>
    {
        public int ProductId { get; set; }

        public class AddToBasketComandHandler : IRequestHandler<AddToBasketCommand, JsonResponse>
        {
            private readonly KallesDbContext db;
            private readonly IActionContextAccessor ctx;
            public AddToBasketComandHandler(KallesDbContext db, IActionContextAccessor ctx)
            {
                this.db = db;
                this.ctx = ctx;
            }
            public async Task<JsonResponse> Handle(AddToBasketCommand request, CancellationToken cancellationToken)
            {
                var userId = ctx.GetCurrentUserId();
                var alreadyExists = await db.Basket.AnyAsync(b => b.ProductId == request.ProductId && b.UserId == userId, cancellationToken);

                if (alreadyExists)
                {
                    return new JsonResponse
                    {
                        Error = true,
                        Message = "Sebette Movcuddur!!!"
                    };
                    

                }

                var basketItem = new Basket
                {
                    UserId = userId,
                    ProductId = request.ProductId,
                    Quantity = 1
                };
                await db.Basket.AddAsync(basketItem, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);


                var value = ctx.GetIntArrayFromCookie("favorites");

                if(value != null)
                {
                    ctx.SetValueToCookie("favorites", string.Join(",", value.Where(e => e != request.ProductId)));
                }

                return new JsonResponse
                {
                    Error = false,
                    Message = "Sebette Elave edilib!!!"
                };
            }
        }
    }
}
