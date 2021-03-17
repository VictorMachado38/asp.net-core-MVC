using LanchesMac.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using LanchesMac.Repositories;
using LanchesMac.ViewModels;

namespace LanchesMac.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepository _lanche;

        public HomeController (ILancheRepository lancheRepository)
        {
            _lanche = lancheRepository;
        }


        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                LanchesPreferidos = _lanche.LanchesPreferidos
            };

            return View(homeViewModel);
        }

       /* [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}

