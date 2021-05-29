using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniverseDB.DataBase.Entities;
using UniverseDB.Models;
using UniverseDB.DataBase.Repositories.EntityFramework;
using UniverseDB.DataBase.Repositories;

namespace UniverseDB.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public AccountController(UserManager<IdentityUser> userMgr, SignInManager<IdentityUser> signInMgr)
        {
            userManager = userMgr;
            signInManager = signInMgr;
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new LoginViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user.UserName, model.Password, model.RememberMe, false);
                    if (result.Succeeded)
                    {
                        return Redirect(returnUrl ?? "/");//
                    }
                }
                ModelState.AddModelError(nameof(LoginViewModel.UserName), "Неверный логин или пароль");
            }
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        

        [AllowAnonymous]
        public IActionResult Register(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new RegisterViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
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

        
    }
}
