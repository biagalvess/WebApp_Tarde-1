using Microsoft.AspNetCore.Mvc;
using WebApp_Tarde.Entidades;
using WebApp_Tarde.Models;
using Microsoft.EntityFrameworkCore;

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
            return View(db.Produtos.Include(a=> a.Categoria).ToList());
        }
        public IActionResult Cadastro()
        {
            NovoProdutoViewModel model = new NovoProdutoViewModel();
            model.Lista_Categorias = db.Categorias.ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult SalvarDados(ProdutoEntidade dados)
        {
   
                db.Produtos.Add(dados);
                db.SaveChanges();

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
