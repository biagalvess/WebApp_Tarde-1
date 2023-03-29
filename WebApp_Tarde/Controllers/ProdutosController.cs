using Microsoft.AspNetCore.Mvc;

namespace WebApp_Tarde.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
