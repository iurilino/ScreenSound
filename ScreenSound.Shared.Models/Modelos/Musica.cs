﻿using ScreenSound.Shared.Models.Modelos;

namespace ScreenSound.Modelos;

public class Musica
{
    public Musica(string nome)
    {
        Nome = nome;
    }

    public Musica(string nome, int artistaId, int anoLancamento)
    {
        Nome = nome;
        ArtistaId = artistaId;
        AnoLancamento = anoLancamento;
    }

    public int ArtistaId { get; set; }
    public string Nome { get; set; }
    public int Id { get; set; }
    public int? AnoLancamento { get; set; }
    public virtual Artista? Artista { get; set; }
    public virtual ICollection<Genero> Generos { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
      
    }

    public override string ToString()
    {
        return @$"Id: {Id}
        Nome: {Nome}";
    }
}