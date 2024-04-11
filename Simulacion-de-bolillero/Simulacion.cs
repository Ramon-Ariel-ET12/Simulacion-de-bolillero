namespace Simulacion_de_bolillero;

public class Simulacion
{
    public Bolillero copiaBolillero { get; set; }
    public Simulacion(Bolillero bolillero)
        => copiaBolillero = bolillero;
}