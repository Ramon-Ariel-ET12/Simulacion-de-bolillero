namespace Simulacion_de_bolillero;

public class Aleatorio : IAzar
{
    public int Aleatoinator(Bolillero bolillero)
    {
        Random rnd = new(DateTime.Now.Millisecond);
        int indiceAzar = rnd.Next(0, bolillero.Bolillas.Count);
        int random = bolillero.Bolillas[indiceAzar]; //elije el numero de casillero (Alcance tiene el numero de casillero) de la lista que ah sacado un valor aleatoriamente (se que no hace falta, ya que va a ser los mismos valores, pero es bueno saber xd)
        return random;
    }
}