namespace Simulacion_de_bolillero;

public interface IClonable
{
    List<int> ClonarBolillas(Bolillero bolillero);
    List<int> ClonarBolillasSacadas(Bolillero bolillero);
}