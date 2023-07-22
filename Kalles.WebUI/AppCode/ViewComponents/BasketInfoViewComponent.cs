﻿using Kalles.Domain.Business.ProductModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Kalles.WebUI.AppCode.ViewComponents
{
    public class BasketInfoViewComponent : ViewComponent
    {
        private readonly IMediator mediator;
        public BasketInfoViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var query = new ProductBasketQuery();
            var response = await mediator.Send(query);
            return View(response);
        }
    }
}
