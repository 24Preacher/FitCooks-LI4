﻿// <auto-generated />
using System;
using FitCooks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FitCooks.Migrations
{
    [DbContext(typeof(FitCooksContext))]
    partial class FitCooksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FitCooks.Models.Classificacao", b =>
                {
                    b.Property<int>("id_Utilizador");

                    b.Property<int>("id_Receita");

                    b.Property<float>("dificuldade");

                    b.Property<float>("sabor");

                    b.Property<float>("tempo");

                    b.HasKey("id_Utilizador", "id_Receita");

                    b.HasIndex("id_Receita");

                    b.ToTable("classificacaos");
                });

            modelBuilder.Entity("FitCooks.Models.Etapas", b =>
                {
                    b.Property<int>("id_Etapas")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_Receita");

                    b.Property<string>("instrucao")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("sugestao")
                        .HasMaxLength(50);

                    b.Property<float>("tempo");

                    b.HasKey("id_Etapas");

                    b.HasIndex("id_Receita");

                    b.ToTable("etapas");
                });

            modelBuilder.Entity("FitCooks.Models.EtapasIngredientes", b =>
                {
                    b.Property<int>("id_Etapas");

                    b.Property<int>("id_Ingredientes");

                    b.Property<string>("quantidade")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("id_Etapas", "id_Ingredientes");

                    b.HasIndex("id_Ingredientes");

                    b.ToTable("etapasIngredientes");
                });

            modelBuilder.Entity("FitCooks.Models.EtapasUtensilios", b =>
                {
                    b.Property<int>("id_Etapas");

                    b.Property<int>("id_Utensilios");

                    b.HasKey("id_Etapas", "id_Utensilios");

                    b.HasIndex("id_Utensilios");

                    b.ToTable("etapasUtensilios");
                });

            modelBuilder.Entity("FitCooks.Models.Ingredientes", b =>
                {
                    b.Property<int>("id_Ingredientes")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("descricao")
                        .HasMaxLength(128);

                    b.Property<float>("preco");

                    b.HasKey("id_Ingredientes");

                    b.ToTable("ingredientes");
                });

            modelBuilder.Entity("FitCooks.Models.IngredientesNutrientes", b =>
                {
                    b.Property<int>("id_Ingredientes");

                    b.Property<int>("id_Nutrientes");

                    b.Property<float>("valor");

                    b.HasKey("id_Ingredientes", "id_Nutrientes");

                    b.HasIndex("id_Nutrientes");

                    b.ToTable("ingredientesNutrientes");
                });

            modelBuilder.Entity("FitCooks.Models.Nutrientes", b =>
                {
                    b.Property<int>("id_Nutrientes")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("id_Nutrientes");

                    b.ToTable("nutrientes");
                });

            modelBuilder.Entity("FitCooks.Models.Preferencias", b =>
                {
                    b.Property<int>("id_utilizador");

                    b.Property<int>("id_receita");

                    b.HasKey("id_utilizador", "id_receita");

                    b.HasIndex("id_receita");

                    b.ToTable("preferencias");
                });

            modelBuilder.Entity("FitCooks.Models.Receita", b =>
                {
                    b.Property<int>("id_Receita")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoria")
                        .HasMaxLength(50);

                    b.Property<string>("descricao")
                        .HasMaxLength(250);

                    b.Property<int>("nEtapas");

                    b.Property<string>("nome")
                        .HasMaxLength(50);

                    b.Property<float>("tempo");

                    b.HasKey("id_Receita");

                    b.ToTable("receitas");
                });

            modelBuilder.Entity("FitCooks.Models.Utensilio", b =>
                {
                    b.Property<int>("id_Utensilio")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricao")
                        .HasMaxLength(128);

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("id_Utensilio");

                    b.ToTable("utensilios");
                });

            modelBuilder.Entity("FitCooks.Models.Utilizador", b =>
                {
                    b.Property<int>("id_Utilizador")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("data_nascimento");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("morada")
                        .HasMaxLength(50);

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("sexo")
                        .HasMaxLength(50);

                    b.Property<string>("username")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("id_Utilizador");

                    b.ToTable("utilizadores");
                });

            modelBuilder.Entity("FitCooks.Models.Classificacao", b =>
                {
                    b.HasOne("FitCooks.Models.Receita", "receita")
                        .WithMany("classificacaos")
                        .HasForeignKey("id_Receita")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitCooks.Models.Utilizador", "utilizador")
                        .WithMany("classificacaos")
                        .HasForeignKey("id_Utilizador")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FitCooks.Models.Etapas", b =>
                {
                    b.HasOne("FitCooks.Models.Receita", "receita")
                        .WithMany("etapas")
                        .HasForeignKey("id_Receita")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FitCooks.Models.EtapasIngredientes", b =>
                {
                    b.HasOne("FitCooks.Models.Etapas", "etapas")
                        .WithMany("etapasIngredientes")
                        .HasForeignKey("id_Etapas")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitCooks.Models.Ingredientes", "ingredientes")
                        .WithMany("etapasIngredientes")
                        .HasForeignKey("id_Ingredientes")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FitCooks.Models.EtapasUtensilios", b =>
                {
                    b.HasOne("FitCooks.Models.Etapas", "etapas")
                        .WithMany("etapasUtensilios")
                        .HasForeignKey("id_Etapas")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitCooks.Models.Utensilio", "utensilio")
                        .WithMany("etapasUtensilios")
                        .HasForeignKey("id_Utensilios")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FitCooks.Models.IngredientesNutrientes", b =>
                {
                    b.HasOne("FitCooks.Models.Ingredientes", "ingredientes")
                        .WithMany("ingredientesNutrientes")
                        .HasForeignKey("id_Ingredientes")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitCooks.Models.Nutrientes", "nutrientes")
                        .WithMany("ingredientesNutrientes")
                        .HasForeignKey("id_Nutrientes")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FitCooks.Models.Preferencias", b =>
                {
                    b.HasOne("FitCooks.Models.Receita", "receita")
                        .WithMany("preferencias")
                        .HasForeignKey("id_receita")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FitCooks.Models.Utilizador", "utilizador")
                        .WithMany("preferencias")
                        .HasForeignKey("id_utilizador")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
