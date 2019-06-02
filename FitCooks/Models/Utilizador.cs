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
        [Key]
        public int id_utilizador { set; get; }
        [Required]
        [StringLength(50)]
        public string nome { set; get; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { set; get; }

        [Required]
        [Display(Name = "username")]
        public string username { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [StringLength(128)]
        public string morada { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime data_nascimento { set; get; }

        [StringLength(50)]
        public string sexo { set; get; }

        public virtual ICollection<Task> Tasks { get; set; }

    }

    public class UtilizadorContext : DbContext
    {
        public UtilizadorContext(DbContextOptions<UtilizadorContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                    .HasOne(t => t.user)
                    .WithMany(u => u.Tasks)
                    .HasForeignKey(t => t.user_id)
                    .HasConstraintName("ForeignKey_User_Task"); 
        }


        public DbSet<Utilizador> utilizador { get; set; }
        public DbSet<Models.Task> task { get; set; }
    }
}
