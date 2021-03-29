using LanchesMac.Models;
using System.Runtime.InteropServices;

namespace LanchesMac.Repositories
{

    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
       
    }

} 