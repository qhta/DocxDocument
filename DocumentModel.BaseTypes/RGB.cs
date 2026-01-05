namespace DocumentModel;

/// <summary>
/// Type of Red, Green, Blue compacted to UInt32
/// </summary>
/// <remarks>
/// The RGB value is stored as a 32-bit unsigned integer where:
/// - Bits 16-23 represent the Red component
/// - Bits 8-15 represent the Green component
/// - Bits 0-7 represent the Blue component
/// </remarks>
[JsonConverter(typeof(RGBJsonConverter))]
public partial struct RGB : IEquatable<RGB>
{
  /// <summary>
  /// The internal storage for the compound RGB value.
  /// </summary>
  private UInt32 value;

  /// <summary>
  /// Constructor with a string parameter. It must be 6-digit hexadecimal value.
  /// First goes the Red value (2 hex digits), then Green, and Blue at the end.
  /// </summary>
  public RGB(string str)
  {
    value = UInt32.Parse(str, NumberStyles.HexNumber);
  }

  /// <summary>
  /// Constructor with an UInt32 parameter. It must be 24-bit value.
  /// Bits 0-7 represent the Blue value, bits 8-15 - the Green value,
  /// bits 16-23 represent the Red value.
  /// </summary>
  public RGB(UInt32 value)
  {
    this.value = value & 0xFFFFFF; // Mask to ensure only 24 bits are used
  }

  /// <summary>
  /// Constructor with an UInt32 parameter. It must be 24-bit value.
  /// Bits 0-7 represent the Blue value, bits 8-15 - the Green value,
  /// bits 16-23 represent the Red value.
  /// </summary>
  public RGB(Int32 value)
  {
    this.value = (UInt32)(value & 0xFFFFFF); // Mask to ensure only 24 bits are used
  }

  /// <summary>
  /// Constructor with three byte parameters.
  /// </summary>
  /// <param name="r">Represents the Red value.</param>
  /// <param name="g">Represents the Green value.</param>
  /// <param name="b">Represents the Blue value.</param>
  public RGB(byte r, byte g, byte b)
  {
    value = ((UInt32)r << 16) | ((UInt32)g << 8) | b;
  }

  /// <summary>
  /// Red component of the color.
  /// </summary>
  public Byte R
  {
    get => (byte)(value >> 16);
    set => this.value = (this.value & 0x00FFFF) | ((UInt32)value << 16);
  }

  /// <summary>
  /// Green component of the color.
  /// </summary>
  public Byte G
  {
    get => (byte)(value >> 8);
    set => this.value = (this.value & 0xFF00FF) | ((UInt32)value << 8);
  }

  /// <summary>
  /// Blue component of the color.
  /// </summary>
  public Byte B
  {
    get => (byte)value;
    set => this.value = (this.value & 0xFFFF00) | value;
  }

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a 32-bit unsigned integer to an <see cref="RGB"/> value.
  /// </summary>
  /// <param name="value">The 32-bit unsigned integer to convert.</param>
  /// <returns>An <see cref="RGB"/> value representing the color.</returns>
  public static implicit operator RGB(UInt32 value) => new RGB(value);

  /// <summary>
  /// Implicitly converts an <see cref="RGB"/> value to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="value">The <see cref="RGB"/> value to convert.</param>
  /// <returns>A 32-bit unsigned integer representation of the RGB color.</returns>
  public static implicit operator UInt32(RGB value) => value.value & 0xFFFFFF;

  /// <summary>
  /// Implicitly converts a 32-bit signed integer to an <see cref="RGB"/> value.
  /// </summary>
  /// <param name="value">The 32-bit signed integer to convert.</param>
  /// <returns>An <see cref="RGB"/> value representing the color.</returns>
  public static implicit operator RGB(Int32 value) => new RGB((UInt32)value);

  /// <summary>
  /// Implicitly converts an <see cref="RGB"/> value to a 32-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="RGB"/> value to convert.</param>
  /// <returns>A 32-bit signed integer representation of the RGB color.</returns>
  public static implicit operator Int32(RGB value) => (Int32)(value.value & 0xFFFFFF);

  /// <summary>
  /// Implicitly converts a <see cref="HexInt"/> value to an <see cref="RGB"/> value.
  /// </summary>
  /// <param name="value">The <see cref="HexInt"/> value to convert.</param>
  /// <returns>An <see cref="RGB"/> value representing the color.</returns>
  public static implicit operator RGB(HexInt value) => new RGB((UInt32)value);

  /// <summary>
  /// Implicitly converts an <see cref="RGB"/> value to a <see cref="HexInt"/> value.
  /// </summary>
  /// <param name="value">The <see cref="RGB"/> value to convert.</param>
  /// <returns>A <see cref="HexInt"/> representation of the RGB color.</returns>
  public static implicit operator HexInt(RGB value) => new HexInt((Int32)(value.value & 0xFFFFFF));

  #endregion

  /// <summary>
  /// Converts the RGB value to its hexadecimal string representation.
  /// </summary>
  /// <returns>A 6-character hexadecimal string in the format RRGGBB.</returns>
  public override string ToString()
  {
    return R.ToString("X2") + G.ToString("X2") + B.ToString("X2");
  }

  /// <summary>
  /// Indicates whether the current object is equal to another object of the same type.
  /// </summary>
  /// <param name="other">An object to compare with this object.</param>
  /// <returns><see langword="true"/> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
  public bool Equals(RGB other)
  {
    return value == other.value;
  }

  /// <summary>
  /// Returns the hash code for this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  public override int GetHashCode()
  {
    return (Int32)(value & 0xFFFFFF);
  }
}