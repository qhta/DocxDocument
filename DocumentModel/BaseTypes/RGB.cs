namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

[TypeConverter(typeof(RGBTypeXmlConverter))]
public struct RGB : IEquatable<RGB>
{
  public RGB(string str)
  {
    if (str == "auto")
      IsAuto = true;
    else
    {
      var value = UInt32.Parse(str, NumberStyles.HexNumber);
      R = (byte)(value >> 16);
      G = (byte)(value >> 8);
      B = (byte)(value);
    }
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

  public Byte R { get => r; set { r = value; IsAuto = false; } }
  private Byte r;
  public Byte G { get => g; set { g = value; IsAuto = false; } }
  private Byte g;
  public Byte B { get => b; set { b = value; IsAuto = false; } }
  private Byte b;

  public static implicit operator RGB(UInt32 value) => new RGB { R = (byte)(value >> 16), G = (byte)(value >> 8), B = (byte)(value) };
  public static implicit operator UInt32(RGB value) => (UInt32)value.R << 16 | (UInt32)(value.G << 8) | value.B;

  public static implicit operator RGB(Int32 value) => new RGB { R = (byte)(value >> 16), G = (byte)(value >> 8), B = (byte)(value) };
  public static implicit operator Int32(RGB value) => (Int32)value.R << 16 | (Int32)(value.G << 8) | value.B;

  public static implicit operator RGB(HexInt value) => new RGB { R = (byte)(value >> 16), G = (byte)(value >> 8), B = (byte)(value) };
  public static implicit operator HexInt(RGB value) => (UInt32)value.R << 16 | (UInt32)(value.G << 8) | value.B;

  public override string ToString()
  {
    if (IsAuto)
      return "auto";
    return R.ToString("X2") + G.ToString("X2") + B.ToString("X2");
  }

  public bool Equals(RGB other)
  {
    return (R == other.R && G == other.G && B == other.B);
  }

  public override int GetHashCode()
  {
    return (Int32)this;
  }

  public RGB()
  {
    IsAuto = true;
  }

  public bool IsAuto { get; set; }

  public readonly static RGB Auto = new RGB();

}