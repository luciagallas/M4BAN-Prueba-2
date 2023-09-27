namespace BusinessLogic.Test;

[TestClass]
public class CalculatorTest
{
    [TestMethod]
    public void NewCalculatorTest()
    {
        // Arrange
        var calculator = new CostCalculator();
        var baldosas = new List<Baldosa>();
        var precioPorMetroCuadrado = 10.0;

        // Act
        var costoTotal = calculator.CalcularCostoTotal(baldosas, precioPorMetroCuadrado);

        // Assert
        Assert.AreEqual(0.0, costoTotal);
    }

    [TestMethod]
    public void CalcularCostoTotal_DebeCalcularCostoCorrectamente()
    {
        // Arrange
        var calculator = new CostCalculator();
        var baldosas = new List<Baldosa>
        {
            new Baldosa { Tipo = "Cuadrada", Lado = 2, Material = "Cemento" },
            new Baldosa { Tipo = "Circular", Lado = 4, Material = "Ladrillo" },
        };
        double precioPorMetroCuadrado = 10.0;

        // Act
        double costoTotal = calculator.CalcularCostoTotal(baldosas, precioPorMetroCuadrado);

        // Assert
        Assert.AreEqual(274.1592653589793, costoTotal, 0.0001); 
    }
}

