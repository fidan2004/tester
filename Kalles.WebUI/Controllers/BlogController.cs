using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Kalles.Application.Extensions;
using Kalles.Domain.Business.BlogPostModule;
using System.Threading.Tasks;

namespace Kalles.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IMediator mediator;

        public BlogController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(BlogPostGetAllQuery query)
        {
            var response = await mediator.Send(query);

            if(Request.IsAjaxRequest())
            {
                return PartialView("_BlogPostsBody", response);
            }

            return View(response);
        }

        [AllowAnonymous]
        [Route("/blog/{slug}")]
        public async Task<IActionResult> Details(BlogPostSingleQuery query)
        {
            var blogPost = await mediator.Send(query);

            if (blogPost == null)
            {
                return NotFound();
            }

            return View(blogPost);
        }
    }
}
