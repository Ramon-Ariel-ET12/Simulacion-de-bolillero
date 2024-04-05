namespace Test;
using Simulacion_de_bolillero;
public class Test
{
    [Fact]
    public void Test1()
    {
        var bolillero = new Bolillero();
        bolillero.CantidadBolillas(9);
        Assert.Equal(9, bolillero.Total);
    }

    [Fact]
    public void SacarBolilla()
    {
        var bolillero = new Bolillero();
        bolillero.CantidadBolillas(10);
        int variable = bolillero.SacarBolilla();
        

#pragma warning disable xUnit2002 // Do not use null check on value type
        Assert.NotNull(variable);
#pragma warning restore xUnit2002 // Do not use null check on value type
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