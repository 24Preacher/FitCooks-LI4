using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitCooks.Models
{
    public class IngredientesNutrientes
    {
        public int id_Ingredientes { set; get; }
        public Ingredientes ingredientes { set; get; }
        public int id_Nutrientes { set; get; }
        public Nutrientes nutrientes { set; get; }
        public float valor { set; get; }
    }
}
