﻿namespace ScreenSound.Api.Requests
{
    public record MusicaRequestEdit(int id, string nome, int artistaId, int anoLancamento) : MusicaRequest(nome, artistaId, anoLancamento);
}
