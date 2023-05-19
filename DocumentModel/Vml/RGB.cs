namespace DocumentModel;

/// <summary>
/// Type of Red, Green, Blue compacted to UInt32
/// </summary>
[TypeConverter(typeof(RGBTypeXmlConverter))]
public struct RGB : IEquatable<RGB>
{
  /// <summary>
  /// Constructor with a string parameter. It must be 6-digit hexadecimal value.
  /// First goes the Red value (2 hex digits), then Green, and Blue at the end.
  /// </summary>
  public RGB(string str)
  {
      var value = UInt32.Parse(str, NumberStyles.HexNumber);
      R = (byte)(value >> 16);
      G = (byte)(value >> 8);
      B = (byte)(value);
  }

  /// <summary>
  /// Constructor with an UInt32 parameter. It must be 24-bit value.
  /// Bits 0-7 represent the Blue value, bits 8-16 - the Green value,
  /// bits 12-24 represent the Red value.
  /// </summary>
  public RGB(UInt32 value)
  {
    R = (byte)(value >> 16);
    G = (byte)(value >> 8);
    B = (byte)(value);
  }

  /// <summary>
  /// Constructor with three byte parameters.
  /// </summary>
  /// <param name="r">Represents the Red value.</param>
  /// <param name="g">Represents the Green value.</param>
  /// <param name="b">Represents the Blue value.</param>
  public RGB(byte r, byte g, byte b)
  {
    R = r;
    G = g;
    B = b;
  }

  /// <summary>
  /// Red component of the color.
  /// </summary>
  public Byte R { get; set; }

  /// <summary>
  /// Green component of the color.
  /// </summary>
  public Byte G { get; set; }

  /// <summary>
  /// Blue component of the color.
  /// </summary>
  public Byte B { get; set; }


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public static implicit operator RGB(UInt32 value) => new RGB { R = (byte)(value >> 16), G = (byte)(value >> 8), B = (byte)(value) };
  public static implicit operator UInt32(RGB value) => (UInt32)value.R << 16 | (UInt32)(value.G << 8) | value.B;

  public static implicit operator RGB(Int32 value) => new RGB { R = (byte)(value >> 16), G = (byte)(value >> 8), B = (byte)(value) };
  public static implicit operator Int32(RGB value) => (Int32)value.R << 16 | (Int32)(value.G << 8) | value.B;

  public static implicit operator RGB(HexInt value) => new RGB { R = (byte)(value >> 16), G = (byte)(value >> 8), B = (byte)(value) };
  public static implicit operator HexInt(RGB value) => (UInt32)value.R << 16 | (UInt32)(value.G << 8) | value.B;

  public override string ToString()
  {
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

}