namespace DocumentModel;

public struct RGB
{
  public Byte R { get; set; }
  public Byte G { get; set; }
  public Byte B { get; set; }

  public static implicit operator RGB(UInt32 value) => new RGB { R = (byte)(value >> 16), G = (byte)(value >> 8), B = (byte)(value) };
  public static implicit operator UInt32(RGB value) => (UInt32)value.R << 16 | (UInt32)(value.G << 16) | value.B;
}