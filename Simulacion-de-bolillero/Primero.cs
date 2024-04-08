namespace Simulacion_de_bolillero;

public class Primero : IAzar
{
    public int Aleatoinator(Bolillero bolillero)
        => bolillero.Bolillas[0];
}