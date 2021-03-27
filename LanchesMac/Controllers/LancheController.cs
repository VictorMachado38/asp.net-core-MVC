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
        //private readonly ICategoriaRepository _categoriaRepositoriy;

        public LancheController(ILancheRepository lancheRepository/*, ICategoriaRepository categoriaRepositoriy*/)
        {
            _lancheRepository = lancheRepository;
            //_categoriaRepositoriy = categoriaRepositoriy;
        }

        public IActionResult List (string categoria)
        {
            string _categoria = categoria;
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if(string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                lanches = _lancheRepository.Lanches
                            .Where(p => p.Categoria.CategoriaNome.Equals(categoria))
                            .OrderBy(p => p.Nome);

               
                categoriaAtual = _categoria;
            
            }

            var lancheListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };

            //var lanchesListModel = new LancheListViewModel();
            //lanchesListModel.Lanches = _lancheRepository.Lanches;
            //lanchesListModel.CategoriaAtual = "Categoria atual definido no contorler";
            return View(lancheListViewModel);
        }
        
        public IActionResult Details(int lancheId)
        {
            var lanche = _lancheRepository.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
            if(lanche == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(lanche);
        }
    }

}