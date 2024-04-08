namespace Simulacion_de_bolillero;

public class Bolillero
{
    public List<int> Bolillas { get; set; }
    public List<int> BolillasSacadas { get; set; }
    public IAzar Azar { get; set; }
    public Bolillero(int cantidad) : this(cantidad, new Aleatorio()) { }
    public Bolillero(int cantidad, IAzar azar)
        => (Bolillas, BolillasSacadas, Azar) = (GenerarBolillas(cantidad), [], azar);

    private List<int> GenerarBolillas(int cantidad)
    {
        List<int> ints = [];
        for (var i = 0; i < cantidad; ints.Add(i++)) ;
        return ints;
    }
    public bool Jugar(List<int> jugada)
    {
        foreach (var bolilla in jugada)
        {
            int bolillaSeleccionada = SacarBolilla();
            if (bolilla != bolillaSeleccionada)
                return false;
        }
        return true;
    }

    public int JugarNVeces(int cantidad, List<int> jugada)
    {
        int victorias = 0;
        for (int i = 0; i < cantidad; i++)
        {
            ReIngresar();
            if (Jugar(jugada))
                victorias++;
        }
        return victorias;
    }

    public int SacarBolilla()
    {
        var bolilla = Azar.Aleatoinator(this);
        Bolillas.Remove(bolilla);
        BolillasSacadas.Add(bolilla);
        return bolilla;
    }
    public void ReIngresar()
    {
        Bolillas.AddRange(BolillasSacadas);
        BolillasSacadas.Clear();
        Bolillas.Sort();
    }
}