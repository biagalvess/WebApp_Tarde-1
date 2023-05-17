using Microsoft.EntityFrameworkCore;
using WebApp_Tarde.Entidades;

namespace WebApp_Tarde
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt): base(opt)
        { }
        public DbSet<ProdutoEntidade> Produtos { get; set; }
        public DbSet<CategoriasEntidade> Categorias { get; set; }

        public DbSet <VendasEndidades> Vendas { get; set; }
        public DbSet <ItensVendasEntidade> ItensVendas { get;set }
    }
}
