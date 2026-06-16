namespace DocumentModel;
// ReSharper disable SpecifyACultureInStringConversionExplicitly

/// <summary>
///   Represents a byte value encoded as a hexadecimal string (2 hex digits) for use in Office Open XML documents.
/// </summary>
[JsonConverter(typeof(HexByteJsonConverter))]
public partial record HexByte : IConvertible, IEquatable<HexByte>
{
  private readonly byte value;

  /// <summary>
  /// Default constructor needed for XML deserialization. Initializes the HexByte with a default value of 0 (null byte).
  /// </summary>
  public HexByte()
  {
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexByte"/> struct from a hexadecimal string.
  /// </summary>
  /// <param name="str">
  ///   A hexadecimal string containing 2 hex digits (0-9, A-F, a-f) representing a byte code.
  ///   May begin with an optional '#' character (e.g., "#41" or "41" both represent 65).
  /// </param>
  /// <remarks>
  ///   <para>
  ///   The string is parsed as a hexadecimal number to obtain the byte code value.
  ///   Valid input examples: "41", "#20".
  ///   </para>
  /// </remarks>
  /// <exception cref="FormatException">
  ///   Thrown when the string is not a valid hexadecimal number.
  /// </exception>
  /// <exception cref="OverflowException">
  ///   Thrown when the parsed value exceeds 255 (byte.MaxValue).
  /// </exception>
  public HexByte(string str)
  {
    str = str.TrimStart('#');
    value = byte.Parse(str, NumberStyles.HexNumber);
  }

  /// <summary>
  ///  Parses a hexadecimal string and returns a HexByte. The string should contain 2 hex digits, optionally prefixed with '#'.
  /// </summary>
  /// <param name="str">A hexadecimal string containing 2 hex digits, optionally prefixed with '#'.</param>
  /// <returns>A HexByte instance representing the parsed value.</returns>
  public static HexByte Parse(string? str)
  {
    return new HexByte(str ?? string.Empty);
  }

  /// <summary>
  /// Attempts to parse a hexadecimal string and returns a boolean indicating success or failure. The result is stored in the out parameter.
  /// </summary>
  /// <param name="str">A hexadecimal string containing 2 hex digits, optionally prefixed with '#'.</param>
  /// <param name="result">The resulting HexByte instance if parsing is successful; otherwise, null.</param>
  /// <returns>True if parsing is successful; otherwise, false.</returns>
  public static bool TryParse(string? str, out HexByte? result)
  {
    if (str != null)
    {
      str = str.TrimStart('#');
      if (byte.TryParse(str, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var byteValue))
      {
        result = new HexByte(byteValue);
        return true;
      }
    }
    result = null;
    return false;
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexByte"/> struct from a byte value.
  /// </summary>
  /// <param name="value">
  ///   A byte value (0-255) representing a byte code.
  /// </param>
  /// <remarks>
  ///   This constructor is useful for ASCII and extended ASCII bytes (0-255).
  ///   Example: new HexByte(65) represents 'A'.
  /// </remarks>
  public HexByte(Byte value)
  {
    this.value = value;
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexByte"/> struct from a character.
  /// </summary>
  /// <param name="value">
  ///   A character whose ASCII code point will be stored.
  /// </param>
  /// <remarks>
  ///   This constructor converts a .NET character to its numeric ASCII value.
  ///   Example: new HexByte('A') stores value 65 (0x41).
  /// </remarks>
  public HexByte(Char value)
  {
    this.value = (byte)value;
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexByte"/> struct from a 16-bit unsigned integer.
  /// </summary>
  /// <param name="value">
  ///   A 16-bit unsigned integer (0-65535) representing a byte code.
  /// </param>
  /// <remarks>
  ///   This is the primary constructor that directly stores the byte code value.
  ///   It can represent any Unicode byte in the Basic Multilingual Plane.
  /// </remarks>
  public HexByte(ushort value)
  {
    this.value = (byte)value;
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="HexByte"/> struct from a 32-bit signed integer.
  /// </summary>
  /// <param name="value">
  ///   A 32-bit signed integer (0-65535) representing a byte code.
  /// </param>
  /// <remarks>
  ///   The value is cast to ushort. Values outside the range 0-65535 will be truncated.
  /// </remarks>
  public HexByte(int value)
  {
    this.value = (byte)value; 
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
  ///   Converts the HexByte value to a Boolean value.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   <see langword="true"/> if the byte code is non-zero; otherwise <see langword="false"/>.
  /// </returns>
  public bool ToBoolean(IFormatProvider? provider)
  {
    return value != 0;
  }

  /// <summary>
  ///   Converts the HexByte value to a byte.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A byte representing the byte code, truncated if necessary.
  /// </returns>
  /// <remarks>
  ///   Values greater than 255 will be truncated to their lower 8 bits.
  /// </remarks>
  public byte ToByte(IFormatProvider? provider)
  {
    return (byte)value;
  }

  /// <summary>
  ///   Converts the HexByte value to a byte.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> for culture-specific formatting.</param>
  /// <returns>
  ///   A byte corresponding to the Unicode code point stored in this HexByte.
  /// </returns>
  public char ToChar(IFormatProvider? provider)
  {
    return ((IConvertible)value).ToChar(provider);
  }

  /// <summary>
  ///   Converts the HexByte value to a DateTime.
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
  ///   Converts the HexByte value to a decimal.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A decimal value representing the byte code.
  /// </returns>
  public decimal ToDecimal(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  ///   Converts the HexByte value to a double-precision floating-point number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A double value representing the byte code.
  /// </returns>
  public double ToDouble(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  ///   Converts the HexByte value to a 16-bit signed integer.
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
  ///   Converts the HexByte value to a 32-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A 32-bit signed integer representing the byte code (0-65535).
  /// </returns>
  public int ToInt32(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  ///   Converts the HexByte value to a 64-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A 64-bit signed integer representing the byte code (0-65535).
  /// </returns>
  public long ToInt64(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  ///   Converts the HexByte value to a signed byte.
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
  ///   Converts the HexByte value to a single-precision floating-point number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A float value representing the byte code.
  /// </returns>
  public float ToSingle(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  ///   Converts the HexByte value to a string using the specified format provider.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> for culture-specific formatting.</param>
  /// <returns>
  ///   A string representation of the underlying numeric value (not hexadecimal).
  /// </returns>
  /// <remarks>
  ///   This method returns the decimal string representation of the byte code.
  ///   For hexadecimal string representation, use <see cref="ToString()"/>.
  /// </remarks>
  public string ToString(IFormatProvider? provider)
  {
    return ToString();
  }

  /// <summary>
  ///   Converts the HexByte value to a 16-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A 16-bit unsigned integer representing the byte code (0-65535).
  /// </returns>
  public ushort ToUInt16(IFormatProvider? provider)
  {
    return (ushort)value;
  }

  /// <summary>
  ///   Converts the HexByte value to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A 32-bit unsigned integer representing the byte code (0-65535).
  /// </returns>
  public uint ToUInt32(IFormatProvider? provider)
  {
    return (uint)value;
  }

  /// <summary>
  ///   Converts the HexByte value to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> (not used).</param>
  /// <returns>
  ///   A 64-bit unsigned integer representing the byte code (0-65535).
  /// </returns>
  public ulong ToUInt64(IFormatProvider? provider)
  {
    return (ulong)value;
  }

  /// <summary>
  ///   Converts the HexByte value to the specified target type.
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
  ///   <item><description>HexByte: Creates a new HexByte with the same value</description></item>
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
    if (targetType == typeof(HexByte))
      return new HexByte(value);
    return ((IConvertible)value).ToType(targetType, provider);
  }

  /// <summary>
  ///   Implicitly converts a hexadecimal string to a HexByte.
  /// </summary>
  /// <param name="val">
  /// A hexadecimal string (2 hex digits).
  ///   May begin with an optional '#' character (e.g., "#41" or "41" both represent 65, 'A').
  /// </param>
  /// <returns>A HexByte representing the parsed byte code.</returns>
  /// <remarks>
  ///   Example: HexByte c = "41"; // represents 'A' (65)
  /// </remarks>
  public static implicit operator HexByte(string val)
  {
    return new HexByte(val);
  }

  /// <summary>
  ///   Implicitly converts a nullable HexByte to its hexadecimal string representation.
  /// </summary>
  /// <param name="val">A nullable HexByte value.</param>
  /// <returns>
  ///   A hexadecimal string (2 or 4 digits), or null if the input is null.
  /// </returns>
  /// <remarks>
  ///   Example: string s = hexByte; // produces "0041" or "41" depending on value
  /// </remarks>
  public static implicit operator string?(HexByte? val)
  {
    return val?.ToString(CultureInfo.InvariantCulture);
  }

  /// <summary>
  ///   Implicitly converts a HexByte to a 8-bit unsigned integer.
  /// </summary>
  /// <param name="val">A HexByte value.</param>
  /// <returns>The underlying byte value (0-255).</returns>
  public static implicit operator byte(HexByte val)
  {
    return (byte)val.value;
  }

  /// <summary>
  ///   Implicitly converts a HexByte to a 16-bit unsigned integer.
  /// </summary>
  /// <param name="val">A HexByte value.</param>
  /// <returns>The underlying ushort value (0-65535).</returns>
  public static implicit operator ushort(HexByte val)
  {
    return (ushort)val.value;
  }

  /// <summary>
  ///   Implicitly converts a HexByte to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="val">A HexByte value.</param>
  /// <returns>The byte code as a uint (0-65535).</returns>
  public static implicit operator uint(HexByte val)
  {
    return (uint)val.value;
  }

  /// <summary>
  ///   Implicitly converts a nullable HexByte to a nullable 32-bit unsigned integer.
  /// </summary>
  /// <param name="val">A nullable HexByte value.</param>
  /// <returns>
  ///   The byte code as a nullable uint, or null if the input is null.
  /// </returns>
  public static implicit operator uint?(HexByte? val)
  {
    return (val is not null) ? (uint)val : null;
  }

  /// <summary>
  ///   Implicitly converts a HexByte to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="val">A HexByte value.</param>
  /// <returns>The byte code as a ulong (0-65535).</returns>
  public static implicit operator ulong(HexByte val)
  {
    return (ulong)val.value;
  }

  /// <summary>
  ///   Implicitly converts a 8-bit unsigned integer to a HexByte.
  /// </summary>
  /// <param name="val">A byte value (0-255).</param>
  /// <returns>A HexByte representing the byte value.</returns>
  public static implicit operator HexByte(byte val)
  {
    return new HexByte((ushort)val);
  }

  /// <summary>
  ///   Implicitly converts a 16-bit unsigned integer to a HexByte.
  /// </summary>
  /// <param name="val">A ushort value (0-65535).</param>
  /// <returns>A HexByte representing the byte code.</returns>
  public static implicit operator HexByte(ushort val)
  {
    return new HexByte((ushort)val);
  }

  /// <summary>
  ///   Implicitly converts a 32-bit unsigned integer to a HexByte.
  /// </summary>
  /// <param name="val">A uint value (must be 0-65535).</param>
  /// <returns>A HexByte representing the byte code.</returns>
  /// <exception cref="InvalidCastException">
  ///   Thrown when the value exceeds 65535 (ushort.MaxValue).
  /// </exception>
  public static implicit operator HexByte(uint val)
  {
    if (val > ushort.MaxValue)
      throw new InvalidCastException($"ValueType {val} out of range to cast to HexByte");
    return new HexByte((ushort)val);
  }

  /// <summary>
  ///   Implicitly converts a 64-bit unsigned integer to a HexByte.
  /// </summary>
  /// <param name="val">A ulong value (must be 0-65535).</param>
  /// <returns>A HexByte representing the byte code.</returns>
  /// <exception cref="InvalidCastException">
  ///   Thrown when the value exceeds 65535 (ushort.MaxValue).
  /// </exception>
  public static implicit operator HexByte(ulong val)
  {
    if (val > ushort.MaxValue)
      throw new InvalidCastException($"ValueType {val} out of range to cast to HexByte");
    return new HexByte((ushort)val);
  }

  /// <summary>
  ///   Converts this HexByte to its hexadecimal string representation.
  /// </summary>
  /// <returns>
  ///   A hexadecimal string of 2 digits.
  /// </returns>
  public override string ToString()
  {
    return value.ToString("X2");
  }


  /// <summary>
  ///   Converts this HexByte to its string representation in a provided format.
  /// </summary>
  /// <param name="format">format for string representation (e.g., "X2" for 2-digit hex).</param>
  /// <returns>
  ///   A string in provided format string.
  /// </returns>
  public string ToString(string format)
  {
    return value.ToString(format);
  }
  /// <summary>
  ///   Determines whether this HexByte is equal to another HexByte.
  /// </summary>
  /// <param name="other">The HexByte to compare with this instance.</param>
  /// <returns>
  ///   <see langword="true"/> if the byte codes are equal; otherwise <see langword="false"/>.
  /// </returns>
  public virtual bool Equals(HexByte? other)
  {
    if (other == null)
      return false;
    return value == other.value;
  }

  /// <summary>
  ///   Returns a hash code for this HexByte.
  /// </summary>
  /// <returns>
  ///   A 32-bit signed integer hash code equal to the byte code value.
  /// </returns>
  public override int GetHashCode()
  {
    return value;
  }
}
