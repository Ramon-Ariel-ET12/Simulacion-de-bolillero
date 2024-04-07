namespace Simulacion_de_bolillero;

public class Bolillero
{
    public List<int> Bolillas { get; set; }
    public List<int> BolillasSacadas { get; set; }
    public IAzar azar { get; set; }
    public Bolillero(int cantidad) => (Bolillas, BolillasSacadas, azar) = (CantidadBolillas(cantidad), new List<int>(), new Aleatorio());

    private List<int> CantidadBolillas(int cantidad)
    {
        List<int> ints = new List<int>();
        for (var i = 0; i < cantidad; i++) ints.Add(i);
        return ints;
    }
    public void Jugar(int bolilla)
    {
        int random = azar.Aleatoinator(this);
        if (bolilla == random)
        {
            Bolillas.Remove(bolilla);
            BolillasSacadas.Add(bolilla);
            throw new ArgumentException("Ganaste, felicidades shinji");
        }
        else
        {
            Bolillas.Remove(bolilla);
            BolillasSacadas.Add(bolilla);
            throw new ArgumentException("Perdiste, felicidades shinji");
        }	
    }
}