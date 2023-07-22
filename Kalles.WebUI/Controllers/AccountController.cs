using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Kalles.Domain.Models.Entities.Membership;
using Kalles.Domain.Models.FormModels;
using System.Threading.Tasks;

namespace Kalles.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<KallesUser> signInManager;
        private readonly UserManager<KallesUser> userManager;

        public AccountController(SignInManager<KallesUser> signInManager,
            UserManager<KallesUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [AllowAnonymous]
        [Route("/signin")]
        public IActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("/signin")]

        public async Task<IActionResult> Signin(UserFormModel model)
        {
            if (!model.IsValid())
                goto end;

            var user = await userManager.FindByEmailAsync(model.UserName);

            if (user == null)
            {
                ModelState.AddModelError("Username", "ad veya sifre sehvdir");
                goto end;
            }

            var result = await signInManager.PasswordSignInAsync(user, model.Password, true, true); //qalici 1-ci true-qalici olaraq yaddasda saxlasin-2-ci true defelerle sehv edende bloklasin...

            if (result.IsNotAllowed)
            {
                ModelState.AddModelError("Username", "Icaze yoxdu");
                goto end;
            }
            else if (result.IsLockedOut)
            {
                ModelState.AddModelError("Username", "5 deq sonra yoxlayin");
                goto end;
            }

            var redirectUrl = Request.Query["ReturnUrl"];

            if (!string.IsNullOrWhiteSpace(redirectUrl))
            {
                return Redirect(redirectUrl);
            }

            return RedirectToAction("Index", "Home");

        end:
            return View(model);
        }
    }
}
