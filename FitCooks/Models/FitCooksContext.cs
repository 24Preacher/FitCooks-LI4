using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitCooks.Models
{
    public class FitCooksContext : DbContext
    {
        public FitCooksContext(DbContextOptions<FitCooksContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-UBJL3N9;Database=FitCooksDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Receita>(entity =>
            {
                entity.HasKey(o => o.id_Receita);
                entity.Property(r => r.descricao).HasMaxLength(250);
                entity.Property(r => r.nome).HasMaxLength(50);
                entity.Property(r => r.categoria).HasMaxLength(50);
            });

            modelBuilder.Entity<Utilizador>(entity =>
            {
                entity.HasKey(o => o.id_Utilizador);
                entity.Property(u => u.email).HasMaxLength(50).IsRequired();
                entity.Property(u => u.nome).HasMaxLength(50).IsRequired();
                entity.Property(u => u.morada).HasMaxLength(50);
                entity.Property(u => u.username).HasMaxLength(50).IsRequired();
                entity.Property(u => u.password).HasMaxLength(128).IsRequired();
                entity.Property(u => u.sexo).HasMaxLength(50);
            });

            modelBuilder.Entity<Utensilio>(entity =>
            {
                entity.HasKey(o => o.id_Utensilio);
                entity.Property(u => u.nome).HasMaxLength(50).IsRequired();
                entity.Property(u => u.descricao).HasMaxLength(128);
            });

            modelBuilder.Entity<Ingredientes>(entity =>
            {
                entity.HasKey(o => o.id_Ingredientes);
                entity.Property(i => i.Nome).HasMaxLength(50).IsRequired();
                entity.Property(i => i.descricao).HasMaxLength(128);
            });

            modelBuilder.Entity<Nutrientes>(entity =>
            {
                entity.HasKey(o => o.id_Nutrientes);
                entity.Property(n => n.nome).HasMaxLength(50).IsRequired();
            });

            modelBuilder.Entity<Etapas>(entity =>
            {
                entity.HasKey(o => o.id_Etapas);
                entity.HasOne(e => e.receita)
                    .WithMany(r => r.etapas)
                    .HasForeignKey(e => e.id_Receita);
                entity.Property(e => e.instrucao).HasMaxLength(500).IsRequired();
                entity.Property(e => e.sugestao).HasMaxLength(50);
            });

            modelBuilder.Entity<Classificacao>(entity =>
            {
                entity.HasKey(o => new { o.id_Utilizador, o.id_Receita });
                entity.HasOne<Utilizador>(c => c.utilizador)
                        .WithMany(u => u.classificacaos)
                        .HasForeignKey(c => c.id_Utilizador);
                entity.HasOne<Receita>(c => c.receita)
                        .WithMany(u => u.classificacaos)
                        .HasForeignKey(c => c.id_Receita);
            });

            modelBuilder.Entity<EtapasIngredientes>(entity =>
            {
                entity.HasKey(o => new { o.id_Etapas, o.id_Ingredientes });
                entity.HasOne<Etapas>(c => c.etapas)
                        .WithMany(u => u.etapasIngredientes)
                        .HasForeignKey(c => c.id_Etapas);
                entity.HasOne<Ingredientes>(c => c.ingredientes)
                        .WithMany(u => u.etapasIngredientes)
                        .HasForeignKey(c => c.id_Ingredientes);
                entity.Property(e => e.quantidade).HasMaxLength(50).IsRequired();
            });

            modelBuilder.Entity<EtapasUtensilios>(entity =>
            {
                entity.HasKey(o => new { o.id_Etapas, o.id_Utensilios });
                entity.HasOne<Etapas>(c => c.etapas)
                        .WithMany(u => u.etapasUtensilios)
                        .HasForeignKey(c => c.id_Etapas);
                entity.HasOne<Utensilio>(c => c.utensilio)
                        .WithMany(u => u.etapasUtensilios)
                        .HasForeignKey(c => c.id_Utensilios);
            });

            modelBuilder.Entity<IngredientesNutrientes>(entity =>
            {
                entity.HasKey(o => new { o.id_Ingredientes, o.id_Nutrientes });
                entity.HasOne<Ingredientes>(c => c.ingredientes)
                        .WithMany(u => u.ingredientesNutrientes)
                        .HasForeignKey(c => c.id_Ingredientes);
                entity.HasOne<Nutrientes>(c => c.nutrientes)
                        .WithMany(u => u.ingredientesNutrientes)
                        .HasForeignKey(c => c.id_Nutrientes);
            });

            modelBuilder.Entity<Preferencias>(entity =>
            {
                entity.HasKey(o => new { o.id_utilizador, o.id_receita });
                entity.HasOne<Utilizador>(c => c.utilizador)
                        .WithMany(u => u.preferencias)
                        .HasForeignKey(c => c.id_utilizador);
                entity.HasOne<Receita>(c => c.receita)
                        .WithMany(u => u.preferencias)
                        .HasForeignKey(c => c.id_receita);
            });
        }


        public DbSet<Utilizador> utilizadores { get; set; }
        public DbSet<Receita> receitas { get; set; }
        public DbSet<Etapas> etapas { get; set; }
        public DbSet<Ingredientes> ingredientes { get; set; }
        public DbSet<Nutrientes> nutrientes { get; set; }
        public DbSet<Utensilio> utensilios { get; set; }
        public DbSet<EtapasIngredientes> etapasIngredientes { get; set; }
        public DbSet<EtapasUtensilios> etapasUtensilios { get; set; }
        public DbSet<IngredientesNutrientes> ingredientesNutrientes { get; set; }
        public DbSet<Preferencias> preferencias { get; set; }
        public DbSet<Classificacao> classificacaos { get; set; }
    }
}

