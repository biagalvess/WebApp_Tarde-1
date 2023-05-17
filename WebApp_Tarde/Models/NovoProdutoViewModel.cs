using WebApp_Tarde.Entidades;

namespace WebApp_Tarde.Models
{
    public class NovoProdutoViewModel : ProdutoEntidade

    {
        public NovoProdutoViewModel()
        {
            Lista_Categorias = new List<CategoriasEntidade>();
        }
        public List<CategoriasEntidade> Lista_Categorias { get; set; }
    }
}
