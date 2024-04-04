namespace Test;
using Simulacion_de_bolillero;
public class Test
{
    public Bolillero bolillero { get; set; }
    public Test() => bolillero = new Bolillero();

    [Fact]
    public void Test1()
    {
        bolillero.CantidadBolillas(10);
        Assert.Equal(10, bolillero.Total);
    }
}