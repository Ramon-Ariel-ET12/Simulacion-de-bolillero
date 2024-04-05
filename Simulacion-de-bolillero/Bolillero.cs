namespace Simulacion_de_bolillero;

public class Bolillero
{
    public int Total { get; set; }
    public List<int> Bolillas { get; set; }
    public IAzar azar { get; set; }
    public Bolillero() => (Total, Bolillas, azar) = (0, new List<int>(), new Aleatorio());

    public void CantidadBolillas(int cantidad)
    {
        for (var i = 0; i < cantidad; i++) Bolillas.Add(i);
        Total = Bolillas.Count;
    }
    public int SacarBolilla() => azar.Aleatorinator(this);
}