namespace UOM.Test;

public class InvalidUnitsTests
{
    [Theory(DisplayName = "Testing for invalid units conversions")]
    [InlineData(10.0, "Invalid", "m")]
    [InlineData(10.0, "m", "Invalid")]
    [InlineData(10.0, "M", "m")]
    [InlineData(10.0, "m", "M")]
    public void Exception(double value, string fromUnit, string toUnit)
    {
        IPhysicalQuantity physicalQuantity = new UnitOfMeasurement().PhysicalQuantity["Length"];
        Assert.Throws<Exception>(() => physicalQuantity.Convert(value, fromUnit, toUnit));
    }
}
