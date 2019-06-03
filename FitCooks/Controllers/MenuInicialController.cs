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
        private FitcooksAPP handling;
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

        public IActionResult editarPerfil(Utilizador user)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                TempData["Success"] = "Registration Successful!";
                return View();
             }

                TempData["Fail"] = "This User ID already exists. Registration Failed.";
               
                return View();
            }
        }
}

