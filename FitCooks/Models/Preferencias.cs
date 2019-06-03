using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitCooks.Models
{
    public class Preferencias
    {
        public int id_utilizador { set; get; }
        public  Utilizador utilizador { set; get; }
        public int id_receita { set; get; }

        public  Receita receita { set; get; }

    }
}
