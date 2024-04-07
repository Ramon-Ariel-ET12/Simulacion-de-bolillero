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
        var ex = Assert.Throws<ArgumentException>(() => bolillero.Jugar(0));
        if ("Ganaste, felicidades shinji" == ex.Message)
        {
            Assert.Equal("Ganaste, felicidades shinji", ex.Message);
        }
        else
        {
            Assert.Equal("Perdiste, felicidades shinji", ex.Message);
        }
    }
    [Fact]
    public void ReIngresar()
    {

    }
    [Fact]
    public void JugarGana()
    {

    }
    [Fact]
    public void GanarNVeces()
    {
        
    }
}