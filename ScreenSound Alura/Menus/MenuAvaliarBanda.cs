using ScreenSound.Alura.Modelos;
using ScreenSound.Modelos;

namespace ScreenSound_Alura.Menus
{

    // menu avaliar banda é um menu, ou seja, vai ter acesso a tudo que tá no menu, por isso a herança (se atentar na visibilidade)
    internal class MenuAvaliarBanda : Menu
    {
       
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Avaliar banda");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");

                //parse metodo estatico => adicionar funcoes dentro de um tipo

                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                banda.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
                Thread.Sleep(2000);
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
