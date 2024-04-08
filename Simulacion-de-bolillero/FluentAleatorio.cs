namespace Simulacion_de_bolillero;

public class FluentAleatorio : IAzar
{
    public int Aleatoinator(Bolillero bolillero)
        => FluentRandomPicker.Out.Of()
            .Values(bolillero.Bolillas)
            .PickOne();
}