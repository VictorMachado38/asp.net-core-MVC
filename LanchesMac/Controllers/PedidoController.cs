using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using LanchesMac.Repositories;
using LanchesMac.Models;
using Newtonsoft.Json;

namespace LanchesMac.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoController(IPedidoRepository pedidoRepository, CarrinhoCompra carrinhoCompra)
        {
            _pedidoRepository = pedidoRepository;
            _carrinhoCompra = carrinhoCompra;

        }
         public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Pedido pedido)
        {


            decimal precoTotalPedido = 0.0m;
            int totalItemPedido = 0;


            var itens = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItens = itens;
            if (_carrinhoCompra.CarrinhoCompraItens.Count == 0)
            {
                ModelState.AddModelError("", "SEU CARRINHO ESTA VAZIO");
            }

            foreach(var calculo in itens)
            {
                totalItemPedido += calculo.Quantidade;
                precoTotalPedido += (calculo.Lanche.Preco * calculo.Quantidade);
            }
            //pedido.PedidoTotal = precoTotal
            if(ModelState.IsValid)
            {
                _pedidoRepository.CriarPedido(pedido);
               // _carrinhoCompra.LimparCarrinho();

                TempData["Cliente"] = pedido.Nome;
               // TempData["Clietne"] = JsonConvert.SerializeObject(pedido.Nome);
                TempData["NumeroPedido"] = pedido.PedidoId;
                TempData["Quantidade"] = totalItemPedido.ToString();
                TempData["DataPedido"] = pedido.PedidoEnviado;
                TempData["TotalPedido"] = precoTotalPedido.ToString();

                _carrinhoCompra.LimparCarrinho();
                return RedirectToAction("CheckoutCompleto");
               
            }
            return View(pedido);
        }

        public IActionResult CheckoutCompleto()
        {
                ViewBag.Cliente = TempData["Cliente"]; 
                
                ViewBag.NumeroPedido = TempData["NumeroPedido"];
                ViewBag.DataPedido = TempData["DataPedido"];
                ViewBag.TotalPedido = TempData["TotalPedido"];
            ViewBag.Quantidade = TempData["Quantidade"];
                ViewBag.CheckoutCompletoMensagem = "VALEU AEEEE, Já Já VOCE VAI ESTAR COMENDO";
            return View();
        }
    }
}