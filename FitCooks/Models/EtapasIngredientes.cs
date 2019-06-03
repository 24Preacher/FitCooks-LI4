using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitCooks.Models
{
    public class EtapasIngredientes
    {
        public int id_Etapas { set; get; }
        public Etapas etapas { set; get; }
        public int id_Ingredientes { set; get; }
        public Ingredientes ingredientes { set; get; }
        public string quantidade { set; get; }
    }
}
