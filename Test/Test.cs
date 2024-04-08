namespace Test;
using Simulacion_de_bolillero;
public class Test
{
    public Bolillero bolillero { get; set; }
    public Test() => bolillero = new Bolillero(10, new Primero());
    [Fact]
    public void Test1()
    {
        Assert.Equal(10, bolillero.Bolillas.Count);
    }

    [Fact]
    public void SacarBolilla()
    {
        var bolilla = bolillero.SacarBolilla();

        Assert.Equal(0, bolilla);
        Assert.Equal(9, bolillero.Bolillas.Count);
        Assert.Single(bolillero.BolillasSacadas);
    }
    [Fact]
    public void ReIngresar()
    {
        bolillero.SacarBolilla();
        bolillero.ReIngresar();

        Assert.Equal(10, bolillero.Bolillas.Count);
        Assert.Empty(bolillero.BolillasSacadas);
    }

    [Fact]
    public void JugarGana()
    {
        bool resultado = bolillero.Jugar([0, 1, 2, 3]);
        Assert.True(resultado);
    }

    [Fact]
    public void JugarPierde()
    {
        bool perdiste = bolillero.Jugar([4, 2, 1]);
        Assert.False(perdiste);
    }

    [Fact]
    public void GanarNVeces()
    {
        Equals(2, bolillero.JugarNVeces(2, [0, 1, 2]));
    }
}