using ScreenSound.Modelos;
using ScreenSound_Alura.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScreenSound.Alura.Modelos;

public class Banda : IAvaliavel
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; } // Mantido como somente leitura
    public double Media
    {
        get
        {
            if (notas.Count == 0)
            {
                return 0;
            }
            else return notas.Average(n => n.Nota);
        }
    }

    // Retorna uma lista de somente leitura
    public IReadOnlyList<Album> Albuns => albuns.AsReadOnly();

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}