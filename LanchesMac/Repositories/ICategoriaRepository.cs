using System.Collections.Generic;
using LanchesMac.Models;
using System.Runtime.InteropServices;

namespace LanchesMac.Repositories
{

    public interface ICategoriaRepositoriy
    {
        IEnumerable<Categoria> Categorias { get; }


    }
}