namespace DocumentModel;

[TypeConverter(typeof(RGBTypeXmlConverter))]
public struct RGB
{
  public RGB(string str)
  {
    var value = UInt32.Parse(str, NumberStyles.HexNumber);
    R = (byte)(value >> 16);
    G = (byte)(value >> 8);
    B = (byte)(value);
  }

  public RGB(UInt32 value)
  {
    R = (byte)(value >> 16);
    G = (byte)(value >> 8);
    B = (byte)(value);
  }

  public RGB(byte r, byte g, byte b)
  {
    R = r;
    G = g;
    B = b;
  }

  public Byte R { get; set; }
  public Byte G { get; set; }
  public Byte B { get; set; }

  public static implicit operator RGB(UInt32 value) => new RGB { R = (byte)(value >> 16), G = (byte)(value >> 8), B = (byte)(value) };
  public static implicit operator UInt32(RGB value) => (UInt32)value.R << 16 | (UInt32)(value.G << 16) | value.B;

  public static implicit operator RGB(HexInt value) => new RGB { R = (byte)(value >> 16), G = (byte)(value >> 8), B = (byte)(value) };
  public static implicit operator HexInt(RGB value) => (UInt32)value.R << 16 | (UInt32)(value.G << 16) | value.B;

  //public static implicit operator RGB?(HexInt? value) => (value == null) ? (RGB?)null : new RGB { R = (byte)(value >> 16), G = (byte)(value >> 8), B = (byte)(value) };
  //public static implicit operator HexInt?(RGB? value) => (value == null) ? (HexInt?)null : ((UInt32)((RGB)value).R) << 16 | ((UInt32)((RGB)value).G) << 16 | ((UInt32)((RGB)value).B);

  public override string ToString()
  {
    return R.ToString("X2") + G.ToString("X2") + B.ToString("X2");
  }
}