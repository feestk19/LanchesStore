#region Manutenções/Implementações
/*
 * 31/05/2024 - Implementação inicial
 */
#endregion

namespace LanchesStore.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
