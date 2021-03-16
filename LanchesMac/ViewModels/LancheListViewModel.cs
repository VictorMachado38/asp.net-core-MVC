using System.Runtime.InteropServices;
using System.Collections.Generic;
using LanchesMac.Models;
namespace LanchesMac.ViewModels
{
    public class LancheListViewModel
    {

        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }

}