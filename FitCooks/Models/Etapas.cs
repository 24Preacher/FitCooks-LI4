using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitCooks.Models
{
    public class Etapas
    {
        public int id_Etapas { set; get; }

       
        public float tempo { set; get; }

       
      
        public string instrucao { set; get; }

      
        public string sugestao { set; get; }

        public int id_Receita { set; get; }
        public Receita receita { set; get; }
        public ICollection<EtapasIngredientes> etapasIngredientes { set; get; }
        public ICollection<EtapasUtensilios> etapasUtensilios { set; get; }




    }


}
