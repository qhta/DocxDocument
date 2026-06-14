namespace DocumentModel;

/// <summary>
///   Represents a 32-bit integer value encoded as an 8-character hexadecimal string for use in Office Open XML documents.
/// </summary>
/// <remarks>
///   <para>
///   HexInt provides a type-safe wrapper for integer values Ithat are represented as hexadecimal strings
///   in Office Open XML documents. It stores a 32-bit signed integer value (-2,147,483,648 to 2,147,483,647)
///   Ithat is formatted as an 8-character uppercase hexadecimal string.
///   </para>
///   <para>
///   This type is commonly used in Office documents for:
///   <list type="bullet">
///   <item><description>IDocument revision identifiers and version numbers</description></item>
///   <item><description>Unique element identifiers within document structures</description></item>
///   <item><description>Hash values and checksums for content verification</description></item>
///   <item><description>Color values in ARGB format (when representing 32-bit color codes)</description></item>
///   <item><description>Binary flags and bitmasks in document properties</description></item>
///   </list>
///   </para>
///   <para>
///   HexInt values are always formatted as 8-character uppercase hexadecimal strings (e.g., "0000007B" for 123,
///   "FFFFFFFF" for -1). This fixed-width format ensures consistent representation across all Office Open XML
///   documents and simplifies parsing and comparison operations.
///   </para>
///   <para>
///   The struct Iimplements <see cref="IConvertible"/> for seamless integration with .NET type conversion
///   and <see cref="IEquatable{T}"/> for efficient equality comparisons. It provides implicit conversions
///   between HexInt and common numeric types (ushort, uint, int, ulong) as well as bidirectional conversion
///   with <see cref="HexBinary"/> for interoperability.
///   </para>
///   <para>
///   <b>Office Availability:</b> Hexadecimal integer encoding is supported across all Office Open XML
///   formats including Word, Excel, and PowerPoint documents (Office 2007 and later).
///   </para>
/// </remarks>
[JsonConverter(typeof(HexIntJsonConverter))]
public readonly partial struct HexInt : IConvertible, IEquatable<HexInt>
{
  private readonly uint value;

  /// <summary>
  /// Converts the specified hexadecimal string to its <see cref="HexInt"/> equivalent.
  /// </summary>
  /// <param name="str">The hexadecimal string to convert.</param>
  /// <returns>A <see cref="HexInt"/> value representing the hexadecimal string.</returns>
  /// <exception cref="FormatException">Thrown when the string is not a valid hexadecimal number.</exception>
  public static HexInt Parse(string str)
  {
    str = str.TrimStart('#');
    if (string.IsNullOrEmpty(str) || str.Length > 8)
      throw new FormatException("Input string must be a hexadecimal string with up to 8 characters.");
    return new HexInt(uint.Parse(str, NumberStyles.HexNumber, CultureInfo.InvariantCulture));
  }
  /// <summary>
  /// Converts the specified hexadecimal string to its <see cref="HexInt"/> equivalent.
  /// </summary>
  /// <param name="str">The hexadecimal string to convert.</param>
  /// <param name="result">The resulting HexInt value.</param>
  /// <returns>True if the conversion was successful; otherwise, false.</returns>
  public static bool TryParse(string str, out HexInt result)
  {
    str = str.TrimStart('#');
    result = default;
    if (string.IsNullOrEmpty(str) || str.Length > 8)
      return false;

    if (int.TryParse(str, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var intValue))
    {
      result = new HexInt(intValue);
      return true;
    }
    return false;
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexInt"/> struct from a hexadecimal string.
  /// </summary>
  /// <param name="str">
  ///   A hexadecimal string containing up to 8 hex digits (0-9, A-F, a-f) representing a 32-bit integer.
  ///   May begin with an optional '#' character.
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
  ///   Thrown when the parsed value exceeds the range of a 32-bit signed integer.
  /// </exception>
  public HexInt(string str)
  {
    str = str.TrimStart('#');
    value = uint.Parse(str, NumberStyles.HexNumber);
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexInt"/> struct from a 32-bit signed integer.
  /// </summary>
  /// <param name="value">
  ///   A 32-bit signed integer value (-2,147,483,648 to 2,147,483,647).
  /// </param>
  /// <remarks>
  ///   This is the primary constructor Ithat directly stores the integer value.
  ///   Example: new HexInt(123) stores value 123 (0x0000007B).
  /// </remarks>
  public HexInt(int value)
  {
    this.value = (uint)value;
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexInt"/> struct from a 32-bit unsigned integer.
  /// </summary>
  /// <param name="value">
  ///   A 32-bit unsigned integer value (0 to 4,294,967,295).
  /// </param>
  /// <remarks>
  ///   Values greater than 2,147,483,647 will be interpreted as negative numbers when cast to signed int.
  ///   Example: new HexInt(0xFFFFFFFF) results in -1.
  /// </remarks>
  public HexInt(uint value)
  {
    this.value = (uint)value;
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexInt"/> struct from a 64-bit unsigned integer.
  /// </summary>
  /// <param name="value">
  ///   A 64-bit unsigned integer value. Only the lower 32 bits are used.
  /// </param>
  /// <remarks>
  ///   The value is truncated to 32 bits. Values exceeding the int32 range will wrap around.
  ///   Example: new HexInt(0x100000001UL) results in 1.
  /// </remarks>
  public HexInt(ulong value)
  {
    this.value = (uint)value;
  }

  #region IConvertible Implementation
  /// <summary>
  ///   Returns the <see cref="TypeCode"/> for the underlying value type.
  /// </summary>
  /// <returns>
  ///   <see cref="TypeCode.Int32"/>, indicating the underlying storage type.
  /// </returns>
  public TypeCode GetTypeCode()
  {
    return value.GetTypeCode();
  }

  /// <summary>
  ///   Converts the HexInt value to a Boolean value.
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
  ///   Converts the HexInt value to a byte.
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
  ///   Converts the HexInt value to a character.
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
  ///   Converts the HexInt value to a DateTime.
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
  ///   Converts the HexInt value to a decimal.
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
  ///   Converts the HexInt value to a double-precision floating-point number.
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
  ///   Converts the HexInt value to a 16-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A 16-bit signed integer. Values outside the range -32,768 to 32,767 will be truncated.
  /// </returns>
  public short ToInt16(IFormatProvider? provider)
  {
    return (short)value;
  }

  /// <summary>
  ///   Converts the HexInt value to a 32-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   The underlying 32-bit signed integer value.
  /// </returns>
  public int ToInt32(IFormatProvider? provider)
  {
    return (Int32)value;
  }

  /// <summary>
  ///   Converts the HexInt value to a 64-bit signed integer.
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
  ///   Converts the HexInt value to a signed byte.
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
  ///   Converts the HexInt value to a single-precision floating-point number.
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
  ///   Converts the HexInt value to a string using the specified format provider.
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
  ///   Converts the HexInt value to a 16-bit unsigned integer.
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
  ///   Converts the HexInt value to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A 32-bit unsigned integer. Negative values are reinterpreted as unsigned (e.g., -1 becomes 4,294,967,295).
  /// </returns>
  public uint ToUInt32(IFormatProvider? provider)
  {
    return (uint)value;
  }

  /// <summary>
  ///   Converts the HexInt value to a 64-bit unsigned integer.
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
  ///   Converts the HexInt value to the specified target type.
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
  ///   <item><description>UInt16, Int32, UInt32, Int64, UInt64: Numeric conversions</description></item>
  ///   <item><description>Int16, Byte, SByte: Conversions with potential truncation</description></item>
  ///   <item><description>Single, Double, Decimal: Floating-point conversions</description></item>
  ///   <item><description>String: Hexadecimal string representation (8 characters)</description></item>
  ///   <item><description>HexInt: Creates a new HexInt with the same value</description></item>
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
    if (targetType == typeof(Int32))
      return value;
    if (targetType == typeof(UInt32))
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
    if (targetType == typeof(HexInt))
      return new HexInt(value);

    return ((IConvertible)value).ToType(targetType, provider);
  }

  #endregion

  #region Implicit Conversions
  /// <summary>
  ///   Implicitly converts a hexadecimal string to a HexInt.
  /// </summary>
  /// <param name="str">A hexadecimal string (up to 8 hex digits).
  ///   May begin with an optional '#' character.
  /// </param>
  /// <returns>A HexInt representing the parsed integer value.</returns>
  /// <remarks>
  ///   Example: HexInt i = "7B"; // represents 123
  /// </remarks>
  public static implicit operator HexInt(string str)
  {
    return new HexInt(str);
  }

  /// <summary>
  ///   Implicitly converts a HexInt to a 16-bit unsigned integer.
  /// </summary>
  /// <param name="val">A HexInt value.</param>
  /// <returns>The lower 16 bits as ushort.</returns>
  public static implicit operator ushort(HexInt val)
  {
    return (ushort)val.value;
  }

  /// <summary>
  ///   Implicitly converts a HexInt to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="val">A HexInt value.</param>
  /// <returns>The value reinterpreted as a uint.</returns>
  public static implicit operator uint(HexInt val)
  {
    return (uint)val.value;
  }

  /// <summary>
  ///   Implicitly converts a HexInt to a 32-bit signed integer.
  /// </summary>
  /// <param name="val">A HexInt value.</param>
  /// <returns>The underlying int32 value.</returns>
  public static implicit operator Int32(HexInt val)
  {
    return (Int32)val.value;
  }

  /// <summary>
  ///   Implicitly converts a HexInt to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="val">A HexInt value.</param>
  /// <returns>The value as a ulong.</returns>
  public static implicit operator ulong(HexInt val)
  {
    return (ulong)val.value;
  }

  /// <summary>
  ///   Implicitly converts a 16-bit unsigned integer to a HexInt.
  /// </summary>
  /// <param name="val">A ushort value (0 to 65,535).</param>
  /// <returns>A HexInt representing the value.</returns>
  public static implicit operator HexInt(ushort val)
  {
    return new HexInt((ulong)val);
  }

  /// <summary>
  ///   Implicitly converts a 32-bit unsigned integer to a HexInt.
  /// </summary>
  /// <param name="val">A uint value (0 to 4,294,967,295).</param>
  /// <returns>A HexInt representing the value.</returns>
  public static implicit operator HexInt(uint val)
  {
    return new HexInt((ulong)val);
  }

  /// <summary>
  ///   Implicitly converts a 32-bit signed integer to a HexInt.
  /// </summary>
  /// <param name="val">An int value (-2,147,483,648 to 2,147,483,647).</param>
  /// <returns>A HexInt representing the value.</returns>
  public static implicit operator HexInt(Int32 val)
  {
    return new HexInt((ulong)val);
  }

  /// <summary>
  ///   Implicitly converts a 64-bit unsigned integer to a HexInt.
  /// </summary>
  /// <param name="val">A ulong value. Only the lower 32 bits are used.</param>
  /// <returns>A HexInt representing the truncated value.</returns>
  public static implicit operator HexInt(ulong val)
  {
    return new HexInt(val);
  }

  /// <summary>
  ///   Implicitly converts a HexInt to a HexBinary.
  /// </summary>
  /// <param name="value">A HexInt value.</param>
  /// <returns>A HexBinary containing the 8-character hexadecimal representation.</returns>
  /// <remarks>
  ///   Example: HexInt(123) converts to HexBinary("0000007B").
  /// </remarks>
  public static implicit operator HexBinary(HexInt value) => new HexBinary(value.ToString(CultureInfo.InvariantCulture));

  /// <summary>
  ///   Implicitly converts a HexBinary to a HexInt.
  /// </summary>
  /// <param name="value">A HexBinary value containing a hexadecimal string.</param>
  /// <returns>A HexInt parsed from the hexadecimal string.</returns>
  /// <remarks>
  ///   Example: HexBinary("0000007B") converts to HexInt(123).
  /// </remarks>
  public static implicit operator HexInt(HexBinary value) => new HexInt(value.ToString());

  #endregion
  /// <summary>
  ///   Converts this HexInt to its 8-character uppercase hexadecimal string representation.
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
  ///   Determines whether this HexInt is equal to another HexInt.
  /// </summary>
  /// <param name="other">The HexInt to compare with this instance.</param>
  /// <returns>
  ///   <see langword="true"/> if the integer values are equal; otherwise <see langword="false"/>.
  /// </returns>
  public bool Equals(HexInt other)
  {
    return value == other.value;
  }

  /// <summary>
  ///   Returns a hash code for this HexInt.
  /// </summary>
  /// <returns>
  ///   A 32-bit signed integer hash code equal to the underlying integer value.
  /// </returns>
  public override int GetHashCode()
  {
    return (Int32)value;
  }
}
