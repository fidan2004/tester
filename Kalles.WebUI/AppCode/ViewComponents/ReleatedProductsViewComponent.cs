using Kalles.Domain.Business.ProductModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Kalles.WebUI.AppCode.ViewComponents
{
    public class ReleatedProductsViewComponent :ViewComponent
    {
        private readonly IMediator mediator;
        public ReleatedProductsViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var query = new ProductReleatedQuery();
            var posts = await mediator.Send(query);
            return View(posts);
        }
    }
}
