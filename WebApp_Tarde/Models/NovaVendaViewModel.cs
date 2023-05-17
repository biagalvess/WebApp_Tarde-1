using WebApp_Tarde.Entidades;
namespace WebApp_Tarde.Models
{
    public class NovaVendaViewModel
    {
        public NovaVendaViewModel()
        {
            Lista_Produto = new List<ProdutoEntidade>();
        }
        public List<ProdutoEntidade> Lista_Produto { get; set; }


            
    }
}
