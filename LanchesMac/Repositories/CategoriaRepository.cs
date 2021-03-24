using LanchesMac.Models;
using System.Collections.Generic;
using LanchesMac.Repositories;
using System.Runtime.InteropServices;
using LanchesMac.Context;

namespace LanchesMac.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias; //throw new System.NotImplementedException();

        public object Lanches => throw new System.NotImplementedException();
    }
}