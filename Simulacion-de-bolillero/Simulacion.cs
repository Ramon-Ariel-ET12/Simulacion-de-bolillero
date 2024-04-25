namespace Simulacion_de_bolillero;

public class Simulacion
{
    public static long SimularSinHilos(Bolillero bolillero, List<int> jugada, long cantidadSimulacion)
        => bolillero.JugarNVeces(cantidadSimulacion, jugada);

    public static long SimularConHilos(Bolillero bolillero, List<int> jugada, long cantidadSimulacion, long cantidadHilo)
    {
        Bolillero bolillero1 = bolillero.ClonarBolillero();
        Task<long>[] tareas = new Task<long>[cantidadHilo];
        long resto = cantidadSimulacion%cantidadHilo;
        for (long i = 0; i < resto; i++)
        {
            tareas[i] = Task.Run(() => bolillero1.JugarNVeces(cantidadSimulacion / cantidadHilo, jugada));
        }
        for (long i = resto; i < cantidadHilo; i++)
        {
            tareas[i] = Task.Run(() => bolillero1.JugarNVeces(cantidadSimulacion / cantidadHilo, jugada));
        }

        Task.WaitAll(tareas);
        return tareas.Sum(t => t.Result);
    }
    public static async Task<long> SimularConHilosAsync(Bolillero bolillero, List<int> jugada, long cantidadSimulacion, long cantidadHilo)
    {
        Task<long>[] tareas = new Task<long>[cantidadHilo];
        long resto = cantidadSimulacion % cantidadHilo;
        for (long i = 0; i < resto; i++)
            tareas[i] = GenerarTask(bolillero, jugada,cantidadSimulacion / cantidadHilo + 1);
        for (long i = resto; i < cantidadHilo; i++)
            tareas[i] = GenerarTask(bolillero, jugada,cantidadSimulacion / cantidadHilo);

        await Task.WhenAll(tareas);
        return tareas.Sum(t => t.Result);
    }

    private static Task<long> GenerarTask(Bolillero original, List<int> jugada, long cantidad)
    {
        var clon = original.ClonarBolillero();
        return Task<long>.Run(() => clon.JugarNVeces(cantidad, jugada));
    }
}