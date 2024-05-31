#region Manutenções/Implementações
/*
 * 31/05/2024 - Implementação inicial
 */
#endregion

using LanchesStore.Models;

namespace LanchesStore.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
