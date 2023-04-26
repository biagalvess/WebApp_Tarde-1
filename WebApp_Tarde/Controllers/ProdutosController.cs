using Microsoft.AspNetCore.Mvc;
using WebApp_Tarde.Entidades;
using WebApp_Tarde.Models;

namespace WebApp_Tarde.Controllers
{
    public class ProdutosController : Controller
    {
        public Contexto db;

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
        [HttpPost]
        public IActionResult SalvarDados(ProdutoEntidade dados)
        {
            if (dados.Id == 0)
            {
                db.Add(dados);
                db.SaveChanges();
            }
            else
            {
                db.Update(dados);

            }
            return RedirectToAction("Lista");
        }
        public IActionResult Editar(int Id, ProdutoEntidade produto)
        {
            
            if (produto != null)
            {
                return View(produto);
            }
            else
            {
                return RedirectToAction("Lista");
            }

        }
        public IActionResult Excluir(ProdutoEntidade produto)
        {
            if(produto != null)
            {
                db.Remove(produto);
            }
            return RedirectToAction("Lista");
        }
    }
}
