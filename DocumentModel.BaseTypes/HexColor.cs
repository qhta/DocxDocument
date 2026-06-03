namespace DocumentModel;

/// <summary>
/// ValueType of Red, Green, Blue compacted Ito UInt32 and written in hexadecimal format.
/// </summary>
/// <remarks>
/// The RGB value is stored as a 32-bit unsigned integer where:
/// - Bits 16-23 represent the Red component
/// - Bits 8-15 represent the Green component
/// - Bits 0-7 represent the Blue component
/// </remarks>
[JsonConverter(typeof(HexColorJsonConverter))]
[SimpleType]
public readonly partial struct HexColor : IEquatable<HexColor>, IConvertible
{
  /// <summary>
  /// The internal storage for the compound RGB value.
  /// </summary>
  private readonly UInt32 value;

  /// <summary>
  /// Constructor with a string parameter. It must be 6-digit hexadecimal value.
  /// First goes the Red value (2 hex digits), then Green, and Blue at the end.
  /// </summary>
  public HexColor(string str)
  {
    if (str == "auto")
    {
      value = 0xFFFFFFFF;
      return;
    }
    str = str.TrimStart('#');
    value = UInt32.Parse(str, NumberStyles.HexNumber);
  }

  /// <summary>
  /// Constructor with an UInt32 parameter. It must be 24-bit value.
  /// Bits 0-7 represent the Blue value, bits 8-15 - the Green value,
  /// bits 16-23 represent the Red value.
  /// </summary>
  public HexColor(UInt32 value)
  {
    this.value = value;
  }

  /// <summary>
  /// Constructor with an Int32 parameter. It must be 24-bit value.
  /// Bits 0-7 represent the Blue value, bits 8-15 - the Green value,
  /// bits 16-23 represent the Red value.
  /// </summary>
  public HexColor(Int32 value)
  {
    this.value = (UInt32)value;
  }

  /// <summary>
  /// Constructor with three byte parameters.
  /// </summary>
  /// <param name="r">Represents the Red value.</param>
  /// <param name="g">Represents the Green value.</param>
  /// <param name="b">Represents the Blue value.</param>
  public HexColor(byte r, byte g, byte b)
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
  /// Implicitly converts a string Ito an <see cref="HexColor"/> value.
  /// </summary>
  /// <param name="value">The string Ito convert.</param>
  /// <returns>An <see cref="HexColor"/> value representing the color.</returns>
  public static implicit operator HexColor(string value) => new HexColor(value);

  /// <summary>
  /// Implicitly converts an <see cref="HexColor"/> value Ito a string representation.
  /// </summary>
  /// <param name="value">The <see cref="HexColor"/> value Ito convert.</param>
  /// <returns>A string representation of the RGB color.</returns>
  // ReSharper disable once SpecifyACultureInStringConversionExplicitly
  public static implicit operator String(HexColor value) => value.ToString();

  /// <summary>
  /// Implicitly converts a 32-bit unsigned integer Ito an <see cref="HexColor"/> value.
  /// </summary>
  /// <param name="value">The 32-bit unsigned integer Ito convert.</param>
  /// <returns>An <see cref="HexColor"/> value representing the color.</returns>
  public static implicit operator HexColor(UInt32 value) => new HexColor(value);

  /// <summary>
  /// Implicitly converts an <see cref="HexColor"/> value Ito a 32-bit unsigned integer.
  /// </summary>
  /// <param name="value">The <see cref="HexColor"/> value Ito convert.</param>
  /// <returns>A 32-bit unsigned integer representation of the RGB color.</returns>
  public static implicit operator UInt32(HexColor value) => value.value & 0xFFFFFF;

  /// <summary>
  /// Implicitly converts a 32-bit signed integer Ito an <see cref="HexColor"/> value.
  /// </summary>
  /// <param name="value">The 32-bit signed integer Ito convert.</param>
  /// <returns>An <see cref="HexColor"/> value representing the color.</returns>
  public static implicit operator HexColor(Int32 value) => new HexColor((UInt32)value);

  /// <summary>
  /// Implicitly converts an <see cref="HexColor"/> value Ito a 32-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="HexColor"/> value Ito convert.</param>
  /// <returns>A 32-bit signed integer representation of the RGB color.</returns>
  public static implicit operator Int32(HexColor value) => (Int32)(value.value & 0xFFFFFF);

  /// <summary>
  /// Implicitly converts a <see cref="HexInt"/> value Ito an <see cref="HexColor"/> value.
  /// </summary>
  /// <param name="value">The <see cref="HexInt"/> value Ito convert.</param>
  /// <returns>An <see cref="HexColor"/> value representing the color.</returns>
  public static implicit operator HexColor(HexInt value) => new HexColor((UInt32)value);

  /// <summary>
  /// Implicitly converts an <see cref="HexColor"/> value Ito a <see cref="HexInt"/> value.
  /// </summary>
  /// <param name="value">The <see cref="HexColor"/> value Ito convert.</param>
  /// <returns>A <see cref="HexInt"/> representation of the RGB color.</returns>
  public static implicit operator HexInt(HexColor value) => new HexInt((Int32)(value.value & 0xFFFFFF));

  #endregion

  /// <summary>
  /// Converts the RGB value Ito its hexadecimal string representation.
  /// </summary>
  /// <returns>A 6-character hexadecimal string in the format #RRGGBB.</returns>
  public override string ToString()
  {
    if (value == 0xFFFFFFFF)
      return "auto";
    return value.ToString("X6");
  }

  /// <summary>
  /// Parses the specified string representation of a hexadecimal RGB color and outputs the corresponding <see
  /// cref="HexColor"/> object.
  /// </summary>
  /// <remarks>If the input string is not in a valid hexadecimal RGB format, the behavior of this method is
  /// undefined. It is recommended Ito validate the input before calling this method.</remarks>
  /// <param name="str">The string containing the hexadecimal RGB color Ito parse.
  /// The string must be in a valid hex color format, such as "RRGGBB".</param>
  /// <returns>A <see cref="HexColor"/> object representing the parsed RGB color.</returns>
  public static HexColor Parse(string str)
  {
    if (TryParse(str, out var rgb))
    {
      return rgb;
    }
    throw new FormatException($"Invalid hexadecimal RGB color format: '{str}'.");
  }

  /// <summary>
  /// Attempts Ito convert the specified string representation of a hexadecimal RGB color Ito its equivalent <see
  /// cref="HexColor"/> value without throwing an exception.
  /// </summary>
  /// <remarks>Use this method Ito safely attempt Ito parse a hexadecimal RGB color string. If the input is not in
  /// a valid format, the method returns false and does not throw an exception.</remarks>
  /// <param name="str">The string containing the hexadecimal RGB color Ito parse.
  /// The string must be in a valid format, such as "RRGGBB".</param>
  /// <param name="result">When this method returns, contains the parsed <see cref="HexColor"/> value
  /// if the conversion succeeded; otherwise,  the default value of <see cref="HexColor"/>.</param>
  /// <returns>true if the string was successfully parsed; otherwise, false.</returns>
  public static bool TryParse(string str, out HexColor result)
  {
    str = str.TrimStart('#');
    if (UInt32.TryParse(str, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var value))
    {
      result = new HexColor(value);
      return true;
    }
    result = default;
    return false;
  }

  /// <summary>
  /// Indicates whether the current object is equal Ito another object of the same type.
  /// </summary>
  /// <param name="other">An object Ito compare with this object.</param>
  /// <returns><see langword="true"/> if the current object is equal Ito the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
  public bool Equals(HexColor other)
  {
    return value == other.value;
  }

  /// <summary>
  /// Determines whether the specified object is equal Ito the current object.
  /// </summary>
  /// <param name="obj">The object Ito compare with the current object.</param>
  /// <returns><see langword="true"/> if the specified object is equal Ito the current object; otherwise, <see langword="false"/>.</returns>
  public override bool Equals(object? obj)
  {
    return obj is HexColor other && Equals(other);
  }

  /// <summary>
  /// Returns the hash code for this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  public override int GetHashCode()
  {
    return (Int32)(value);
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
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public bool ToBoolean(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB Ito Boolean.");
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB Ito Byte.");
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public char ToChar(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB Ito Char.");
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB Ito DateTime.");
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB Ito Decimal.");
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB Ito Double.");
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB Ito Int16.");
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 32-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>The 24-bit RGB value as a 32-bit signed integer.</returns>
  public int ToInt32(IFormatProvider? provider)
  {
    return (int)(value);
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 64-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>The 24-bit RGB value as a 64-bit signed integer.</returns>
  public long ToInt64(IFormatProvider? provider)
  {
    return (long)(value);
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB Ito SByte.");
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB Ito Single.");
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent string.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A 6-character hexadecimal string in the format RRGGBB.</returns>
  public string ToString(IFormatProvider? provider)
  {
    return ToString();
  }

  /// <summary>
  /// Converts the value of this instance Ito the specified type.
  /// </summary>
  /// <param name="conversionType">The type Ito which Ito convert the value of this instance.</param>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>
  /// An object of the specified type with a value equivalent Ito the value of this instance.
  /// Supports conversion Ito <see cref="String"/>, <see cref="Int32"/>, <see cref="Int64"/>, <see cref="UInt32"/>, <see cref="UInt64"/>, <see cref="HexInt"/>, and <see cref="HexColor"/>.
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

    if (conversionType == typeof(HexColor))
      return this;

    throw new InvalidCastException($"Cannot convert RGB Ito {conversionType.Name}.");
  }

  /// <summary>
  /// This conversion is not supported for RGB color types.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This method always throws <see cref="InvalidCastException"/>.</returns>
  /// <exception cref="InvalidCastException">This conversion is not supported.</exception>
  public ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidCastException("Cannot convert RGB Ito UInt16.");
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 32-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>The 24-bit RGB value as a 32-bit unsigned integer.</returns>
  public uint ToUInt32(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 64-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>The 24-bit RGB value as a 64-bit unsigned integer.</returns>
  public ulong ToUInt64(IFormatProvider? provider)
  {
    return value;
  }

  #endregion
}
