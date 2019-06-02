using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace FitCooks.Models
{
    public class Receita
    {
        [Key]
        public int id_Receita { set; get; }

        [Required]
        [StringLength(50)]
        public string nome { set; get; }

        [Required]
        [StringLength(50)]
        public string descricao { set; get; }

        //falta imagem 

        [Required]
        [StringLength(50)]
        public string categoria { set; get; }

        [Required]
        public float tempo { set; get; }

        public virtual ICollection<Task> Tasks { get; set; }
    }

    public class ReceitaContext : DbContext
    {
        public ReceitaContext(DbContextOptions<ReceitaContext> options)
            : base(options)
        {

        }


        public DbSet<Receita> receita { get; set; }

    }


}
