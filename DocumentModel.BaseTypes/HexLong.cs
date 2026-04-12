namespace DocumentModel;

/// <summary>
/// Represents a 64-bit integer value encoded as a fixed-width, uppercase hexadecimal string for use in Office Open XML documents.
/// Enables type-safe conversion between numeric values and their hexadecimal string representations, supporting scenarios such as revision IDs, unique element identifiers, ARGB color values, and bitmasks in Office documents.
/// Ensures consistent 16-character formatting, seamless .NET type integration, and efficient equality checks.
/// </summary>
[JsonConverter(typeof(HexLongJsonConverter))]
public readonly partial struct HexLong : IConvertible, IEquatable<HexLong>
{
  /// <summary>
  /// The underlying 64-bit unsigned integer value.
  /// </summary>
  private readonly UInt64 value;

  /// <summary>
  /// Initializes a new instance from a hexadecimal string.
  /// </summary>
  /// <param name="str">A hexadecimal string representing a 64-bit integer.
  ///   May begin with an optional '#' character.
  /// </param>
  public HexLong(string str)
  {
    value = UInt64.Parse(str, NumberStyles.HexNumber);
  }

  /// <summary>
  /// Initializes a new instance from a 32-bit signed integer.
  /// </summary>
  /// <param name="value">A 32-bit signed integer value.</param>
  public HexLong(int value)
  {
    this.value = (UInt64)value;
  }

  /// <summary>
  /// Initializes a new instance from a 32-bit unsigned integer.
  /// </summary>
  /// <param name="value">A 32-bit unsigned integer value.</param>
  public HexLong(uint value)
  {
    this.value = (UInt64)value;
  }

  /// <summary>
  /// Initializes a new instance from a 64-bit signed integer.
  /// </summary>
  /// <param name="value">A 64-bit signed integer value.</param>
  public HexLong(long value)
  {
    this.value = (UInt64)value;
  }

  /// <summary>
  /// Initializes a new instance from a 64-bit unsigned integer.
  /// </summary>
  /// <param name="value">A 64-bit unsigned integer value.</param>
  public HexLong(ulong value)
  {
    this.value = (UInt64)value;
  }

  #region IConvertible Implementation
  /// <summary>
  /// Returns the type code for the underlying value.
  /// </summary>
  public TypeCode GetTypeCode()
  {
    return value.GetTypeCode();
  }

  /// <summary>
  /// Converts the value to a boolean (true if nonzero).
  /// </summary>
  public bool ToBoolean(IFormatProvider? provider)
  {
    return value != 0;
  }

  /// <summary>
  /// Converts the value to a byte (truncates if necessary).
  /// </summary>
  public byte ToByte(IFormatProvider? provider)
  {
    return (byte)value;
  }

  /// <summary>
  /// Converts the value to a char.
  /// </summary>
  public char ToChar(IFormatProvider? provider)
  {
    return ((IConvertible)value).ToChar(provider);
  }

  /// <summary>
  /// Converts the value to a DateTime.
  /// </summary>
  public DateTime ToDateTime(IFormatProvider? provider)
  {
    return ((IConvertible)value).ToDateTime(provider);
  }

  /// <summary>
  /// Converts the value to a decimal.
  /// </summary>
  public decimal ToDecimal(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  /// Converts the value to a double.
  /// </summary>
  public double ToDouble(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  /// Converts the value to a 16-bit signed integer (truncates if necessary).
  /// </summary>
  public short ToInt16(IFormatProvider? provider)
  {
    return (short)value;
  }

  /// <summary>
  /// Converts the value to a 32-bit signed integer (truncates if necessary).
  /// </summary>
  public int ToInt32(IFormatProvider? provider)
  {
    return (int)value;
  }

  /// <summary>
  /// Converts the value to a 64-bit signed integer.
  /// </summary>
  public long ToInt64(IFormatProvider? provider)
  {
    return (Int64)value;
  }

  /// <summary>
  /// Converts the value to a signed byte (truncates if necessary).
  /// </summary>
  public sbyte ToSByte(IFormatProvider? provider)
  {
    return (sbyte)value;
  }

  /// <summary>
  /// Converts the value to a single-precision floating point number.
  /// </summary>
  public float ToSingle(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  /// Converts the value to a string using the specified format provider.
  /// </summary>
  public string ToString(IFormatProvider? provider)
  {
    return value.ToString(provider);
  }

  /// <summary>
  /// Converts the value to a 16-bit unsigned integer (truncates if necessary).
  /// </summary>
  public ushort ToUInt16(IFormatProvider? provider)
  {
    return (ushort)value;
  }

  /// <summary>
  /// Converts the value to a 32-bit unsigned integer (truncates if necessary).
  /// </summary>
  public UInt32 ToUInt32(IFormatProvider? provider)
  {
    return (uint)value;
  }

  /// <summary>
  /// Converts the value to a 64-bit unsigned integer.
  /// </summary>
  public ulong ToUInt64(IFormatProvider? provider)
  {
    return (ulong)value;
  }

  /// <summary>
  /// Converts the value to the specified type.
  /// </summary>
  public object ToType(Type targetType, IFormatProvider? provider)
  {
    if (targetType == typeof(UInt16))
      return value;
    if (targetType == typeof(Int64))
      return value;
    if (targetType == typeof(UInt64))
      return value;
    if (targetType == typeof(Int64))
      return value;
    if (targetType == typeof(UInt64))
      return value;
    if (targetType == typeof(Int16))
      return (short)value;
    if (targetType == typeof(Byte))
      return (byte)value;
    if (targetType == typeof(SByte))
      return (sbyte)value;
    if (targetType == typeof(Single))
      return value;
    if (targetType == typeof(Double))
      return value;
    if (targetType == typeof(Decimal))
      return value;
    if (targetType == typeof(String))
      return ToString();
    if (targetType == typeof(HexLong))
      return value;
    return ((IConvertible)value).ToType(targetType, provider);
  }

  #endregion

  #region Implicit Conversions
  /// <summary>
  /// Implicitly converts a hexadecimal string to a HexLong.
  /// </summary>
  public static implicit operator HexLong(string str)
  {
    return new HexLong(str);
  }

  /// <summary>
  /// Implicitly converts a HexLong to a 16-bit unsigned integer.
  /// </summary>
  public static implicit operator ushort(HexLong val)
  {
    return (ushort)val.value;
  }

  /// <summary>
  /// Implicitly converts a HexLong to a 32-bit unsigned integer.
  /// </summary>
  public static implicit operator uint(HexLong val)
  {
    return (uint)val.value;
  }

  /// <summary>
  /// Implicitly converts a HexLong to a 64-bit signed integer.
  /// </summary>
  public static implicit operator Int64(HexLong val)
  {
    return (Int64)val.value;
  }

  /// <summary>
  /// Implicitly converts a HexLong to a 64-bit unsigned integer.
  /// </summary>
  public static implicit operator ulong(HexLong val)
  {
    return (ulong)val.value;
  }

  /// <summary>
  /// Implicitly converts a 16-bit unsigned integer to a HexLong.
  /// </summary>
  public static implicit operator HexLong(ushort val)
  {
    return new HexLong((long)val);
  }

  /// <summary>
  /// Implicitly converts a 32-bit unsigned integer to a HexLong.
  /// </summary>
  public static implicit operator HexLong(uint val)
  {
    return new HexLong((long)val);
  }

  /// <summary>
  /// Implicitly converts a 64-bit signed integer to a HexLong.
  /// </summary>
  public static implicit operator HexLong(Int64 val)
  {
    return new HexLong((long)val);
  }

  /// <summary>
  /// Implicitly converts a 64-bit unsigned integer to a HexLong.
  /// </summary>
  public static implicit operator HexLong(UInt64 val)
  {
    return new HexLong((long)val);
  }

  /// <summary>
  /// Implicitly converts a HexLong to a HexBinary.
  /// </summary>
  public static implicit operator HexBinary(HexLong value) => new HexBinary(value.ToString(CultureInfo.InvariantCulture));

  /// <summary>
  /// Implicitly converts a HexBinary to a HexLong.
  /// </summary>
  public static implicit operator HexLong(HexBinary value) => new HexLong(value.ToString());

  #endregion
  /// <summary>
  /// Returns the 16-character uppercase hexadecimal string representation of the value.
  /// </summary>
  public override string ToString()
  {
    return value.ToString("X16");
  }

  /// <summary>
  /// Determines whether this instance is equal to another HexLong.
  /// </summary>
  public bool Equals(HexLong other)
  {
    return value == other.value;
  }

  /// <summary>
  /// Returns a hash code for this instance.
  /// </summary>
  public override int GetHashCode()
  {
    return value.GetHashCode();
  }
}