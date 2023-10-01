namespace UOM;

internal class Length : PhysicalQuantity
{
    public Length() : base("m", new() {
        {"m", (len => len, len => len)},
        {"dm", (len => len/10.0, len => len*10.0)},
        {"cm", (len => len/100.0, len => len*100.0)},
        {"km", (len => len*1000.0, len => len/1000.0)}
    })
    { }
}