using Microsoft.AspNetCore.Mvc;
using WebApp_Tarde.Models;

namespace WebApp_Tarde.Controllers
{
    public class ClientesController : Controller
    {
        public static List<ClientesViewModel> db = new List<ClientesViewModel>();
        public IActionResult Lista()
        {
            return View( db );
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados(ClientesViewModel dados)
        {
            if(dados.Id == 0)
            {
                Random rand = new Random();
                int numeroAleatorio = rand.Next(1, 9999);
                dados.Id = numeroAleatorio;
                db.Add(dados);
            }
            else
            {
                int indice = db.FindIndex(a => a.Id == dados.Id);
                db[indice] = dados;

            }
            return RedirectToAction("Lista");
        }

        public IActionResult Excluir(int id)
        {
            ClientesViewModel cliente = db.Find(a => a.Id == id);
            if(cliente != null)
            {
                db.Remove(cliente);
            }
            return RedirectToAction("Lista");
        }

        public IActionResult Editar(int id)
        {
            ClientesViewModel cliente = db.Find(a => a.Id == id);
            if(cliente != null)
            {
                return View(cliente);
            }
            else
            {
                return RedirectToAction("Lista");  
            }
            
        }
    }
}
