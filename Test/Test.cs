namespace Test;
using Simulacion_de_bolillero;
public class Test
{
    public Bolillero bolillero { get; set; }
    public Test() => bolillero = new Bolillero(10);
    [Fact]
    public void Test1()
    {
        Assert.Equal(10, bolillero.Bolillas.Count);
    }

    [Fact]
    public void SacarBolilla()
    {
        bolillero.SacarBolilla(0);

        Assert.Equal(9, bolillero.Bolillas.Count);
        Assert.Single(bolillero.BolillasSacadas);
    }
    [Fact]
    public void ReIngresar()
    {
        bolillero.SacarBolilla(0);
        bolillero.ReIngresar();

        Assert.Equal(10, bolillero.Bolillas.Count);
        Assert.Empty(bolillero.BolillasSacadas);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void JugarGana(int bolilla)
    {
        var ex = Assert.Throws<ArgumentException>(() => bolillero.VictoriaAsegurada(bolilla));
        Assert.Equal("Ganaste, felicidades shinji", ex.Message);
    }

    [Theory]
    [InlineData(4)]
    [InlineData(2)]
    [InlineData(1)]
    public void JugarPierde(int bolilla)
    {
        var ex = Assert.Throws<ArgumentException>(() => bolillero.DerrotaAsegurada(bolilla));
        Assert.Equal("Perdiste, felicidades shinji", ex.Message);
    }

    [Fact]
    public void GanarNVeces()
    {

    }
}