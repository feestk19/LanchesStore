#region Manutenções/Implementações
/*
 * 31/05/2024 - Implementação inicial
 */
#endregion

using LanchesStore.Models;

namespace LanchesStore.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheById(int lancheId);
    }
}
