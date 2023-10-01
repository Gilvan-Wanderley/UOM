namespace UOM;

public interface IPhysicalQuantity
{
    string DefaultUnit {get;}
    IEnumerable<string> Units {get;}

    double Convert(double value, string fromUnit, string toUnit);
    double ConvertToDefault(double value, string fromUnit);
    double ConvertFromDefault(double value, string toUnit);
}
