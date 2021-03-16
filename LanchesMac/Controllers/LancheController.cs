using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using LanchesMac.Repositories;
using LanchesMac.ViewModels;
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
            ViewBag.Lanche = "Lanches";
            ViewData["Catergoria"] = "Categoria";

            //---------------------------


            //var lanches = _lancheRepository.Lanches;
            //return View(lanches);
            var lanchesListModel = new LancheListViewModel();
            lanchesListModel.Lanches = _lancheRepository.Lanches;
            lanchesListModel.CategoriaAtual = "Categoria atual definido no contorler";
            return View(lanchesListModel);
        }
        
    }

}