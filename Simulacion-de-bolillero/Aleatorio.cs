namespace Simulacion_de_bolillero;

public class Aleatorio : IAzar
{
    public int Aleatorinator(Bolillero bolillero)
    {
    Random rnd = new Random();
    int Alcance = rnd.Next(bolillero.Bolillas.Count);
    int random = bolillero.Bolillas[Alcance];
    return random;
    }
}