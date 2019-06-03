using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitCooks.Models
{
    public class Nutrientes
    {

        public int id_Nutrientes { set; get; }

        public string nome { set; get; }
        public ICollection<IngredientesNutrientes> ingredientesNutrientes { set; get; }


    }
}
