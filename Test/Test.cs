namespace Test;
using Simulacion_de_bolillero;
public class Test
{
    public Bolillero Bolillero { get; set; }
    public Test() => Bolillero = new Bolillero(10, new Primero());

    [Fact]
    public void Test1()
    {
        Simulacion.SimularSinHilos(Bolillero, [0, 1, 2, 3], 8);
        Simulacion.SimularConHilos(Bolillero, [0, 1, 2, 3], 10, 4);
    }

    [Fact]
    public void SacarBolilla()
    {
        var bolilla = Bolillero.SacarBolilla();

        Assert.Equal(0, bolilla);
        Assert.Equal(9, Bolillero.Bolillas.Count);
        Assert.Single(Bolillero.BolillasSacadas);
    }
    [Fact]
    public void ReIngresar()
    {
        Bolillero.SacarBolilla();
        Bolillero.ReIngresar();

        Assert.Equal(10, Bolillero.Bolillas.Count);
        Assert.Empty(Bolillero.BolillasSacadas);
    }

    [Fact]
    public void JugarGana()
    {
        bool resultado = Bolillero.Jugar([0, 1, 2, 3]);
        Assert.True(resultado);
    }

    [Fact]
    public void JugarPierde()
    {
        bool perdiste = Bolillero.Jugar([4, 2, 1]);
        Assert.False(perdiste);
    }

    [Fact]
    public void GanarNVeces()
    {
        Equals(2, Bolillero.JugarNVeces(2, [0, 1, 2]));
    }
}