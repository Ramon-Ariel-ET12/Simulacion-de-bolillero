namespace Simulacion_de_bolillero;

public class Bolillero
{
    public List<int> Bolillas { get; set; }
    public List<int> BolillasSacadas { get; set; }
    public IAzar azar { get; set; }
    public Bolillero(int cantidad) => (Bolillas, BolillasSacadas, azar) = (CantidadBolillas(cantidad), new(), new Aleatorio());

    private List<int> CantidadBolillas(int cantidad)
    {
        List<int> ints = new();
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

    public void SacarBolilla(int bolilla)
    {
        if (Bolillas.Contains(bolilla))
        {
            Bolillas.Remove(bolilla);
            BolillasSacadas.Add(bolilla);
        }
        else
        {
            throw new InvalidOperationException($"La bolilla numero '{bolilla}' no existe");
        }
    }
    public void ReIngresar()
    {
        foreach (var item in BolillasSacadas)
        {
            Bolillas.Add(item);
        }
        BolillasSacadas.RemoveAll(x => true);
        Bolillas.Sort();
    }

    public void VictoriaAsegurada(int bolilla)
    {
        int victoria = azar.Aleatoinator(this);
        while(bolilla != victoria)
        {
            victoria = azar.Aleatoinator(this);
        }
        BolillasSacadas.Add(bolilla);
        Bolillas.Remove(bolilla);
        throw new ArgumentException("Ganaste, felicidades shinji");
    }
    
    public void DerrotaAsegurada(int bolilla)
    {
        int derrota = azar.Aleatoinator(this);
        while (bolilla == derrota)
        {
            derrota = azar.Aleatoinator(this);
        }
        BolillasSacadas.Add(bolilla);
        Bolillas.Remove(bolilla);
        throw new ArgumentException("Perdiste, felicidades shinji");
    }

}