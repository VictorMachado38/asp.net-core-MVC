using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using LanchesMac.Repositories;


namespace LanchesMac.Controllers
{

    public class CategoriaController : Controller
    {
        public CategoriaController(ICategoriaRepository categoriaRepositoriy)
        {

        }
    }

}
