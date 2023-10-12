namespace UOM.Test;

public class TemperatureTests : UnitsTests
{
    public TemperatureTests() : base("Temperature", 6) { }

    [Theory(DisplayName = $"{"Temperature"} - Testing valid conversions from default unit")]
    [InlineData(273.15, "K", 273.15, "K")]
    [InlineData(273.15, "K", 0.0, "C")]
    [InlineData(273.15, "K", 32.0, "F")]
    public override void FromDefault(double value, string fromUnit, double target, string toUnit) => AssertUnit(value, fromUnit, target, toUnit);

    [Theory(DisplayName = $"{"Temperature"} - Testing valid conversions to default unit")]
    [InlineData(0.0, "C", 273.15, "K")]
    [InlineData(32.0, "F", 273.15, "K")]
    public override void ToDefault(double value, string fromUnit, double target, string toUnit) => AssertUnit(value, fromUnit, target, toUnit);

}
