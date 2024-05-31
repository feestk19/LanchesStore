#region Manutenções/Implementações
/*
 * 31/05/2024 - Implementação inicial
 */
#endregion

using LanchesStore.Models;

namespace LanchesStore.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
