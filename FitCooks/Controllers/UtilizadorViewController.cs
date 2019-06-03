using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FitCooks.Models;
using FitCooks.shared;
using static FitCooks.Models.Utilizador;

namespace FitCooks.Controllers
{
    
    [Route("[controller]/[action]")]
    public class UtilizadorViewController : Controller
    {

        private FitcooksAPP handling;

        public UtilizadorViewController(FitCooksContext context)
        {
            //_context = context;
            handling = new FitcooksAPP(context);
        }
        [Authorize]
        public IActionResult getUsers()
        {
            Utilizador[] utilizadores = handling.getUsers();
            return View(utilizadores);
        }

        [HttpGet]   
        public IActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterUser([Bind] Utilizador user)
        {
            if (ModelState.IsValid){
                bool RegistrationStatus = this.handling.registerUser(user);
                if (RegistrationStatus){
                    ModelState.Clear();
                    TempData["Success"] = "Registration Successful!";
                }else{
                    TempData["Fail"] = "This User ID already exists. Registration Failed.";
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult UserLogin()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UserLogin([Bind] Utilizador user)
        {
            ModelState.Remove("nome");
            ModelState.Remove("email");

            if (ModelState.IsValid)
            {
                var LoginStatus = this.handling.validateUser(user);
                if (LoginStatus)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.username)
                    };
                    ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "MenuInicial");
                }
                else
                {
                    TempData["UserLoginFailed"] = "Login Failed.Please enter correct credentials";
                }
            }
            return RedirectToAction("Index","Home");   
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("index", "Home");
        }
    }
}