using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Kalles.Application.Extensions;
using Kalles.Domain.Business.ProductModule;
using System.Threading.Tasks;
using Kalles.Domain.Business.BlogPostModule;
using Kalles.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Kalles.WebUI.Controllers
{
    public class ShopController : Controller
    {
        private readonly IMediator mediator;

        public ShopController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index(ProductsPagedQuery query)
        {
            var response = await mediator.Send(query);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_Products", response);
            }

            return View(response);
        }

        [AllowAnonymous]
        
        public async Task<IActionResult> Details(ProductSingleQuery query)
        {
            var product = await mediator.Send(query);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [AllowAnonymous]
        [Route("/wishlist")]
        public async Task<IActionResult> Wishlist(WishlistQuery query)
        {
            var favs = await mediator.Send(query);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_WishlistBody", favs);
            }

            return View(favs);
        }


        [Route("/basket")]
        
        public async Task<IActionResult> Basket(ProductBasketQuery query)
        {
            var response = await mediator.Send(query);
            return View(response);
        }

        [HttpPost]
        [Route("/basket")]
        
        public async Task<IActionResult> Basket(AddToBasketCommand command)
        {
            var response = await mediator.Send(command);

            return Json(response);  
        }

        [HttpPost]
        
      
        public async Task<IActionResult> RemoveFromBasket(RemoveFromBasketCommand command)
        {
            var response = await mediator.Send(command);

            return Json(response);
        }

        public async Task<IActionResult> ChangeBasketQuantity(ChangeBasketQuantityCommand command)
        {
            var response = await mediator.Send(command);

            return Json(response);
        }

        [AllowAnonymous]
        [Route("/checkout")]
        public IActionResult Checkout()
        {
            return View();
        }

       
    }
}
