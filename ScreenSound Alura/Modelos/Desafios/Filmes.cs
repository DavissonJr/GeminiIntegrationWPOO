
namespace Alura.Filmes;

public class Filme
{
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public List<Artista> Elenco { get; set; }

    public Filme(string titulo, int duracao)
    {
        Titulo = titulo;
        Duracao = duracao;
        Elenco = new List<Artista>();
    }

    public void AdicionarArtista(Artista artista)
    {
        Elenco.Add(artista);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Duração: {Duracao} minutos");
        Console.WriteLine("Elenco:");
        foreach (var artista in Elenco)
        {
            Console.WriteLine($"- {artista.Nome} ({artista.Idade} anos)");
        }
    }
}