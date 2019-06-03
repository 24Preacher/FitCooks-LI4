using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitCooks.Models;
using FitCooks.shared;
using Microsoft.AspNetCore.Mvc;

namespace FitCooks.Controllers
{
    [Route("[controller]/[action]")]

    public class EtapasController : Controller
    {
        private FitCooksAPP handling;
        private int current;
        private int receita;

        public EtapasController(FitCooksContext context)
        {
            handling = new FitCooksAPP(context);
            current = 0;
    }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VerEtapas(int id)
        {
            ViewBag.receita = id;
            ViewBag.etapa = 0;
            Etapas[] etapas = handling.getEtapas(id);
            return View("Index", etapas[0]);
        }

        public IActionResult AvancarEtapa(int id, int e)
        {
            ViewBag.receita = id;
            Etapas[] etapas = handling.getEtapas(id);
            int i = e + 1;
            if (i >= etapas.Length)
                i = 0;
            ViewBag.etapa = i;
            return View("Index", etapas[i]);
        }

        public IActionResult RecuarEtapa(int id, int e)
        {
            ViewBag.receita = id;
            Etapas[] etapas = handling.getEtapas(id);
            int i = e - 1;
            if (i <= 0)
                i = etapas.Length;
            ViewBag.etapa = i;
            return View("Index", etapas[i]);
        }

    }
}