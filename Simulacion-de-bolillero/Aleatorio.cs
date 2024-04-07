namespace Simulacion_de_bolillero;

public class Aleatorio : IAzar
{
    public int Aleatoinator(Bolillero bolillero)
    {
        Random rnd = new Random();
        int Alcance = rnd.Next(0, bolillero.Bolillas.Count);
        int random = bolillero.Bolillas[Alcance]; //elije el numero de casillero (Alcance tiene el numero de casillero) de la lista que ah sacado un valor aleatoriamente (se que no hace falta, ya que va a ser los mismos valores, pero es bueno saber xd)
        return random;
    }
}