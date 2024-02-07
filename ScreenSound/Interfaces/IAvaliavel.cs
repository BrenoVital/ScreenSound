using ScreenSound.Modelos;

namespace ScreenSound.Interfaces
{
    internal interface IAvaliavel
    {
        void AdicionarNota(Avaliacao nota);
        double Media { get; }
    }
}
