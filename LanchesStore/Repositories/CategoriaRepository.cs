using LanchesStore.Context;
using LanchesStore.Models;
using LanchesStore.Repositories.Interfaces;

namespace LanchesStore.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
