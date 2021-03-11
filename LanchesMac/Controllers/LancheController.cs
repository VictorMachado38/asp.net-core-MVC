using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using LanchesMac.Repositories;
namespace LanchesMac.Controllers
{

    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly ICategoriaRepositoriy _categoriaRepositoriy;

        public LancheController(ILancheRepository lancheRepository, ICategoriaRepositoriy categoriaRepositoriy)
        {
            _lancheRepository = lancheRepository;
            _categoriaRepositoriy = categoriaRepositoriy;
        }

        public IActionResult List ()
        {
            var lanches = _lancheRepository.Lanches;
            return View(lanches);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //    }
    }

}