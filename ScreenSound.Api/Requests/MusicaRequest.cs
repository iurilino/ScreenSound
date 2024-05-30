using System.ComponentModel.DataAnnotations;

namespace ScreenSound.Api.Requests
{
    public record MusicaRequest([Required] string nome, [Required] int artistaId, int anoLancamento);
}
