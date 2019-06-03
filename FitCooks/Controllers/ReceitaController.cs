using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitCooks.Models;
using FitCooks.shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static FitCooks.Models.Receita;

namespace FitCooks.Controllers
{
    [Route("api/[controller]")]
    public class ReceitaController : Controller
    {

        private FitCooksAPP handling;
        public ReceitaController(FitCooksContext context)
        {
            handling = new FitCooksAPP(context);
        }        
    }
}