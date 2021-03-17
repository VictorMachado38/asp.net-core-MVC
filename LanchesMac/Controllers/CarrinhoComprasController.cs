using System.Runtime.InteropServices;
using LanchesMac.Controllers;
using Microsoft.AspNetCore.Mvc;
using LanchesMac.Repositories;
using LanchesMac.Models;
using LanchesMac.ViewModels;
using System.Linq;

namespace LanchesMac.Controllers
{

    public class CarrinhoComprasController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoComprasController(ILancheRepository lancheRepository, CarrinhoCompra carrinhoCompra)
        {
            _lancheRepository = lancheRepository;
            _carrinhoCompra = carrinhoCompra;
        }
        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItens = itens;

            var carrinhoCompraViewModel = new CarrinhoCompraViewModels
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()

            };

            return View(carrinhoCompraViewModel);
        }
        public RedirectToActionResult AdicionarItemNoCarrinhoCompra(int lancheId)
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(p => p.LancheId == lancheId);
            if(lancheSelecionado != null)
            {

                _carrinhoCompra.AdicionarAoCarrinho(lancheSelecionado, 1);

            }
            return RedirectToAction("Index");
        }

    }
}