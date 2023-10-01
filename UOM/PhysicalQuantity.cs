namespace UOM;

internal abstract class PhysicalQuantity : IPhysicalQuantity
{   
    protected string defaultUnit = string.Empty;
    protected Dictionary<string, (Func<double, double> ToDefault, Func<double, double> FromDefault)> converter = new();

    protected PhysicalQuantity(string defaultUnit, Dictionary<string, (Func<double, double> ToDefault, Func<double, double> FromDefault)> converter)
    {
        _ = converter.ContainsKey(defaultUnit) ? true : throw new Exception($"Converter doesn`t contains the default unit ({defaultUnit}).");

        this.defaultUnit = defaultUnit;
        this.converter = converter;
    }

    public string DefaultUnit => defaultUnit;
    public IEnumerable<string> Units => converter.Keys;

    public double Convert(double value, string fromUnit, string toUnit)
    {
        return ConvertFromDefault(ConvertToDefault(value, fromUnit), toUnit);
    }

    public double ConvertFromDefault(double value, string toUnit)
    {
        return defaultUnit == toUnit ? value : converter.ContainsKey(toUnit) ?
            converter[toUnit].FromDefault(value) : throw new Exception($"This is not valid unit ({toUnit})");
    }

    public double ConvertToDefault(double value, string fromUnit)
    {
        return defaultUnit == fromUnit ? value : converter.ContainsKey(fromUnit) ?
            converter[fromUnit].ToDefault(value) : throw new Exception($"This is not valid unit ({fromUnit})");
    }
}