namespace UOM.Test;
public class LengthTests : UnitsTests
{
    public LengthTests() : base("Length", 6) { }

    [Theory(DisplayName = $"{"Length"} - Testing valid conversions from default unit")]
    [InlineData(1.0, "m", 1.0, "m")]
    [InlineData(1.0, "m", 10.0, "dm")]
    [InlineData(1.0, "m", 100.0, "cm")]
    [InlineData(1.0, "m", 1000.0, "mm")]
    [InlineData(1.0, "m", 1000000.0, "um")]
    [InlineData(1.0, "m", 1000000000.0, "nm")]
    [InlineData(1.0, "m", 0.0006213689, "mile")]
    [InlineData(1.0, "m", 1.0936132983, "yd")]
    [InlineData(1.0, "m", 3.280839895, "ft")]
    [InlineData(1.0, "m", 39.37007874, "inch")]
    [InlineData(1.0, "m", 0.001, "km")]
    public override void FromDefault(double value, string fromUnit, double target, string toUnit) => AssertUnit(value, fromUnit, target, toUnit);


    [Theory(DisplayName = $"{"Length"} - Testing valid conversions to default unit")]
    [InlineData(10.0, "dm", 1.0, "m")]
    [InlineData(100.0, "cm", 1.0, "m")]
    [InlineData(1000.0, "mm", 1.0, "m")]
    [InlineData(1000000.0, "um", 1.0, "m")]
    [InlineData(1000000000.0, "nm", 1.0, "m")]
    [InlineData(0.0006213689, "mile", 1.0, "m")]
    [InlineData(1.0936132983, "yd", 1.0, "m")]
    [InlineData(3.280839895, "ft", 1.0, "m")]
    [InlineData(39.37007874, "inch", 1.0, "m")]
    [InlineData(0.001, "km", 1.0, "m")]
    public override void ToDefault(double value, string fromUnit, double target, string toUnit) => AssertUnit(value, fromUnit, target, toUnit);

}