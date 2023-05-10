using Microsoft.AspNetCore.Mvc;
using WebApp_Tarde.Entidades;

namespace WebApp_Tarde.Controllers
{
    public class CategoriasController : Controller
    {
        public Contexto db { get; set; }

        public CategoriasController(Contexto opt)
        {
            db = opt;
        }
        public IActionResult Lista()
        {
            return View(db.Categoria.ToList());
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SalvarDados(CategoriaEntidade dados)
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
        public IActionResult Editar(int id, CategoriaEntidade Categoria)
        {
            if (Categoria != null)
            {
                return View(Categoria);
            }
            else
            {
                return RedirectToAction("Lista");
            }
        }
        public IActionResult Excluir(CategoriaEntidade categoria)
        {
            if (categoria != null)
            {
                db.Remove(categoria);
            }
            return RedirectToAction("Lista");
        }
    }
}
