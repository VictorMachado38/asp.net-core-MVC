using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace LanchesMac.Controllers
{
    public class TesteController : Controller
    {

        public IActionResult Index()
        {
            
            return View();
        }
    }
}