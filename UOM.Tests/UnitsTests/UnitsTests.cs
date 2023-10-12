namespace UOM.Test;

public abstract class UnitsTests
{
    protected UnitsTests(string unitName, int precision)
    {
        UnitName = unitName;
        Unit = new UnitOfMeasurement().PhysicalQuantity[unitName];
        Precision = precision;
    }

    public int Precision {get; private set;}
    public string UnitName { get; }
    public IPhysicalQuantity Unit { get; }

    public abstract void FromDefault(double value, string fromUnit, double target, string toUnit);
    public abstract void ToDefault(double value, string fromUnit, double target, string toUnit);

    public void AssertUnit(double value, string fromUnit, double target, string toUnit)
    {
        Assert.Equal(target, Unit.Convert(value, fromUnit, toUnit), Precision);
    }

}
