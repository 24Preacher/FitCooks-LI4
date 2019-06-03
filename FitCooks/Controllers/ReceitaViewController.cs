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
        private FitcooksAPP handling;

        public ReceitaViewController(FitCooksContext context)
        {
            //_context = context;
            handling = new FitcooksAPP(context);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}