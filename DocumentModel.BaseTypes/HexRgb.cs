namespace DocumentModel;

/// <summary>
/// ValueType of Red, Green, Blue compacted to UInt32 and written in hexadecimal format.
/// </summary>
/// <remarks>
/// The RGB value is stored as a 32-bit unsigned integer where:
/// - Bits 16-23 represent the Red component
/// - Bits 8-15 represent the Green component
/// - Bits 0-7 represent the Blue component
/// </remarks>
[JsonConverter(typeof(HexRgbJsonConverter))]
[SimpleType]
public readonly partial struct HexRgb : IEquatable<HexRgb>, IConvertible
{
  /// <summary>
  /// The internal storage for the compound RGB value.
  /// </summary>
  private readonly UInt32 value;

  /// <summary>
  /// Constructor with a string parameter. It must be 6-digit hexadecimal value.
  /// First goes the Red value (2 hex digits), then Green, and Blue at the end.
  /// </summary>
  public HexRgb(string str)
  {
    value = UInt32.Parse(str, NumberStyles.HexNumber);
  }

  /// <summary>
  /// Constructor with an UInt32 parameter. It must be 24-bit value.
  /// Bits 0-7 represent the Blue value, bits 8-15 - the Green value,
  /// bits 16-23 represent the Red value.
  /// </summary>
  public HexRgb(UInt32 value)
  {
    this.value = value & 0xFFFFFF; // Mask to ensure only 24 bits are used
  }

  /// <summary>
  /// Constructor with an Int32 parameter. It must be 24-bit value.
  /// Bits 0-7 represent the Blue value, bits 8-15 - the Green value,
  /// bits 16-23 represent the Red value.
  /// </summary>
  public HexRgb(Int32 value)
  {
    this.value = (UInt32)(value & 0xFFFFFF); // Mask to ensure only 24 bits are used
  }

  /// <summary>
  /// Constructor with three byte parameters.
  /// </summary>
  /// <param name="r">Represents the Red value.</param>
  /// <param name="g">Represents the Green value.</param>
  /// <param name="b">Represents the Blue value.</param>
  public HexRgb(byte r, byte g, byte b)
  {
    value = ((UInt32)r << 16) | ((UInt32)g << 8) | b;
  }

  /// <summary>
  /// Red component of the color.
  /// </summary>
  public Byte R
  {
    get => (byte)(value >> 16);
    set => System.Runtime.CompilerServices.Unsafe.AsRef(in this.value) = (this.value & 0x00FFFF) | ((UInt32)value << 16);
  }

  /// <summary>
  /// Green component of the color.
  /// </summary>
  public Byte G
  {
    get => (byte)(value >> 8);
    set => System.Runtime.CompilerServices.Unsafe.AsRef(in this.value) = (this.value & 0xFF00FF) | ((UInt32)value << 8);
  }

  /// <summary>
  /// Blue component of the color.
  /// </summary>
  public Byte B
  {
    get => (byte)value;
    set => System.Runtime.CompilerServices.Unsafe.AsRef(in this.value) = (this.value & 0xFFFF00) | value;
  }

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a 32-bit unsigned integer to an <see cref="HexRgb"/> value.
  /// </summary>
  /// <param name="value">The 32-bit unsigned integer to convert.</param>
  /// <returns>An <see cref="HexRgb"/> value representing the color.</returns>
  public static implicit operator HexRgb(UInt32 value) => new HexRgb(value);

  /// <summary>
  /// Implicitly converts an <see cref="HexRgb"/> value to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="value">The <see cref="HexRgb"/> value to convert.</param>
  /// <returns>A 32-bit unsigned integer representation of the RGB color.</returns>
  public static implicit operator UInt32(HexRgb value) => value.value & 0xFFFFFF;

  /// <summary>
  /// Implicitly converts a 32-bit signed integer to an <see cref="HexRgb"/> value.
  /// </summary>
  /// <param name="value">The 32-bit signed integer to convert.</param>
  /// <returns>An <see cref="HexRgb"/> value representing the color.</returns>
  public static implicit operator HexRgb(Int32 value) => new HexRgb((UInt32)value);

  /// <summary>
  /// Implicitly converts an <see cref="HexRgb"/> value to a 32-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="HexRgb"/> value to convert.</param>
  /// <returns>A 32-bit signed integer representation of the RGB color.</returns>
  public static implicit operator Int32(HexRgb value) => (Int32)(value.value & 0xFFFFFF);

  /// <summary>
  /// Implicitly converts a <see cref="HexInt"/> value to an <see cref="HexRgb"/> value.
  /// </summary>
  /// <param name="value">The <see cref="HexInt"/> value to convert.</param>
  /// <returns>An <see cref="HexRgb"/> value representing the color.</returns>
  public static implicit operator HexRgb(HexInt value) => new HexRgb((UInt32)value);

  /// <summary>
  /// Implicitly converts an <see cref="HexRgb"/> value to a <see cref="HexInt"/> value.
  /// </summary>
  /// <param name="value">The <see cref="HexRgb"/> value to convert.</param>
  /// <returns>A <see cref="HexInt"/> representation of the RGB color.</returns>
  public static implicit operator HexInt(HexRgb value) => new HexInt((Int32)(value.value & 0xFFFFFF));

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
  public bool Equals(HexRgb other)
  {
    return value == other.value;
  }

  /// <summary>
  /// Determines whether the specified object is equal to the current object.
  /// </summary>
  /// <param name="obj">The object to compare with the current object.</param>
  /// <returns><see langword="true"/> if the specified object is equal to the current object; otherwise, <see langword="false"/>.</returns>
  public override bool Equals(object? obj)
  {
    return obj is HexRgb other && Equals(other);
  }

  /// <summary>
  /// Returns the hash code for this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  public override int GetHashCode()
  {
    return (Int32)(value & 0xFFFFFF);
  }

  #region IConvertible Implementation

  /// <summary>
  /// Returns the <see cref="TypeCode"/> for this instance.
  /// </summary>
  /// <returns><see cref="TypeCode.Object"/> as this is a color structure.</returns>
  public TypeCode GetTypeCode()
  {
    return TypeCode.Object;
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public bool ToBoolean(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB to Boolean.");
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB to Byte.");
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public char ToChar(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB to Char.");
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB to DateTime.");
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB to Decimal.");
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB to Double.");
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB to Int16.");
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 32-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>The 24-bit RGB value as a 32-bit signed integer.</returns>
  public int ToInt32(IFormatProvider? provider)
  {
    return (int)(value & 0xFFFFFF);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 64-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>The 24-bit RGB value as a 64-bit signed integer.</returns>
  public long ToInt64(IFormatProvider? provider)
  {
    return (long)(value & 0xFFFFFF);
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB to SByte.");
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB to Single.");
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent string.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 6-character hexadecimal string in the format RRGGBB.</returns>
  public string ToString(IFormatProvider? provider)
  {
    return ToString();
  }

  /// <summary>
  /// Converts the value of this instance to the specified type.
  /// </summary>
  /// <param name="conversionType">The type to which to convert the value of this instance.</param>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>
  /// An object of the specified type with a value equivalent to the value of this instance.
  /// Supports conversion to <see cref="String"/>, <see cref="Int32"/>, <see cref="Int64"/>, <see cref="UInt32"/>, <see cref="UInt64"/>, <see cref="HexInt"/>, and <see cref="HexRgb"/>.
  /// </returns>
  /// <exception cref="InvalidCastException">This conversion is not supported for the specified type.</exception>
  public object ToType(Type conversionType, IFormatProvider? provider)
  {
    if (conversionType == typeof(string))
      return ToString(provider);

    if (conversionType == typeof(int))
      return ToInt32(provider);

    if (conversionType == typeof(long))
      return ToInt64(provider);

    if (conversionType == typeof(uint))
      return ToUInt32(provider);

    if (conversionType == typeof(ulong))
      return ToUInt64(provider);

    if (conversionType == typeof(HexInt))
      return (HexInt)this;

    if (conversionType == typeof(HexRgb))
      return this;

    throw new InvalidCastException($"Cannot convert RGB to {conversionType.Name}.");
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB to UInt16.");
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 32-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>The 24-bit RGB value as a 32-bit unsigned integer.</returns>
  public uint ToUInt32(IFormatProvider? provider)
  {
    return value & 0xFFFFFF;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 64-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>The 24-bit RGB value as a 64-bit unsigned integer.</returns>
  public ulong ToUInt64(IFormatProvider? provider)
  {
    return (ulong)(value & 0xFFFFFF);
  }

  #endregion
}