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
using static FitCooks.Models.Receita;

namespace FitCooks.Controllers
{
    [Route("[controller]/[action]")]
    public class ReceitaViewController : Controller
    {
        private FitCooksAPP handling;

        public ReceitaViewController(FitCooksContext context)
        {
            //_context = context;
            handling = new FitCooksAPP(context);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult getReceitas()
        {
            Receita[] receitas = handling.getReceitas();
            return View(receitas);
        }

        public IActionResult VerReceita(int id)
        {
            Receita receita = handling.getReceita(id);
            return View(receita);
        }
    }
}