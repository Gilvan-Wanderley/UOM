namespace UOM.Test;

public class TemperatureTests
{
    private readonly IPhysicalQuantity temperature = new UnitOfMeasurement().PhysicalQuantity["Temperature"];

    [Theory(DisplayName = $"Testing valid conversions for {"Temperature"}")]
    [InlineData(273.15, "K", 273.15, "K")]
    [InlineData(273.15, "K", 0.0, "C")]
    [InlineData(273.15, "K", 32.0, "F")]
    [InlineData(0.0, "C", 273.15, "K")]
    [InlineData(32.0, "F", 273.15, "K")]
    [InlineData(32.0, "F", 0.0, "C")]
    public void Conversion(double value, string fromUnit, double target, string toUnit)
    {
        Assert.Equal(target, temperature.Convert(value, fromUnit, toUnit), 6);
    }
}
