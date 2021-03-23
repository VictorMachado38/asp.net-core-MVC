using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

 namespace LanchesMac.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
               return View();
         }
    }
}