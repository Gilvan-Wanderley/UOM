namespace UOM;
public class UnitOfMeasurement
{
    public UnitOfMeasurement()
    {
        PhysicalQuantity = new(){
        {"Temperature", new Temperature()},
        {"Length", new Length()}};
    }

    public IEnumerable<string> Properties => PhysicalQuantity.Keys;
    public Dictionary<string, IPhysicalQuantity> PhysicalQuantity { get; private set; }    
}
