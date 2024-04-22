namespace Simulacion_de_bolillero;

public class Simulacion
{
    public static long SimularSinHilos(Bolillero bolillero, List<int> jugada, long cantidadSimulacion)
        => bolillero.JugarNVeces(cantidadSimulacion, jugada);

    public static long SimularConHilos(Bolillero bolillero, List<int> jugada, long cantidadSimulacion, long cantidadHilo)
    {
        Bolillero bolillero1 = bolillero.ClonarBolillero();
        Task<long>[] tareas = new Task<long>[cantidadHilo];
        long hilosDivididos = cantidadSimulacion / cantidadHilo + cantidadSimulacion % cantidadHilo;
        for (int i = 0; i < cantidadHilo*2; i++)
        {
            tareas[i] = Task.Run(() => bolillero1.JugarNVeces(hilosDivididos, jugada));
        }

        Task.WaitAll(tareas);
        return tareas.Sum(t => t.Result);
    }
}