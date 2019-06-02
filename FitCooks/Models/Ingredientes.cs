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
        [Key]
        [Required]
        public int id_Ingredientes { set; get; }

        //falta imagem

        [Required]
        [StringLength(50)]
        public string descricao { set; get; }

        [Required]
        public float preco { set; get; }

        [Required]
        [StringLength(50)]
        public string Nome { set; get; }

    }

    public class IngredientesContext : DbContext
    {
        public IngredientesContext(DbContextOptions<IngredientesContext> options)
            : base(options)
        {

        }


        public DbSet<Ingredientes> ingredientes { get; set; }
    }
}
