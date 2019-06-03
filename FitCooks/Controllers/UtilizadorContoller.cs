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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitCooks.Controllers
{
    [Route("api/[controller]")]
    public class UtilizadorController : Controller
    {

        private FitCooksAPP handling;
        public UtilizadorController(FitCooksContext context)
        {
            handling = new FitCooksAPP(context);
        }

        [Authorize]
        [HttpGet]
        public Utilizador[] Get()
        {
            return handling.getUsers();
        }
    }
}