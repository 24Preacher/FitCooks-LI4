using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitCooks.Models
{
    public class EtapasUtensilios
    {
        public int id_Etapas { set; get; }
        public Etapas etapas { set; get; }
        public int id_Utensilios { set; get; }
        public Utensilio utensilio { set; get; }
    }
}
