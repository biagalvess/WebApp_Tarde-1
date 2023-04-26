using Microsoft.AspNetCore.Mvc;
using WebApp_Tarde.Models;

namespace WebApp_Tarde.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly Contexto db;

        public ProdutosController(Contexto opt)
        {
            db = opt;
        }
        public IActionResult Lista()
        {
            return View(db.Produto.ToList());
        }
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
