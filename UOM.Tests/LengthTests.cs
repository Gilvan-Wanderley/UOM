namespace UOM.Test;
public class LengthTests
{
    private readonly IPhysicalQuantity length = new UnitOfMeasurement().PhysicalQuantity["Length"];

    [Theory(DisplayName = $"Testing valid conversions for {"Length"}")]
    [InlineData(10.0, "m", 10.0, "m")]
    [InlineData(10.0, "m", 100.0, "dm")]
    [InlineData(10.0, "m", 1000.0, "cm")]
    [InlineData(10.0, "m", 0.01, "km")]
    [InlineData(100.0, "dm", 10.0, "m")]
    [InlineData(1000.0, "cm", 10.0, "m")]
    [InlineData(0.01, "km", 10.0, "m")]
    [InlineData(10.0, "dm", 100.0, "cm")]
    [InlineData(100.0, "cm", 10.0, "dm")]
    [InlineData(20000.0, "dm", 2.0, "km")]
    public void Conversion(double value, string fromUnit, double target, string toUnit)
    {
        Assert.Equal(target, length.Convert(value, fromUnit, toUnit), 6);
    }
}