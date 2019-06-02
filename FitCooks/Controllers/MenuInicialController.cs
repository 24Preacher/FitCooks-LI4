using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitCooks.Models;
using FitCooks.shared;

namespace FitCooks.Controllers
{
    public class MenuInicialController : Controller
    {
        private UserHandling userHandling;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult pesquisarReceita()
        {
            return View();
        }

        public IActionResult adicionarReceita()
        {
            return View();
        }

        public IActionResult verFavoritos()
        {
            return View();
        }

        public IActionResult editarPerfil([Bind] User user)
        {
            if (ModelState.IsValid)
            {
                bool EditStatus = this.userHandling.getUser(user);
                if (EditStatus)
                {
                    ModelState.Clear();
                    TempData["Success"] = "Registration Successful!";
                }
                else
                {
                    TempData["Fail"] = "This User ID already exists. Registration Failed.";
                }
                return View();
            }
        }
    }
}