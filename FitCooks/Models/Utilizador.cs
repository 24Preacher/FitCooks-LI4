using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitCooks.Models
{
    public class Utilizador
    {   
        public int id_Utilizador { set; get; }
        public string nome { set; get; }
        public string email { set; get; }
        public string username { set; get; }
        public string password { set; get; }
        public string morada { set; get; }
        public DateTime data_nascimento { set; get; }
        public string sexo { set; get; }
        public ICollection<Classificacao> classificacaos { set; get; }
        public ICollection<Preferencias> preferencias { set; get; }

        
    }
}
