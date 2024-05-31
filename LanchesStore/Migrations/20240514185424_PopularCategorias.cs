﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesStore.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome, CategoriaDescricao) " + 
                "VALUES ('Normal', 'Lanche feito com ingredientes normais')");

            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome, CategoriaDescricao) " +
                "VALUES ('Natural', 'Lanche feito com ingredientes integrais e naturais')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categoria");
        }
    }
}
