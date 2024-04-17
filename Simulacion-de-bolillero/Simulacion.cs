namespace Simulacion_de_bolillero;

public class Simulacion : IClonable
{
    public Bolillero copiaBolillero { get; set; }
    public Simulacion(Bolillero bolillero)
        => (copiaBolillero.Bolillas, copiaBolillero.BolillasSacadas, bolillero.Azar)
        = (ClonarBolillas(bolillero), ClonarBolillasSacadas(bolillero), new FluentAleatorio());

    public List<int> ClonarBolillas(Bolillero bolillero)
        => new(bolillero.Bolillas);

    public List<int> ClonarBolillasSacadas(Bolillero bolillero)
    => new(bolillero.BolillasSacadas);

    public static long SimularSinHilos(Bolillero bolillero, List<int> jugada, long cantidadSimulacion)
        => bolillero.JugarNVeces(cantidadSimulacion, jugada);

    public static long SimularConHilos(Bolillero bolillero, List<int> jugada, long cantidadSimulacion, long cantidadHilo)
    {
        Simulacion simulacion = new(bolillero);
        Task<long>[] tareas = new Task<long>[cantidadHilo];
        long victorias = 0;
        Task.WaitAll(tareas);

        for (int i = 0; i < cantidadHilo; i++)
        {
            tareas[i] = Task.Run(() => bolillero.JugarNVeces(cantidadSimulacion / cantidadHilo, jugada));
        }
        foreach (var item in tareas)
        {
            victorias = +item.Result;
        }
        return victorias;
    }
}
