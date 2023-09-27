namespace BusinessLogic.Test;

[TestClass]
public class CalculatorTest
{
    [TestMethod]
    public void NewCalculatorTest()
    {
        var calculator = new CostCalculator();
        var baldosas = new List<Baldosa>();
        var precioPorMetroCuadrado = 10.0;
        var costoTotal = calculator.CalcularCostoTotal(baldosas, precioPorMetroCuadrado);
        Assert.AreEqual(0.0, costoTotal);
    }
}

