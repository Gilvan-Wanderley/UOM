namespace UOM;

internal class Temperature : PhysicalQuantity
{
    public Temperature() : base("K", new() {
        {"K", (T => T, T => T)},
        {"C", (T => T + 273.15, T => T - 273.15)},
        {"F", (T => (T - 32.0) * 5.0 / 9.0 + 273.15, T => (T - 273.15) * 9.0 / 5.0 + 32.0)}
    })
    { }
}
