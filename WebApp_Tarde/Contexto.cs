using Microsoft.EntityFrameworkCore;
using WebApp_Tarde.Entidades;

namespace WebApp_Tarde
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt): base(opt)
        { }
        public DbSet<ProdutoEntidade> Produto { get; set; }
    }
    public class Categorias : DbContext 
    {
        public Categorias(DbContextOptions<Categorias> opt): base(opt)
        {

        }  
        public DbSet<CategoriaEntidade> Categoria { get; set; }
    }
}
