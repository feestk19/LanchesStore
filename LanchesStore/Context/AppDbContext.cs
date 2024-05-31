#region Manutenções/Implementações
/*
 31/05/2024 - Implementado nova tabela de carrinho de compras e atualização do banco de dados
 */
#endregion

using LanchesStore.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesStore.Context;

public class AppDbContext : DbContext
{
    //Nessa classe ficam as classes que queremos mapear
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

    //Define quais classes quero mapear para cada tabela
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Lanche> Lanches { get; set; }
    public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }
}
