namespace UOM;

internal class Length : PhysicalQuantity
{
    public Length() : base("m", new() {
        {"m", (len => len, len => len)},
        {"dm", (len => len*0.1, len => len/0.1)},
        {"cm", (len => len*0.01, len => len/0.01)},
        {"mm", (len => len*0.001, len => len/0.001)},
        {"um", (len => len*0.000001, len => len/0.000001)},
        {"nm", (len => len*1e-9, len => len/1e-9)},
        {"mile", (len => len*1609.35, len => len/1609.35)},
        {"yd", (len => len*0.9144, len => len/0.9144)},
        {"ft", (len => len*0.3048, len => len/0.3048)},
        {"inch", (len => len*0.0254, len => len/0.0254)},
        {"km", (len => len*1000.0, len => len/1000.0)}
    })
    { }
}