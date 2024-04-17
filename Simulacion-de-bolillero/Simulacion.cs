namespace Simulacion_de_bolillero;

public class Simulacion
{
    public long SimularSinHilos(Bolillero bolillero, List<int> jugada, long cantidadSimulacion)
        => bolillero.JugarNVeces(cantidadSimulacion, jugada);

    public long SimularConHilos(Bolillero bolillero, List<int> jugada, long cantidadSimulacion, long cantidadHilo)
    {
        Bolillero bolillero1 = bolillero.ClonarBolillero();
        Task<long>[] tareas = new Task<long>[cantidadHilo];

        for (int i = 0; i < cantidadHilo; i++)
        {
            tareas[i] = Task.Run(() => bolillero1.JugarNVeces(cantidadSimulacion / cantidadHilo, jugada));
        }
        Task.WaitAll(tareas);
        return tareas.Sum(t => t.Result);
    }
}