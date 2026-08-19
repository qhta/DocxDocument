namespace DocumentModel;
// ReSharper disable SpecifyACultureInStringConversionExplicitly

/// <summary>
///   Represents a character value encoded as a hexadecimal string (2 or 4 hex digits) for use in Office Open XML documents.
/// </summary>
/// <remarks>
///   <para>
///   HexChar provides a type-safe wrapper for character values that are represented as hexadecimal strings
///   in Office Open XML documents. It stores a 32-bit signed integer value that can represent
///   any Unicode character.
///   </para>
///   <para>
///   This type is commonly used in Office documents for:
///   <list type="bullet">
///   <item><description>Special character codes and Unicode values</description></item>
///   <item><description>Character formatting and font-related properties</description></item>
///   <item><description>Symbol and glyph identifiers</description></item>
///   <item><description>Character references in document markup</description></item>
///   </list>
///   </para>
///   <para>
///   HexChar values are formatted as hexadecimal strings:
///   <list type="bullet">
///   <item><description>Values 0-255: 2-digit hex format (e.g., "41" for 'A', "20" for space)</description></item>
///   <item><description>Values 256-65535: 4-digit hex format (e.g., "03B1" for Greek alpha α)</description></item>
///   </list>
///   </para>
///   <para>
///   The struct implements <see cref="IConvertible"/> for seamless integration with .NET type conversion
///   and <see cref="IEquatable{T}"/> for efficient equality comparisons. It provides implicit conversions
///   between HexChar and common numeric types (byte, ushort, uint, ulong) as well as string representations.
///   </para>
///   <para>
///   <b>Office Availability:</b> Hexadecimal character encoding is supported across all Office Open XML
///   formats including Word, Excel, and PowerPoint documents (Office 2007 and later).
///   </para>
/// </remarks>
[DataContract]
[JsonConverter(typeof(HexCharJsonConverter))]
public partial record HexChar : IConvertible, IEquatable<HexChar>
{
  private readonly int value;

  /// <summary>
  /// Default constructor needed for XML deserialization. Initializes the HexChar with a default value of 0 (null character).
  /// </summary>
  public HexChar()
  {
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexChar"/> struct from a hexadecimal string.
  /// </summary>
  /// <param name="str">
  ///   A hexadecimal string containing 2 or 4 hex digits (0-9, A-F, a-f) representing a character code.
  /// </param>
  /// <remarks>
  ///   <para>
  ///   The string is parsed as a hexadecimal number to obtain the character code value.
  ///   Valid input examples: "41" (65, 'A'), "20" (32, space), "03B1" (945, Greek alpha α).
  ///   May begin with an optional '#' character (e.g., "#41" or "41" both represent 65, 'A').
  ///   </para>
  /// </remarks>
  /// <exception cref="FormatException">
  ///   Thrown when the string is not a valid hexadecimal number.
  /// </exception>
  /// <exception cref="OverflowException">
  ///   Thrown when the parsed value exceeds 65535 (ushort.MaxValue).
  /// </exception>
  public HexChar(string str)
  {
    str = str.TrimStart('#');
    value = int.Parse(str, NumberStyles.HexNumber);
  }

  /// <summary>
  ///  Parses a hexadecimal string and returns a HexChar. The string should contain 2 or 4hex digits, optionally prefixed with '#'.
  /// </summary>
  /// <param name="str">A hexadecimal string containing 2 or 4 hex digits, optionally prefixed with '#'.</param>
  /// <returns>A HexChar instance representing the parsed value.</returns>
  public static HexChar Parse(string? str)
  {
    return new HexChar(str ?? string.Empty);
  }

  /// <summary>
  /// Attempts to parse a hexadecimal string and returns a boolean indicating success or failure. The result is stored in the out parameter.
  /// </summary>
  /// <param name="str">A hexadecimal string containing 2 hex digits, optionally prefixed with '#'.</param>
  /// <param name="result">The resulting HexChar instance if parsing is successful; otherwise, null.</param>
  /// <returns>True if parsing is successful; otherwise, false.</returns>
  public static bool TryParse(string? str, out HexChar? result)
  {
    if (str != null)
    {
      str = str.TrimStart('#');
      if (ushort.TryParse(str, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var byteValue))
      {
        result = new HexChar(byteValue);
        return true;
      }
    }
    result = null;
    return false;
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexChar"/> struct from a byte value.
  /// </summary>
  /// <param name="value">
  ///   A byte value (0-255) representing a character code.
  /// </param>
  /// <remarks>
  ///   This constructor is useful for ASCII and extended ASCII characters (0-255).
  ///   Example: new HexChar(65) represents 'A'.
  /// </remarks>
  public HexChar(Byte value)
  {
    this.value = value;
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexChar"/> struct from a character.
  /// </summary>
  /// <param name="value">
  ///   A character whose Unicode code point will be stored.
  /// </param>
  /// <remarks>
  ///   This constructor converts a .NET char to its numeric Unicode value.
  ///   Example: new HexChar('A') stores value 65 (0x41).
  /// </remarks>
  public HexChar(char value)
  {
    this.value = value;
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexChar"/> struct from a 16-bit unsigned integer.
  /// </summary>
  /// <param name="value">
  ///   A 16-bit unsigned integer (0-65535) representing a character code.
  /// </param>
  /// <remarks>
  ///   This is the primary constructor that directly stores the character code value.
  ///   It can represent any Unicode character in the Basic Multilingual Plane.
  /// </remarks>
  public HexChar(ushort value)
  {
    this.value = value;
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexChar"/> struct from a 32-bit signed integer.
  /// </summary>
  /// <param name="value">
  ///   A 32-bit signed integer (0-65535) representing a character code.
  /// </param>
  /// <remarks>
  ///   The value is cast to ushort. Values outside the range 0-65535 will be truncated.
  /// </remarks>
  public HexChar(int value)
  {
    this.value = (ushort)value;
  }

  /// <summary>
  ///   Returns the <see cref="TypeCode"/> for the underlying value type.
  /// </summary>
  /// <returns>
  ///   <see cref="TypeCode.UInt16"/>, indicating the underlying storage type.
  /// </returns>
  public TypeCode GetTypeCode()
  {
    return value.GetTypeCode();
  }

  /// <summary>
  ///   Converts the HexChar value to a Boolean value.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   <see langword="true"/> if the character code is non-zero; otherwise <see langword="false"/>.
  /// </returns>
  public bool ToBoolean(IFormatProvider? provider)
  {
    return value != 0;
  }

  /// <summary>
  ///   Converts the HexChar value to a byte.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A byte representing the character code, truncated if necessary.
  /// </returns>
  /// <remarks>
  ///   Values greater than 255 will be truncated to their lower 8 bits.
  /// </remarks>
  public byte ToByte(IFormatProvider? provider)
  {
    return (byte)value;
  }

  /// <summary>
  ///   Converts the HexChar value to a character.
  /// </summary>
  /// <returns>
  ///   A character corresponding to the Unicode code point stored in this HexChar.
  /// </returns>
  public char ToChar()
  {
    return ((IConvertible)value).ToChar(null);
  }

  /// <summary>
  ///   Converts the HexChar value to a character.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> for culture-specific formatting.</param>
  /// <returns>
  ///   A character corresponding to the Unicode code point stored in this HexChar.
  /// </returns>
  public char ToChar(IFormatProvider? provider)
  {
    return ((IConvertible)value).ToChar(provider);
  }

  /// <summary>
  ///   Converts the HexChar value to a DateTime.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> for culture-specific formatting.</param>
  /// <returns>
  ///   A DateTime value (delegates to the underlying ushort conversion).
  /// </returns>
  /// <exception cref="InvalidCastException">
  ///   This conversion is not supported and will typically throw an exception.
  /// </exception>
  public DateTime ToDateTime(IFormatProvider? provider)
  {
    return ((IConvertible)value).ToDateTime(provider);
  }

  /// <summary>
  ///   Converts the HexChar value to a decimal.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A decimal value representing the character code.
  /// </returns>
  public decimal ToDecimal(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  ///   Converts the HexChar value to a double-precision floating-point number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A double value representing the character code.
  /// </returns>
  public double ToDouble(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  ///   Converts the HexChar value to a 16-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A 16-bit signed integer. Values greater than 32767 will produce negative results.
  /// </returns>
  public short ToInt16(IFormatProvider? provider)
  {
    return (short)value;
  }

  /// <summary>
  ///   Converts the HexChar value to a 32-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A 32-bit signed integer representing the character code (0-65535).
  /// </returns>
  public int ToInt32(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  ///   Converts the HexChar value to a 64-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A 64-bit signed integer representing the character code (0-65535).
  /// </returns>
  public long ToInt64(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  ///   Converts the HexChar value to a signed byte.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A signed byte. Values greater than 127 will produce negative results.
  /// </returns>
  public sbyte ToSByte(IFormatProvider? provider)
  {
    return (sbyte)value;
  }

  /// <summary>
  ///   Converts the HexChar value to a single-precision floating-point number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A float value representing the character code.
  /// </returns>
  public float ToSingle(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  ///   Converts the HexChar value to a string using the specified format provider.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> for culture-specific formatting.</param>
  /// <returns>
  ///   A string representation of the underlying numeric value (not hexadecimal).
  /// </returns>
  /// <remarks>
  ///   This method returns the decimal string representation of the character code.
  ///   For hexadecimal string representation, use <see cref="ToString()"/>.
  /// </remarks>
  public string ToString(IFormatProvider? provider)
  {
    return ToString();
  }

  /// <summary>
  ///   Converts the HexChar value to a 16-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A 16-bit unsigned integer representing the character code (0-65535).
  /// </returns>
  public ushort ToUInt16(IFormatProvider? provider)
  {
    return (ushort)value;
  }

  /// <summary>
  ///   Converts the HexChar value to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A 32-bit unsigned integer representing the character code (0-65535).
  /// </returns>
  public uint ToUInt32(IFormatProvider? provider)
  {
    return (uint)value;
  }

  /// <summary>
  ///   Converts the HexChar value to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A 64-bit unsigned integer representing the character code (0-65535).
  /// </returns>
  public ulong ToUInt64(IFormatProvider? provider)
  {
    return (ulong)value;
  }

  /// <summary>
  ///   Converts the HexChar value to the specified target type.
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
  ///   <item><description>UInt16, Int32, UInt32, UInt64: Direct numeric conversions</description></item>
  ///   <item><description>Int16, Byte, SByte: Conversions with potential truncation/overflow</description></item>
  ///   <item><description>Single, Double, Decimal: Floating-point conversions</description></item>
  ///   <item><description>String: Hexadecimal string representation</description></item>
  ///   <item><description>HexChar: Creates a new HexChar with the same value</description></item>
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
    if (targetType == typeof(HexChar))
      return new HexChar(value);
    return ((IConvertible)value).ToType(targetType, provider);
  }

  /// <summary>
  ///   Implicitly converts a hexadecimal string to a HexChar.
  /// </summary>
  /// <param name="str">
  ///   A hexadecimal string (2 or 4 hex digits).
  ///   May begin with an optional '#' character (e.g., "#41" or "41" both represent 65, 'A').
  /// </param>
  /// <returns>A HexChar representing the parsed character code.</returns>
  /// <remarks>
  ///   Example: HexChar c = "41"; // represents 'A' (65)
  /// </remarks>
  public static implicit operator HexChar(string str)
  {
    return new HexChar(str);
  }

  /// <summary>
  ///   Implicitly converts a nullable HexChar to its hexadecimal string representation.
  /// </summary>
  /// <param name="val">A nullable HexChar value.</param>
  /// <returns>
  ///   A hexadecimal string (2 or 4 digits), or null if the input is null.
  /// </returns>
  /// <remarks>
  ///   Example: string s = hexChar; // produces "0041" or "41" depending on value
  /// </remarks>
  public static implicit operator string?(HexChar? val)
  {
    return val?.ToString(CultureInfo.InvariantCulture);
  }

  /// <summary>
  ///   Implicitly converts a HexChar to a 32-bit signed integer.
  /// </summary>
  /// <param name="val">A HexChar value.</param>
  /// <returns>The character code as int</returns>
  public static implicit operator int(HexChar val)
  {
    return (int)val.value;
  }

  /// <summary>
  ///   Implicitly converts a 32-bit signed integer to a HexChar.
  /// </summary>
  /// <param name="val">A 32-bit signed integer value.</param>
  /// <returns>A HexChar representing the character code.</returns>
  public static implicit operator HexChar(int val)
  {
     return new HexChar((ushort)val);
  }

  /// <summary>
  ///   Implicitly converts a HexChar to a 8-bit unsigned integer.
  /// </summary>
  /// <param name="val">A HexChar value.</param>
  /// <returns>The underlying byte value (0-255).</returns>
  public static implicit operator byte(HexChar val)
  {
    return (byte)val.value;
  }

  /// <summary>
  ///   Implicitly converts a HexChar to a 16-bit unsigned integer.
  /// </summary>
  /// <param name="val">A HexChar value.</param>
  /// <returns>The underlying ushort value (0-65535).</returns>
  public static implicit operator ushort(HexChar val)
  {
    return (ushort)val.value;
  }

  /// <summary>
  ///   Implicitly converts a HexChar to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="val">A HexChar value.</param>
  /// <returns>The character code as a uint (0-65535).</returns>
  public static implicit operator uint(HexChar val)
  {
    return (uint)val.value;
  }

  /// <summary>
  ///   Implicitly converts a nullable HexChar to a nullable 32-bit unsigned integer.
  /// </summary>
  /// <param name="val">A nullable HexChar value.</param>
  /// <returns>
  ///   The character code as a nullable uint, or null if the input is null.
  /// </returns>
  public static implicit operator uint?(HexChar? val)
  {
    return (val is not null) ? (uint)val : null;
  }

  /// <summary>
  ///   Implicitly converts a HexChar to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="val">A HexChar value.</param>
  /// <returns>The character code as a ulong (0-65535).</returns>
  public static implicit operator ulong(HexChar val)
  {
    return (ulong)val.value;
  }

  /// <summary>
  ///   Implicitly converts a 8-bit unsigned integer to a HexChar.
  /// </summary>
  /// <param name="val">A byte value (0-255).</param>
  /// <returns>A HexChar representing the byte value.</returns>
  public static implicit operator HexChar(byte val)
  {
    return new HexChar((ushort)val);
  }

  /// <summary>
  ///   Implicitly converts a 16-bit unsigned integer to a HexChar.
  /// </summary>
  /// <param name="val">A ushort value (0-65535).</param>
  /// <returns>A HexChar representing the character code.</returns>
  public static implicit operator HexChar(ushort val)
  {
    return new HexChar((ushort)val);
  }

  /// <summary>
  ///   Implicitly converts a 32-bit unsigned integer to a HexChar.
  /// </summary>
  /// <param name="val">A uint value (must be 0-65535).</param>
  /// <returns>A HexChar representing the character code.</returns>
  /// <exception cref="InvalidCastException">
  ///   Thrown when the value exceeds 65535 (ushort.MaxValue).
  /// </exception>
  public static implicit operator HexChar(uint val)
  {
    if (val > ushort.MaxValue)
      throw new InvalidCastException($"ValueType {val} out of range to cast to HexChar");
    return new HexChar((ushort)val);
  }

  /// <summary>
  ///   Implicitly converts a 64-bit unsigned integer to a HexChar.
  /// </summary>
  /// <param name="val">A ulong value (must be 0-65535).</param>
  /// <returns>A HexChar representing the character code.</returns>
  /// <exception cref="InvalidCastException">
  ///   Thrown when the value exceeds 65535 (ushort.MaxValue).
  /// </exception>
  public static implicit operator HexChar(ulong val)
  {
    if (val > ushort.MaxValue)
      throw new InvalidCastException($"ValueType {val} out of range to cast to HexChar");
    return new HexChar((ushort)val);
  }

  /// <summary>
  ///   Converts this HexChar to its hexadecimal string representation.
  /// </summary>
  /// <returns>
  ///   A hexadecimal string: 2 digits for values 0-255, 4 digits for values 256-65535.
  /// </returns>
  /// <remarks>
  ///   <para>
  ///   Examples:
  ///   <list type="bullet">
  ///   <item><description>value 65 (0x41, 'A') → "41"</description></item>
  ///   <item><description>value 32 (0x20, space) → "20"</description></item>
  ///   <item><description>value 945 (0x03B1, Greek alpha α) → "03B1"</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  public override string ToString()
  {
    if (value > 255)
      return value.ToString("X4");
    return value.ToString("X2");
  }

  /// <summary>
  ///   Determines whether this HexChar is equal to another HexChar.
  /// </summary>
  /// <param name="other">The HexChar to compare with this instance.</param>
  /// <returns>
  ///   <see langword="true"/> if the character codes are equal; otherwise <see langword="false"/>.
  /// </returns>
  public virtual bool Equals(HexChar? other)
  {
    if (other == null)
      return false;
    return value == other.value;
  }

  /// <summary>
  ///   Returns a hash code for this HexChar.
  /// </summary>
  /// <returns>
  ///   A 32-bit signed integer hash code equal to the character code value.
  /// </returns>
  public override int GetHashCode()
  {
    return value;
  }
}
