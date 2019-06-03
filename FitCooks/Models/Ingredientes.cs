using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitCooks.Models
{
    public class Ingredientes
    {
        public int id_Ingredientes { set; get; }

        public string descricao { set; get; }

        public float preco { set; get; }

        public string Nome { set; get; }
        public ICollection<EtapasIngredientes> etapasIngredientes { set; get; }
        public ICollection<IngredientesNutrientes> ingredientesNutrientes { set; get; }


    }
}
