namespace Alura.Filmes;

public class Artista
{
    public Artista(string nome, int idade, List<Filme> filmes)
    {
        Nome = nome;
        Idade = idade;
        Filmes = filmes;
    }

    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Filme> Filmes { get; set; }

    public void AdicionarFilme(Filme filme)
    {
        Filmes.Add(filme);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade} anos");
        Console.WriteLine("Filmes:");
        foreach (var filme in Filmes)
        {
            Console.WriteLine($"- {filme.Titulo}");
        }
    }
}
