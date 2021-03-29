using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace LanchesMac.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}

        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CarrinhoCompraItem>  CarrinhoCompraItens { get; set; }
       // public DbSet<LanchesMac.Models.CarrinhoCompra> CarrinhoCompra { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }

}

}
