using LanchesMac.Models;
using Microsoft.AspNetCore.Mvc;
using LanchesMac.ViewModels;
using System.Collections.Generic;
namespace LanchesMac.Conponents
{
    public class CarrinhoCompraResumo : ViewComponent
    {
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraResumo(CarrinhoCompra carrinhoCompra)
        {
            _carrinhoCompra = carrinhoCompra;


        }

        public IViewComponentResult Invoke()
        {
            //var itens = _carrinhoCompra.GetCarrinhoCompraItens();
            var itensAUX = new List<CarrinhoCompraItem>() { new CarrinhoCompraItem() , new CarrinhoCompraItem()};
            _carrinhoCompra.CarrinhoCompraItens = itensAUX;

            var carrinhoCompraVM = new CarrinhoCompraViewModels
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };
            return View(carrinhoCompraVM);
        }

    }
}