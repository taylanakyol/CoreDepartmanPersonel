using System.Security.Claims;
using CoreDepartmanPersonel.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace CoreDepartmanPersonel.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();

        [HttpGet]
        public IActionResult GirisYap()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GirisYap(Admin p)
        {
            var bilgiler = c.admins.FirstOrDefault(x => x.Kullanici == p.Kullanici && x.Sifre == p.Sifre);

            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, p.Kullanici)

                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "personel");

               
            }

            return View();

        }

        public async Task<IActionResult> CikisYap()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "depart");
            
        }



    }
}
