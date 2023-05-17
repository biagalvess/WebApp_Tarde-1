using Microsoft.AspNetCore.Mvc;

namespace WebApp_Tarde.Controllers
{
    public class VendasController : Controller
    {
        private Contexto db;
        public VendasController (Contexto contexto)
        {
            db = contexto;
        }
        public IActionResult Lista
            ()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();

        }
        [HttpPost]
        public IActionResult SalvarDados()
        {
            return View();


        }
    }
}
