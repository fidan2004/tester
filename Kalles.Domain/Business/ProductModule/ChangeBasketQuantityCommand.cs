﻿using Kalles.Application.Infrastructure;
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
    public class ChangeBasketQuantityCommand : IRequest<JsonResponse>
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }


        public class AddToBasketComandHandler : IRequestHandler<ChangeBasketQuantityCommand, JsonResponse>
        {
            private readonly KallesDbContext db;
            private readonly IActionContextAccessor ctx;
            public AddToBasketComandHandler(KallesDbContext db, IActionContextAccessor ctx)
            {
                this.db = db;
                this.ctx = ctx;
            }
            public async Task<JsonResponse> Handle(ChangeBasketQuantityCommand request, CancellationToken cancellationToken)
            {
                var userId = ctx.GetCurrentUserId();

                var basketItem = await db.Basket.FirstOrDefaultAsync(b => b.ProductId == request.ProductId
                                            && b.UserId == userId, cancellationToken);

                if (basketItem == null)
                {
                    basketItem = new Basket();
                    basketItem.UserId = userId;
                    basketItem.ProductId = request.ProductId;
                    basketItem.Quantity = request.Quantity;


                    await db.Basket.AddAsync(basketItem,cancellationToken);
                    await db.SaveChangesAsync(cancellationToken);


                    var response = new JsonResponse
                    {
                        Error = false,
                        Message = "Sebete Elave edildi!!"
                    };

                    var product = await db.Products.FirstOrDefaultAsync(b => b.Id == request.ProductId
                                            && b.DeletedUserId == null, cancellationToken);


                    
                    response.Value = new
                    {
                        Name = product.Name,
                        Price = product.Price,
                        Total = basketItem.Quantity * product.Price,
                        Summary = await db.Basket.Include(b => b.Product).SumAsync(b => b.Quantity * b.Product.Price, cancellationToken)

                };

                    return response;
                }

                basketItem.Quantity = request.Quantity;
                await db.SaveChangesAsync(cancellationToken);

                var response2 = new JsonResponse
                {
                    Error = false,
                    Message = "Say Deyisdi!"
                };

                var product2 = await db.Products.FirstOrDefaultAsync(b => b.Id == request.ProductId
                                           && b.DeletedUserId == null, cancellationToken);

                response2.Value = new
                {
                    Name = product2.Name,
                    Price = product2.Price,
                    Total = basketItem.Quantity * product2.Price,
                    Summary = await db.Basket.Include(b => b.Product).SumAsync(b => b.Quantity * b.Product.Price, cancellationToken)

                };



                

                return response2;
            }
        }
    }
}
