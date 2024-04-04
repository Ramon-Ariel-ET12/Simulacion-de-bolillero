namespace Simulacion_de_bolillero;

public class Bolillero
{
    public int Total { get; set; }
    public List<int> Bolillas { get; set; }
    public Bolillero() => (Total, Bolillas) = (0, new List<int>());

    public void CantidadBolillas(int cantidad)
    {
        for (var i = 0; i < cantidad; i++) Bolillas.Add(i);
        Total = Bolillas.Count;
    }
}
