using System.Collections.Generic;
using LanchesMac.Models;
using System.Runtime.InteropServices;

namespace LanchesMac.Repositories
{

    public interface ICategoriaRepository 
    {
        IEnumerable<Categoria> Categorias { get; }
        object Lanches { get; }
    }
}