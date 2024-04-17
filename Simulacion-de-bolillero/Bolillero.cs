namespace Simulacion_de_bolillero;

public class Bolillero : IClonable
{
    public List<int> Bolillas { get; set; }
    public List<int> BolillasSacadas { get; set; }
    public IAzar Azar { get; set; }
    private Bolillero(Bolillero original)
    {
        Bolillas = new(original.Bolillas);
        BolillasSacadas = new(original.BolillasSacadas);
        Azar = original.Azar;
    }
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

    public long JugarNVeces(long cantidad, List<int> jugada)
    {
        long victorias = 0;
        for (long i = 0; i < cantidad; i++)
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

    public Bolillero ClonarBolillero()
        => new(this);
}