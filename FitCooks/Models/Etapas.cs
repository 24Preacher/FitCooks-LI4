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
        [Key]
        public int id_Etapas { set; get; }

        [Required]
        public float tempo { set; get; }

        [Required]
        [StringLength(50)]
        public string instrucao { set; get; }

        [StringLength(128)]
        public string sugestao { set; get; }

        [Required]
        public virtual Receita receita { set; get; }


        
    }

    public class EtapasContext : DbContext
    {
        public EtapasContext(DbContextOptions<EtapasContext> options)
            : base(options)
        {

        }


        public DbSet<Etapas> etapas { get; set; }
    }
}
