namespace DocumentModel;

/// <summary>
///   Represents a 64-bit integer value encoded as an 8-character hexadecimal string for use in Office Open XML documents.
/// </summary>
/// <remarks>
///   <para>
///   HexLong provides a type-safe wrapper for integer values that are represented as hexadecimal strings
///   in Office Open XML documents. It stores a 64-bit signed integer value (-2,147,483,648 to 2,147,483,647)
///   that is formatted as an 8-character uppercase hexadecimal string.
///   </para>
///   <para>
///   This type is commonly used in Office documents for:
///   <list type="bullet">
///   <item><description>Document revision identifiers and version numbers</description></item>
///   <item><description>Unique element identifiers within document structures</description></item>
///   <item><description>Hash values and checksums for content verification</description></item>
///   <item><description>Color values in ARGB format (when representing 64-bit color codes)</description></item>
///   <item><description>Binary flags and bitmasks in document properties</description></item>
///   </list>
///   </para>
///   <para>
///   HexLong values are always formatted as 8-character uppercase hexadecimal strings (e.g., "0000007B" for 123,
///   "FFFFFFFF" for -1). This fixed-width format ensures consistent representation across all Office Open XML
///   documents and simplifies parsing and comparison operations.
///   </para>
///   <para>
///   The struct implements <see cref="IConvertible"/> for seamless integration with .NET type conversion
///   and <see cref="IEquatable{T}"/> for efficient equality comparisons. It provides implicit conversions
///   between HexLong and common numeric types (ushort, uint, int, ulong) as well as bidirectional conversion
///   with <see cref="HexBinary"/> for interoperability.
///   </para>
///   <para>
///   <b>Office Availability:</b> Hexadecimal integer encoding is supported across all Office Open XML
///   formats including Word, Excel, and PowerPoint documents (Office 2007 and later).
///   </para>
/// </remarks>
[JsonConverter(typeof(HexLongJsonConverter))]
public readonly partial struct HexLong : IConvertible, IEquatable<HexLong>
{
  private readonly Int64 value;

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexLong"/> struct from a hexadecimal string.
  /// </summary>
  /// <param name="val">
  ///   A hexadecimal string containing up to 16 hex digits (0-9, A-F, a-f) representing a 64-bit integer.
  /// </param>
  /// <remarks>
  ///   <para>
  ///   The string is parsed as a hexadecimal number to obtain the integer value.
  ///   Leading zeros are optional. Valid input examples: "7B" (123), "FFFFFFFF" (-1), "00000001" (1).
  ///   </para>
  /// </remarks>
  /// <exception cref="FormatException">
  ///   Thrown when the string is not a valid hexadecimal number.
  /// </exception>
  /// <exception cref="OverflowException">
  ///   Thrown when the parsed value exceeds the range of a 64-bit signed integer.
  /// </exception>
  public HexLong(string val)
  {
    value = Int64.Parse(val, NumberStyles.HexNumber);
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexLong"/> struct from a 64-bit signed integer.
  /// </summary>
  /// <param name="value">
  ///   A 64-bit signed integer value (-2,147,483,648 to 2,147,483,647).
  /// </param>
  /// <remarks>
  ///   This is the primary constructor that directly stores the integer value.
  ///   Example: new HexLong(123) stores value 123 (0x0000007B).
  /// </remarks>
  public HexLong(int value)
  {
    this.value = (long)value;
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexLong"/> struct from a 64-bit unsigned integer.
  /// </summary>
  /// <param name="value">
  ///   A 64-bit unsigned integer value (0 to 4,294,967,295).
  /// </param>
  /// <remarks>
  ///   Values greater than 2,147,483,647 will be interpreted as negative numbers when cast to signed int.
  ///   Example: new HexLong(0xFFFFFFFF) results in -1.
  /// </remarks>
  public HexLong(uint value)
  {
    this.value = (long)value;
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexLong"/> struct from a 64-bit signed integer.
  /// </summary>
  /// <param name="value">
  ///   A 64-bit unsigned integer value. Only the lower 64 bits are used.
  /// </param>
  /// <remarks>
  ///   The value is truncated to 64 bits. Values exceeding the int64 range will wrap around.
  ///   Example: new HexLong(0x100000001UL) results in 1.
  /// </remarks>
  public HexLong(long value)
  {
    this.value = (long)value;
  }

  #region IConvertible Implementation
  /// <summary>
  ///   Returns the <see cref="TypeCode"/> for the underlying value type.
  /// </summary>
  /// <returns>
  ///   <see cref="TypeCode.Int64"/>, indicating the underlying storage type.
  /// </returns>
  public TypeCode GetTypeCode()
  {
    return value.GetTypeCode();
  }

  /// <summary>
  ///   Converts the HexLong value to a Boolean value.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   <see langword="true"/> if the integer value is non-zero; otherwise <see langword="false"/>.
  /// </returns>
  public bool ToBoolean(IFormatProvider? provider)
  {
    return value != 0;
  }

  /// <summary>
  ///   Converts the HexLong value to a byte.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A byte representing the lower 8 bits of the integer value.
  /// </returns>
  /// <remarks>
  ///   Values outside the range 0-255 will be truncated to their lower 8 bits.
  /// </remarks>
  public byte ToByte(IFormatProvider? provider)
  {
    return (byte)value;
  }

  /// <summary>
  ///   Converts the HexLong value to a character.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> for culture-specific formatting.</param>
  /// <returns>
  ///   A character corresponding to the Unicode code point represented by the integer value.
  /// </returns>
  public char ToChar(IFormatProvider? provider)
  {
    return ((IConvertible)value).ToChar(provider);
  }

  /// <summary>
  ///   Converts the HexLong value to a DateTime.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> for culture-specific formatting.</param>
  /// <returns>
  ///   A DateTime value (delegates to the underlying int conversion).
  /// </returns>
  /// <exception cref="InvalidCastException">
  ///   This conversion is not supported and will typically throw an exception.
  /// </exception>
  public DateTime ToDateTime(IFormatProvider? provider)
  {
    return ((IConvertible)value).ToDateTime(provider);
  }

  /// <summary>
  ///   Converts the HexLong value to a decimal.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A decimal value representing the integer.
  /// </returns>
  public decimal ToDecimal(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  ///   Converts the HexLong value to a double-precision floating-point number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A double value representing the integer.
  /// </returns>
  public double ToDouble(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  ///   Converts the HexLong value to a 16-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A 16-bit signed integer. Values outside the range -64,768 to 64,767 will be truncated.
  /// </returns>
  public short ToInt16(IFormatProvider? provider)
  {
    return (short)value;
  }

  /// <summary>
  ///   Converts the HexLong value to a 32-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   The underlying 64-bit signed integer value.
  /// </returns>
  public int ToInt32(IFormatProvider? provider)
  {
    return (int)value;
  }

  /// <summary>
  ///   Converts the HexLong value to a 64-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A 64-bit signed integer representing the same value.
  /// </returns>
  public long ToInt64(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  ///   Converts the HexLong value to a signed byte.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A signed byte. Values outside the range -128 to 127 will be truncated.
  /// </returns>
  public sbyte ToSByte(IFormatProvider? provider)
  {
    return (sbyte)value;
  }

  /// <summary>
  ///   Converts the HexLong value to a single-precision floating-point number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A float value representing the integer.
  /// </returns>
  public float ToSingle(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  ///   Converts the HexLong value to a string using the specified format provider.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> for culture-specific formatting.</param>
  /// <returns>
  ///   A decimal string representation of the underlying integer value (not hexadecimal).
  /// </returns>
  /// <remarks>
  ///   This method returns the decimal string representation of the integer.
  ///   For hexadecimal string representation, use <see cref="ToString()"/>.
  /// </remarks>
  public string ToString(IFormatProvider? provider)
  {
    return value.ToString(provider);
  }

  /// <summary>
  ///   Converts the HexLong value to a 16-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A 16-bit unsigned integer. Negative values and values exceeding 65535 will be truncated.
  /// </returns>
  public ushort ToUInt16(IFormatProvider? provider)
  {
    return (ushort)value;
  }

  /// <summary>
  ///   Converts the HexLong value to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A 64-bit unsigned integer. Negative values are reinterpreted as unsigned (e.g., -1 becomes 4,294,967,295).
  /// </returns>
  public UInt32 ToUInt32(IFormatProvider? provider)
  {
    return (uint)value;
  }

  /// <summary>
  ///   Converts the HexLong value to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A 64-bit unsigned integer. Negative values are reinterpreted as unsigned.
  /// </returns>
  public ulong ToUInt64(IFormatProvider? provider)
  {
    return (ulong)value;
  }

  /// <summary>
  ///   Converts the HexLong value to the specified target type.
  /// </summary>
  /// <param name="targetType">The type to convert to.</param>
  /// <param name="provider">An <see cref="IFormatProvider"/> for culture-specific formatting.</param>
  /// <returns>
  ///   An object of the specified target type.
  /// </returns>
  /// <remarks>
  ///   <para>
  ///   This method provides explicit conversions to common numeric types and string:
  ///   <list type="bullet">
  ///   <item><description>UInt16, Int64, UInt64, Int64, UInt64: Numeric conversions</description></item>
  ///   <item><description>Int16, Byte, SByte: Conversions with potential truncation</description></item>
  ///   <item><description>Single, Double, Decimal: Floating-point conversions</description></item>
  ///   <item><description>String: Hexadecimal string representation (8 characters)</description></item>
  ///   <item><description>HexLong: Creates a new HexLong with the same value</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  /// <exception cref="InvalidCastException">
  ///   Thrown when conversion to the target type is not supported.
  /// </exception>
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
      return new HexLong(value);
    return ((IConvertible)value).ToType(targetType, provider);
  }

  #endregion

  #region Implicit Conversions
  /// <summary>
  ///   Implicitly converts a hexadecimal string to a HexLong.
  /// </summary>
  /// <param name="val">A hexadecimal string (up to 8 hex digits).</param>
  /// <returns>A HexLong representing the parsed integer value.</returns>
  /// <remarks>
  ///   Example: HexLong i = "7B"; // represents 123
  /// </remarks>
  public static implicit operator HexLong(string val)
  {
    return new HexLong(val);
  }

  /// <summary>
  ///   Implicitly converts a HexLong to a 16-bit unsigned integer.
  /// </summary>
  /// <param name="val">A HexLong value.</param>
  /// <returns>The lower 16 bits as a ushort.</returns>
  public static implicit operator ushort(HexLong val)
  {
    return (ushort)val.value;
  }

  /// <summary>
  ///   Implicitly converts a HexLong to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="val">A HexLong value.</param>
  /// <returns>The value reinterpreted as a uint.</returns>
  public static implicit operator uint(HexLong val)
  {
    return (uint)val.value;
  }

  /// <summary>
  ///   Implicitly converts a HexLong to a 64-bit signed integer.
  /// </summary>
  /// <param name="val">A HexLong value.</param>
  /// <returns>The underlying int64 value.</returns>
  public static implicit operator Int64(HexLong val)
  {
    return val.value;
  }

  /// <summary>
  ///   Implicitly converts a HexLong to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="val">A HexLong value.</param>
  /// <returns>The value as a ulong.</returns>
  public static implicit operator ulong(HexLong val)
  {
    return (ulong)val.value;
  }

  /// <summary>
  ///   Implicitly converts a 16-bit unsigned integer to a HexLong.
  /// </summary>
  /// <param name="val">A ushort value (0 to 65,535).</param>
  /// <returns>A HexLong representing the value.</returns>
  public static implicit operator HexLong(ushort val)
  {
    return new HexLong((long)val);
  }

  /// <summary>
  ///   Implicitly converts a 64-bit unsigned integer to a HexLong.
  /// </summary>
  /// <param name="val">A uint value (0 to 4,294,967,295).</param>
  /// <returns>A HexLong representing the value.</returns>
  public static implicit operator HexLong(uint val)
  {
    return new HexLong((long)val);
  }

  /// <summary>
  ///   Implicitly converts a 64-bit signed integer to a HexLong.
  /// </summary>
  /// <param name="val">An int value (-2,147,483,648 to 2,147,483,647).</param>
  /// <returns>A HexLong representing the value.</returns>
  public static implicit operator HexLong(Int64 val)
  {
    return new HexLong((long)val);
  }

  /// <summary>
  ///   Implicitly converts a 64-bit unsigned integer to a HexLong.
  /// </summary>
  /// <param name="val">A ulong value. Only the lower 64 bits are used.</param>
  /// <returns>A HexLong representing the truncated value.</returns>
  public static implicit operator HexLong(UInt64 val)
  {
    return new HexLong((long)val);
  }

  /// <summary>
  ///   Implicitly converts a HexLong to a HexBinary.
  /// </summary>
  /// <param name="value">A HexLong value.</param>
  /// <returns>A HexBinary containing the 8-character hexadecimal representation.</returns>
  /// <remarks>
  ///   Example: HexLong(123) converts to HexBinary("0000007B").
  /// </remarks>
  public static implicit operator HexBinary(HexLong value) => new HexBinary(value.ToString());

  /// <summary>
  ///   Implicitly converts a HexBinary to a HexLong.
  /// </summary>
  /// <param name="value">A HexBinary value containing a hexadecimal string.</param>
  /// <returns>A HexLong parsed from the hexadecimal string.</returns>
  /// <remarks>
  ///   Example: HexBinary("0000007B") converts to HexLong(123).
  /// </remarks>
  public static implicit operator HexLong(HexBinary value) => new HexLong(value.ToString());

  #endregion
  /// <summary>
  ///   Converts this HexLong to its at least 8-character uppercase hexadecimal string representation.
  /// </summary>
  /// <returns>
  ///   An 8-character hexadecimal string with leading zeros (e.g., "0000007B", "FFFFFFFF").
  /// </returns>
  /// <remarks>
  ///   <para>
  ///   Examples:
  ///   <list type="bullet">
  ///   <item><description>value 0 → "00000000"</description></item>
  ///   <item><description>value 123 (0x7B) → "0000007B"</description></item>
  ///   <item><description>value -1 (0xFFFFFFFF) → "FFFFFFFF"</description></item>
  ///   <item><description>value 2,147,483,647 → "7FFFFFFF"</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  public override string ToString()
  {
    return value.ToString("X8");
  }

  /// <summary>
  ///   Determines whether this HexLong is equal to another HexLong.
  /// </summary>
  /// <param name="other">The HexLong to compare with this instance.</param>
  /// <returns>
  ///   <see langword="true"/> if the integer values are equal; otherwise <see langword="false"/>.
  /// </returns>
  public bool Equals(HexLong other)
  {
    return value == other.value;
  }

  /// <summary>
  ///   Returns a hash code for this HexLong.
  /// </summary>
  /// <returns>
  ///   A 64-bit signed integer hash code equal to the underlying integer value.
  /// </returns>
  public override int GetHashCode()
  {
    return value.GetHashCode();
  }
}