using ScreenSound.Alura.Modelos;

namespace ScreenSound_Alura.Menus
{
    internal class MenuExibirDetalhes : Menu
    {
        // override subscreve uma classe -> virtual pra aceitar ser subscrito
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Gemini gemini = new Gemini();
            //a palavara base, vai executar o que ta no metodo no meno e nessa condicao que escrevemos
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Exibir detalhes da banda");
            Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");

                // Chama o método assíncrono e aguarda sua conclusão
                var resumo = gemini.RespostaAPI(banda).GetAwaiter().GetResult();

                Console.WriteLine($"\nResumo: {resumo}");
                Console.WriteLine("\nDiscografia: ");

                foreach (Album album in banda.Albuns)
                {
                    Console.WriteLine($"{album.Nome} -> {album.Media}");
                }

                Console.WriteLine("Digite uma tecla para votar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
