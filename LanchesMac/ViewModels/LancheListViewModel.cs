using System.Runtime.InteropServices;
using System.Collections.Generic;
using LanchesMac.Models;
namespace LanchesMac.ViewModels
{
    public class LancheListViewModel
    {
        internal IEnumerable<Lanche> lanches;

        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }

}