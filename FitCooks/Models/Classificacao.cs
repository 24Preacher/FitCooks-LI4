using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitCooks.Models
{
    public class Classificacao
    {
        public int id_Utilizador { set; get; }
        public Utilizador utilizador { set; get; }
        public int id_Receita { set; get; } 
        public Receita receita { set; get; }
        public float sabor { set; get; }
        public float tempo { set; get; }
        public float dificuldade { set; get; }
    }
}
