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

        [Key]
        public int id_Nutrientes { set; get; }

        [Required]
        [StringLength(50)]
        public string nome { set; get; }

    }

    public class NutrientesContext : DbContext
    {
        public NutrientesContext(DbContextOptions<NutrientesContext> options)
            : base(options)
        {

        }


        public DbSet<Nutrientes> nutrientes { get; set; }
    }
}
