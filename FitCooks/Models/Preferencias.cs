using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitCooks.Models
{
    public class Preferencias
    {
        [Required]
        public virtual Utilizador utilizador { set; get; }

        [Required]
        public virtual Receita receita { set; get; }
    }

    public class PreferenciasContext : DbContext
    {
        public PreferenciasContext(DbContextOptions<PreferenciasContext> options)
            : base(options)
        {

        }


        public DbSet<Preferencias> preferencias { get; set; }
    }
}
