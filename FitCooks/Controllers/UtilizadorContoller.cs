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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitCooks.Controllers
{
    [Route("api/[controller]")]
    public class UtilizadorController : Controller
    {

        private UtilizadorHandling utilizadorHandling;
        public UtilizadorController(UtilizadorContext context)
        {
            utilizadorHandling = new UtilizadorHandling(context);
        }

        [Authorize]
        [HttpGet]
        public Utilizador[] Get()
        {
            return utilizadorHandling.getUsers();
        }
    }
}