using Microsoft.AspNetCore.Mvc;
using WebApp_Tarde.Entidades;

namespace WebApp_Tarde.Controllers
{
    public class CategoriasController : Controller
    {
        public Contexto contexto;

        public CategoriasController(Contexto db)
        {
            contexto = db;
        }
        public IActionResult Lista()
        {
            return View(contexto.Categorias.ToList());
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SalvarDados(CategoriasEntidade dados)
        {
            if (dados.Id != null)
            {
                contexto.Categorias.Update(dados);
                contexto.SaveChanges();
            }
            else
            {
                contexto.Categorias.Add(dados);
                contexto.SaveChanges();

            }
            return RedirectToAction("Lista");
        }
        public IActionResult Editar(int id, CategoriasEntidade Categoria)
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
        public IActionResult Excluir(CategoriasEntidade id, CategoriasEntidade dados)
        {
            if (id != null)
            {
                contexto.Categorias.Remove(dados);
                contexto.SaveChanges(); 
            }
            return RedirectToAction("Lista");
        }
    }
}
