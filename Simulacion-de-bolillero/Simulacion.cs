namespace Simulacion_de_bolillero;

public class Simulacion : IClonable
{
    public Bolillero copiaBolillero { get; set; }
    public Simulacion(Bolillero bolillero)
        => (copiaBolillero.Bolillas, copiaBolillero.BolillasSacadas, bolillero.Azar) = (ClonarBolillas(bolillero), ClonarBolillasSacadas(bolillero), new FluentAleatorio());

    public List<int> ClonarBolillas(Bolillero bolillero)
         => new(bolillero.Bolillas);

    public List<int> ClonarBolillasSacadas(Bolillero bolillero)
     => new(bolillero.BolillasSacadas);

// recibe por parámetro un bolillero, una jugada y cantidad de simulaciones a efectuar, el método devuelve la cantidad de veces que resultó ganadora la jugada.
    public long SimularSinHilos(Simulacion simulacion, long jugada, long cantidadSimulacion)
    {
        //print("hola world")
        return 0;
    }

    public long SimularConHilos()
    {
        return 0;
    }
}