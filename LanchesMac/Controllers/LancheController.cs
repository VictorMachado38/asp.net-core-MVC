using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using LanchesMac.Repositories;
using LanchesMac.ViewModels;
using System.Collections.Generic;
using LanchesMac.Models;
using System.Linq;

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

        public IActionResult List (string catergoia)
        {
            string _catergoria = catergoia;
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if(string.IsNullOrEmpty(catergoia))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LanchesId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                if(string.Equals("Normal",_catergoria, System.StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepository.Lanches.Where(l => l.Categoria.CategoriaNome.Equals("Normal")).OrderBy(l => l.Nome);
                }
                else
                {
                    lanches = _lancheRepository.Lanches.Where(l => l.Categoria.CategoriaNome.Equals("Natural")).OrderBy(l => l.Nome);
                }
            
            }

            var lanchesListModel = new LancheListViewModel();
            lanchesListModel.Lanches = _lancheRepository.Lanches;
            lanchesListModel.CategoriaAtual = "Categoria atual definido no contorler";
            return View(lanchesListModel);
        }
        
    }

}