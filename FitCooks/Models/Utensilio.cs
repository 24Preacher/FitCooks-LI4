using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitCooks.Models
{
    public class Utensilio
    {
        public int id_Utensilio { set; get; }
        public string nome { set; get; }
        public string descricao { set; get; }
        public ICollection<EtapasUtensilios> etapasUtensilios { set; get; }
    }
}

