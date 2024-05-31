using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesStore.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanche(CategoriaId, DescricaoCurta, DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES(1, 'Pão, Hambúrguer, Ovo, Presunto, queijo e batata palha', 'Delicioso pão de Hambúrguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha', 1, '','',0,'Cheese Salada', 12.50)");

            migrationBuilder.Sql("INSERT INTO Lanche(CategoriaId, DescricaoCurta, DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES(1, 'Pão, presunto, mussarela e tomate', 'Delicioso pão francês quentinho com presunto, queijo derretido e tomate', 1, '','',0,'Misto Quente', 9.50)");

            migrationBuilder.Sql("INSERT INTO Lanche(CategoriaId, DescricaoCurta, DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES(1, 'Pão, Hambúrguer, Presunto, mussarela e batata palha', 'Pão de hambúrguer com presunto mussarela e batata palha', 1, '','',0,'X-Salada', 8.70)");

            migrationBuilder.Sql("INSERT INTO Lanche(CategoriaId, DescricaoCurta, DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES(2, 'Pão integral, queijo branco, peito de peru, cenoura, alface e iogurte natural', 'Delicioso pão de Hambúrguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha', 1, '','',1,'Lanche Natural de peito de peru', 20.50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE from Lanches");
        }
    }
}
