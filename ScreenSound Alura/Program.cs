#region Screen Sound

using ScreenSound.Alura.Modelos;
using ScreenSound.Modelos;
using ScreenSound_Alura;
using ScreenSound_Alura.Menus;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Gemini gemini = new Gemini();

        Banda legiaoUrbana = new("Legião Urbana");
        legiaoUrbana.AdicionarNota(new Avaliacao(10));
        legiaoUrbana.AdicionarNota(new Avaliacao(10));
        legiaoUrbana.AdicionarNota(new Avaliacao(10));

        Banda beatles = new("The Beatles");

        Dictionary<string, Banda> bandasRegistradas = new();
        bandasRegistradas.Add(legiaoUrbana.Nome, legiaoUrbana);
        bandasRegistradas.Add(beatles.Nome, beatles);

        Dictionary<int, Menu> opcoes = new();
        opcoes.Add(1, new MenuRegistrarBanda());
        opcoes.Add(2, new MenuRegistrarAlbum());
        opcoes.Add(3, new MenuBandasRegistradas());
        opcoes.Add(4, new MenuAvaliarBanda());
        opcoes.Add(5, new MenuAvaliarAlbum());
        opcoes.Add(6, new MenuExibirDetalhes());
        opcoes.Add(-1, new MenuSair());

        void ExibirLogo()
        {
            Console.WriteLine(@"

        ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
        ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
        ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
        ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
        ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
        ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
        ");
            Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
        }

        void ExibirOpcoesDoMenu()
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para mostrar todas as bandas");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 para avaliar um álbum");
            Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
            {
                Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
                menuASerExibido.Executar(bandasRegistradas);
                if (opcaoEscolhidaNumerica > 0) { ExibirOpcoesDoMenu(); }
            }
            else
            {
                Console.WriteLine("Opção Inválida.");
            }


        }

        ExibirOpcoesDoMenu();
    }
}


#endregion


//#region Desafio Filmes

//List<Filme> filmes = new();
//List<Artista> artistas = new();

//void DesafioFilmes()
//{
//    while (true)
//    {
//        Console.WriteLine("Lista de Filmes");
//        Console.WriteLine("Escolha uma das opções: ");
//        Console.WriteLine("\n1. Adicionar filme\n2. Adicionar elenco ao filme\n3. Exibir todos os filmes\n4. Exibir todos os artistas\n5. Sair");
//        int opcao = int.Parse(Console.ReadLine());
//        switch (opcao)
//        {
//            case 1:
//                AdicionarFilme();
//                break;
//            case 2:
//                AdicionarArtistaAoElenco();
//                break;
//            case 3:
//                ExibirTodosOsFilmes();
//                break;
//            case 4:
//                ExibirTodosOsArtistas();
//                break;
//            case 5:
//                Console.WriteLine("Saindo...");
//                return;
//            default:
//                Console.WriteLine("Opção inválida");
//                break;
//        }
//    }
//}

//void AdicionarFilme()
//{
//    Console.Write("Digite o título do filme: ");
//    string titulo = Console.ReadLine();
//    Console.Write("Digite a duração do filme (em minutos): ");
//    int duracao = int.Parse(Console.ReadLine());
//    Filme filme = new(titulo, duracao);
//    filmes.Add(filme);
//    Console.WriteLine($"Filme '{titulo}' adicionado com sucesso!");
//}

//void AdicionarArtistaAoElenco()
//{
//    Console.Write("Digite o nome do artista: ");
//    string nomeArtista = Console.ReadLine();
//    Console.Write("Digite a idade do artista: ");
//    int idadeArtista = int.Parse(Console.ReadLine());
//    Artista artista = new(nomeArtista, idadeArtista, new List<Filme>());
//    artistas.Add(artista);

//    Console.Write("Digite o título do filme ao qual deseja adicionar o artista: ");
//    string tituloFilme = Console.ReadLine();
//    Filme filme = filmes.Find(f => f.Titulo == tituloFilme);
//    if (filme != null)
//    {
//        filme.AdicionarArtista(artista);
//        artista.AdicionarFilme(filme);
//        Console.WriteLine($"Artista '{nomeArtista}' adicionado ao filme '{tituloFilme}' com sucesso!");
//    }
//    else
//    {
//        Console.WriteLine($"Filme '{tituloFilme}' não encontrado!");
//    }
//}

//void ExibirTodosOsFilmes()
//{
//    Console.WriteLine("Filmes cadastrados:");
//    foreach (var filme in filmes)
//    {
//        filme.ExibirDetalhes();
//        Console.WriteLine();
//    }
//}

//void ExibirTodosOsArtistas()
//{
//    Console.WriteLine("Artistas cadastrados:");
//    foreach (var artista in artistas)
//    {
//        artista.ExibirDetalhes();
//        Console.WriteLine();
//    }
//}

//DesafioFilmes();
//#endregion