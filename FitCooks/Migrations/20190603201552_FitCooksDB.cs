using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitCooks.Migrations
{
    public partial class FitCooksDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ingredientes",
                columns: table => new
                {
                    id_Ingredientes = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    descricao = table.Column<string>(maxLength: 128, nullable: true),
                    preco = table.Column<float>(nullable: false),
                    Nome = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredientes", x => x.id_Ingredientes);
                });

            migrationBuilder.CreateTable(
                name: "nutrientes",
                columns: table => new
                {
                    id_Nutrientes = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nutrientes", x => x.id_Nutrientes);
                });

            migrationBuilder.CreateTable(
                name: "receitas",
                columns: table => new
                {
                    id_Receita = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(maxLength: 50, nullable: true),
                    descricao = table.Column<string>(maxLength: 250, nullable: true),
                    categoria = table.Column<string>(maxLength: 50, nullable: true),
                    tempo = table.Column<float>(nullable: false),
                    nEtapas = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_receitas", x => x.id_Receita);
                });

            migrationBuilder.CreateTable(
                name: "utensilios",
                columns: table => new
                {
                    id_Utensilio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(maxLength: 50, nullable: false),
                    descricao = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utensilios", x => x.id_Utensilio);
                });

            migrationBuilder.CreateTable(
                name: "utilizadores",
                columns: table => new
                {
                    id_Utilizador = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(maxLength: 50, nullable: false),
                    email = table.Column<string>(maxLength: 50, nullable: false),
                    username = table.Column<string>(maxLength: 50, nullable: false),
                    password = table.Column<string>(maxLength: 128, nullable: false),
                    morada = table.Column<string>(maxLength: 50, nullable: true),
                    data_nascimento = table.Column<DateTime>(nullable: false),
                    sexo = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utilizadores", x => x.id_Utilizador);
                });

            migrationBuilder.CreateTable(
                name: "ingredientesNutrientes",
                columns: table => new
                {
                    id_Ingredientes = table.Column<int>(nullable: false),
                    id_Nutrientes = table.Column<int>(nullable: false),
                    valor = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredientesNutrientes", x => new { x.id_Ingredientes, x.id_Nutrientes });
                    table.ForeignKey(
                        name: "FK_ingredientesNutrientes_ingredientes_id_Ingredientes",
                        column: x => x.id_Ingredientes,
                        principalTable: "ingredientes",
                        principalColumn: "id_Ingredientes",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ingredientesNutrientes_nutrientes_id_Nutrientes",
                        column: x => x.id_Nutrientes,
                        principalTable: "nutrientes",
                        principalColumn: "id_Nutrientes",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "etapas",
                columns: table => new
                {
                    id_Etapas = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    tempo = table.Column<float>(nullable: false),
                    instrucao = table.Column<string>(maxLength: 500, nullable: false),
                    sugestao = table.Column<string>(maxLength: 50, nullable: true),
                    id_Receita = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etapas", x => x.id_Etapas);
                    table.ForeignKey(
                        name: "FK_etapas_receitas_id_Receita",
                        column: x => x.id_Receita,
                        principalTable: "receitas",
                        principalColumn: "id_Receita",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "classificacaos",
                columns: table => new
                {
                    id_Utilizador = table.Column<int>(nullable: false),
                    id_Receita = table.Column<int>(nullable: false),
                    sabor = table.Column<float>(nullable: false),
                    tempo = table.Column<float>(nullable: false),
                    dificuldade = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classificacaos", x => new { x.id_Utilizador, x.id_Receita });
                    table.ForeignKey(
                        name: "FK_classificacaos_receitas_id_Receita",
                        column: x => x.id_Receita,
                        principalTable: "receitas",
                        principalColumn: "id_Receita",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_classificacaos_utilizadores_id_Utilizador",
                        column: x => x.id_Utilizador,
                        principalTable: "utilizadores",
                        principalColumn: "id_Utilizador",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "preferencias",
                columns: table => new
                {
                    id_utilizador = table.Column<int>(nullable: false),
                    id_receita = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_preferencias", x => new { x.id_utilizador, x.id_receita });
                    table.ForeignKey(
                        name: "FK_preferencias_receitas_id_receita",
                        column: x => x.id_receita,
                        principalTable: "receitas",
                        principalColumn: "id_Receita",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_preferencias_utilizadores_id_utilizador",
                        column: x => x.id_utilizador,
                        principalTable: "utilizadores",
                        principalColumn: "id_Utilizador",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "etapasIngredientes",
                columns: table => new
                {
                    id_Etapas = table.Column<int>(nullable: false),
                    id_Ingredientes = table.Column<int>(nullable: false),
                    quantidade = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etapasIngredientes", x => new { x.id_Etapas, x.id_Ingredientes });
                    table.ForeignKey(
                        name: "FK_etapasIngredientes_etapas_id_Etapas",
                        column: x => x.id_Etapas,
                        principalTable: "etapas",
                        principalColumn: "id_Etapas",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_etapasIngredientes_ingredientes_id_Ingredientes",
                        column: x => x.id_Ingredientes,
                        principalTable: "ingredientes",
                        principalColumn: "id_Ingredientes",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "etapasUtensilios",
                columns: table => new
                {
                    id_Etapas = table.Column<int>(nullable: false),
                    id_Utensilios = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etapasUtensilios", x => new { x.id_Etapas, x.id_Utensilios });
                    table.ForeignKey(
                        name: "FK_etapasUtensilios_etapas_id_Etapas",
                        column: x => x.id_Etapas,
                        principalTable: "etapas",
                        principalColumn: "id_Etapas",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_etapasUtensilios_utensilios_id_Utensilios",
                        column: x => x.id_Utensilios,
                        principalTable: "utensilios",
                        principalColumn: "id_Utensilio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_classificacaos_id_Receita",
                table: "classificacaos",
                column: "id_Receita");

            migrationBuilder.CreateIndex(
                name: "IX_etapas_id_Receita",
                table: "etapas",
                column: "id_Receita");

            migrationBuilder.CreateIndex(
                name: "IX_etapasIngredientes_id_Ingredientes",
                table: "etapasIngredientes",
                column: "id_Ingredientes");

            migrationBuilder.CreateIndex(
                name: "IX_etapasUtensilios_id_Utensilios",
                table: "etapasUtensilios",
                column: "id_Utensilios");

            migrationBuilder.CreateIndex(
                name: "IX_ingredientesNutrientes_id_Nutrientes",
                table: "ingredientesNutrientes",
                column: "id_Nutrientes");

            migrationBuilder.CreateIndex(
                name: "IX_preferencias_id_receita",
                table: "preferencias",
                column: "id_receita");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "classificacaos");

            migrationBuilder.DropTable(
                name: "etapasIngredientes");

            migrationBuilder.DropTable(
                name: "etapasUtensilios");

            migrationBuilder.DropTable(
                name: "ingredientesNutrientes");

            migrationBuilder.DropTable(
                name: "preferencias");

            migrationBuilder.DropTable(
                name: "etapas");

            migrationBuilder.DropTable(
                name: "utensilios");

            migrationBuilder.DropTable(
                name: "ingredientes");

            migrationBuilder.DropTable(
                name: "nutrientes");

            migrationBuilder.DropTable(
                name: "utilizadores");

            migrationBuilder.DropTable(
                name: "receitas");
        }
    }
}
