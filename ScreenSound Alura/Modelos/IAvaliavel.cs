using ScreenSound.Alura.Modelos;
using ScreenSound.Modelos;

namespace ScreenSound_Alura.Modelos
{
    internal interface IAvaliavel
    {
        void AdicionarNota(Avaliacao nota);
        void AdicionarAlbum(Album album);

        double Media { get; }
    }
}
