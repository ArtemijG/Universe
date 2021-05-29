using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniverseDB.DataBase;

namespace UniverseDB.Controllers
{
    [Area("User")]
    public class CartController : Controller
    {
        
        
        private readonly DataManager dataManager;

        private readonly SignInManager<IdentityUser> signInManager;
        public CartController(DataManager dataManager, SignInManager<IdentityUser> signInMgr)
        {
            this.dataManager = dataManager;
            signInManager = signInMgr;
        }

       [AllowAnonymous]
        public IActionResult Buy(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new RegisterViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Buy(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser
                {
                    Id = Guid.NewGuid().ToString(),
                    Email = model.Email,
                    UserName = model.UserName,
                    PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, model.Password),
                    SecurityStamp = string.Empty,
                    EmailConfirmed = true,
                    //WalletBalance = 0,
                    //CountryId= 1
                };

                IdentityUserRole<string> userRole = new IdentityUserRole<string>
                {
                    UserId = user.Id,
                    RoleId = "1"
                };
                // добавляем пользователя
                var resultUser = await userManager.CreateAsync(user);
                var resultRole = await userManager.AddToRoleAsync(user, "user");
                //IdentityRole resultRole = await    //userManager.AddToRoleAsync(user.Id,"user")
                if (resultUser.Succeeded && resultRole.Succeeded)
                {
                    // установка куки
                    await signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in resultUser.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
