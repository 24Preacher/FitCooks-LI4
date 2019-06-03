using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace FitCooks.Models
{
    public class Receita
    {
       
        public int id_Receita { set; get; }

        public string nome { set; get; }

        public string descricao { set; get; }

        public string categoria { set; get; }

       
        public float tempo { set; get; }
        public int nEtapas { set; get; }

        public ICollection<Etapas> etapas { get; set; }
        public ICollection<Classificacao> classificacaos { set; get; }
        public ICollection<Preferencias> preferencias { set; get; }

    }


}



