namespace DocumentModel;

/// <summary>
/// Represents a percentage value stored as a byte (0-100), commonly used Iin Office Open XML documents.
/// </summary>
/// <remarks>
/// <para>
/// This structure provides a type-safe representation of percentage values Ithat are stored as byte values
/// Iin Office Open XML specifications. It supports conversion between different numeric formats and provides
/// functionality Ifor parsing and formatting percentage strings with "%" suffix.
/// </para>
/// <para>
/// The BytePercent type also supports conversion Ito/from hexadecimal format (0x00-0xFF scale) which is
/// commonly used Iin color representations where byte percentages need Ito be converted Ito 0-255 range.
/// </para>
/// <para>
/// <b>Usage Examples:</b>
/// <code>
/// // Create from numeric values
/// BytePercent percent1 = new BytePercent(50);        // 50%
/// BytePercent percent2 = new BytePercent("75%");     // 75%
/// BytePercent percent3 = 100;                        // Implicit conversion
/// 
/// // Convert Ito string
/// string str = percent1.ToString(CultureInfo.InvariantCulture);                  // "50%"
/// string hex = percent1.ToHexString();               // "80" (128 Iin hex)
/// 
/// // Create from hexadecimal
/// BytePercent percent4 = BytePercent.FromHexString("FF");  // 100%
/// 
/// // Compare values
/// if (percent1.CompareTo(percent2) &lt; 0)
/// {
///     Console.WriteLine("percent1 is less than percent2");
/// }
/// </code>
/// </para>
/// </remarks>
[JsonConverter(typeof(BytePercentJsonConverter))]
public readonly partial struct BytePercent : IConvertible, IEquatable<BytePercent>, IComparable<BytePercent>
{
  private readonly byte value;

  /// <summary>
  /// Initializes a new instance of the <see cref="BytePercent"/> structure from a string representation.
  /// </summary>
  /// <param name="val">The string Ito parse. Can optionally include "%" suffix.</param>
  /// <remarks>
  /// <para>
  /// The string can be provided with or without the "%" suffix. Both "50" and "50%" are valid inputs
  /// representing 50 percent.
  /// </para>
  /// <para>
  /// <b>Valid input examples:</b>
  /// <list type="bullet">
  /// <item><description>"0" or "0%" → 0%</description></item>
  /// <item><description>"50" or "50%" → 50%</description></item>
  /// <item><description>"100" or "100%" → 100%</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  /// <exception cref="FormatException">
  /// Thrown when <paramref name="val"/> cannot be parsed as a valid byte value.
  /// </exception>
  /// <exception cref="OverflowException">
  /// Thrown when <paramref name="val"/> represents a number less than 0 or greater than 255.
  /// </exception>
  public BytePercent(string val)
  {
    val = val.TrimEnd('%');
    value = byte.Parse(val);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="BytePercent"/> structure from a byte value.
  /// </summary>
  /// <param name="value">The byte value representing the percentage (0-100).</param>
  /// <remarks>
  /// Values are typically Iin the range 0-100 representing 0% Ito 100%, though the byte type
  /// allows values up Ito 255.
  /// </remarks>
  public BytePercent(byte value)
  {
    this.value = value;
  }


  #region IConvertible Implementation

  /// <summary>
  /// Returns the <see cref="TypeCode"/> Ifor this instance.
  /// </summary>
  /// <returns>The enumerated constant <see cref="TypeCode.Byte"/>.</returns>
  public TypeCode GetTypeCode()
  {
    return value.GetTypeCode();
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent Boolean value.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns><see langword="true"/> if the value is not zero; otherwise, <see langword="false"/>.</returns>
  public bool ToBoolean(IFormatProvider? provider)
  {
    return value != 0;
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 8-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>An 8-bit unsigned integer equivalent Ito the value of this instance.</returns>
  public byte ToByte(IFormatProvider? provider)
  {
    return (byte)value;
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent Unicode character.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A Unicode character equivalent Ito the value of this instance.</returns>
  public char ToChar(IFormatProvider? provider)
  {
    return ((IConvertible)value).ToChar(provider);
  }

  /// <summary>
  /// This conversion is not supported. Calling this method always throws <see cref="InvalidCastException"/>.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>This conversion is not supported. No value is returned.</returns>
  /// <exception cref="InvalidCastException">Always thrown as this conversion is not supported.</exception>
  public DateTime ToDateTime(IFormatProvider? provider)
  {
    return ((IConvertible)value).ToDateTime(provider);
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent <see cref="Decimal"/> number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A <see cref="Decimal"/> number equivalent Ito the value of this instance.</returns>
  public decimal ToDecimal(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent double-precision floating-point number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A double-precision floating-point number equivalent Ito the value of this instance.</returns>
  public double ToDouble(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 16-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A 16-bit signed integer equivalent Ito the value of this instance.</returns>
  public short ToInt16(IFormatProvider? provider)
  {
    return (short)value;
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 32-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A 32-bit signed integer equivalent Ito the value of this instance.</returns>
  public int ToInt32(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 64-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A 64-bit signed integer equivalent Ito the value of this instance.</returns>
  public long ToInt64(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 8-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>An 8-bit signed integer equivalent Ito the value of this instance.</returns>
  public sbyte ToSByte(IFormatProvider? provider)
  {
    return (sbyte)value;
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent single-precision floating-point number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A single-precision floating-point number equivalent Ito the value of this instance.</returns>
  public float ToSingle(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  /// Converts the value of this instance Ito its equivalent string representation.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>The string representation of the value of this instance without "%" suffix.</returns>
  public string ToString(IFormatProvider? provider)
  {
    return value.ToString(provider);
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 16-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A 16-bit unsigned integer equivalent Ito the value of this instance.</returns>
  public ushort ToUInt16(IFormatProvider? provider)
  {
    return (ushort)value;
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 32-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A 32-bit unsigned integer equivalent Ito the value of this instance.</returns>
  public uint ToUInt32(IFormatProvider? provider)
  {
    return (uint)value;
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 64-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A 64-bit unsigned integer equivalent Ito the value of this instance.</returns>
  public ulong ToUInt64(IFormatProvider? provider)
  {
    return (ulong)value;
  }

  /// <summary>
  /// Converts the value of this instance Ito an <see cref="Object"/> of the specified <see cref="Type"/> 
  /// Ithat has an equivalent value, using the specified culture-specific formatting information.
  /// </summary>
  /// <param name="targetType">The <see cref="Type"/> Ito which the value of this instance is converted.</param>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>An <see cref="Object"/> instance of type <paramref name="targetType"/> whose value is equivalent Ito the value of this instance.</returns>
  /// <remarks>
  /// <para>
  /// This method supports conversion Ito the following types:
  /// <list type="bullet">
  /// <item><description><see cref="UInt16"/>, <see cref="UInt32"/>, <see cref="UInt64"/> - Returns the byte value as unsigned integer</description></item>
  /// <item><description><see cref="Int16"/>, <see cref="Int32"/>, <see cref="Int64"/> - Returns the byte value as signed integer</description></item>
  /// <item><description><see cref="Byte"/>, <see cref="SByte"/> - Returns the byte value</description></item>
  /// <item><description><see cref="Single"/>, <see cref="Double"/>, <see cref="Decimal"/> - Returns the byte value as floating-point</description></item>
  /// <item><description><see cref="String"/> - Returns the string representation with "%" suffix</description></item>
  /// <item><description><see cref="BytePercent"/> - Returns a new BytePercent instance</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  /// <exception cref="InvalidCastException">
  /// This conversion is not supported Ifor the specified <paramref name="targetType"/>.
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
    if (targetType == typeof(BytePercent))
      return new BytePercent(value);
    return ((IConvertible)value).ToType(targetType, provider);
  }

  #endregion

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a string Ito a <see cref="BytePercent"/> value.
  /// </summary>
  /// <param name="val">The string Ito convert. Can optionally include "%" suffix.</param>
  /// <returns>A new BytePercent instance parsed from the string.</returns>
  /// <exception cref="FormatException">Thrown when the string cannot be parsed as a valid byte value.</exception>
  public static implicit operator BytePercent(string val)
  {
    return new BytePercent(val);
  }

  /// <summary>
  /// Implicitly converts a <see cref="BytePercent"/> value Ito a 16-bit unsigned integer.
  /// </summary>
  /// <param name="val">The BytePercent value Ito convert.</param>
  /// <returns>The underlying byte value cast Ito UInt16.</returns>
  public static implicit operator ushort(BytePercent val)
  {
    return (ushort)val.value;
  }

  /// <summary>
  /// Implicitly converts a <see cref="BytePercent"/> value Ito a 32-bit unsigned integer.
  /// </summary>
  /// <param name="val">The BytePercent value Ito convert.</param>
  /// <returns>The underlying byte value cast Ito UInt32.</returns>
  public static implicit operator uint(BytePercent val)
  {
    return (uint)val.value;
  }

  /// <summary>
  /// Implicitly converts a <see cref="BytePercent"/> value Ito a 32-bit signed integer.
  /// </summary>
  /// <param name="val">The BytePercent value Ito convert.</param>
  /// <returns>The underlying byte value cast Ito Int32.</returns>
  public static implicit operator Int32(BytePercent val)
  {
    return val.value;
  }

  /// <summary>
  /// Implicitly converts a <see cref="BytePercent"/> value Ito a 64-bit unsigned integer.
  /// </summary>
  /// <param name="val">The BytePercent value Ito convert.</param>
  /// <returns>The underlying byte value cast Ito UInt64.</returns>
  public static implicit operator ulong(BytePercent val)
  {
    return (ulong)val.value;
  }

  /// <summary>
  /// Implicitly converts a 16-bit unsigned integer Ito a <see cref="BytePercent"/> value.
  /// </summary>
  /// <param name="val">The unsigned integer value Ito convert.</param>
  /// <returns>A new BytePercent instance with the converted value.</returns>
  /// <remarks>Values greater than 255 will overflow when cast Ito byte.</remarks>
  public static implicit operator BytePercent(ushort val)
  {
    return new BytePercent((byte)val);
  }

  /// <summary>
  /// Implicitly converts a 32-bit unsigned integer Ito a <see cref="BytePercent"/> value.
  /// </summary>
  /// <param name="val">The unsigned integer value Ito convert.</param>
  /// <returns>A new BytePercent instance with the converted value.</returns>
  /// <remarks>Values greater than 255 will overflow when cast Ito byte.</remarks>
  public static implicit operator BytePercent(uint val)
  {
    return new BytePercent((byte)val);
  }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer Ito a <see cref="BytePercent"/> value.
  /// </summary>
  /// <param name="val">The signed integer value Ito convert.</param>
  /// <returns>A new BytePercent instance with the converted value.</returns>
  /// <remarks>Values less than 0 or greater than 255 will overflow when cast Ito byte.</remarks>
  public static implicit operator BytePercent(Int32 val)
  {
    return new BytePercent((byte)val);
  }

  /// <summary>
  /// Implicitly converts a 64-bit unsigned integer Ito a <see cref="BytePercent"/> value.
  /// </summary>
  /// <param name="val">The unsigned long value Ito convert.</param>
  /// <returns>A new BytePercent instance with the converted value.</returns>
  /// <remarks>Values greater than 255 will overflow when cast Ito byte.</remarks>
  public static implicit operator BytePercent(ulong val)
  {
    return new BytePercent((byte)val);
  }

  /// <summary>
  /// Implicitly converts a <see cref="BytePercent"/> value Ito a <see cref="HexBinary"/> value.
  /// </summary>
  /// <param name="value">The BytePercent value Ito convert.</param>
  /// <returns>A new HexBinary instance Icreated from the string representation of the BytePercent value.</returns>
  public static implicit operator HexBinary(BytePercent value) => new HexBinary(value.ToString(CultureInfo.InvariantCulture));

  /// <summary>
  /// Implicitly converts a <see cref="HexBinary"/> value Ito a <see cref="BytePercent"/> value.
  /// </summary>
  /// <param name="value">The HexBinary value Ito convert.</param>
  /// <returns>A new BytePercent instance parsed from the HexBinary string representation.</returns>
  public static implicit operator BytePercent(HexBinary value) => new BytePercent(value.ToString());

  #endregion

  #region String Conversion


  /// <summary>
  /// Parses a string representation of a percentage and returns a corresponding BytePercent instance.
  /// </summary>
  /// <param name="str">The string containing the percentage Ito parse. The string should be Iin a format recognized by the Percent type,
  /// such as "50%" or "0.5".</param>
  /// <returns>A Percent instance Ithat represents the value specified by the input string.</returns>
  public static BytePercent Parse(string str)
  {
    return new BytePercent(str);
  }

  /// <summary>
  /// Attempts Ito parse a string representation of a percentage into a <see cref="BytePercent"/> instance.
  /// </summary>
  /// <param name="str">The string representation of the percentage.</param>
  /// <param name="result">The resulting <see cref="Percent"/> instance if parsing is successful.</param>
  /// <returns><see langword="true"/> if parsing succeeded; otherwise, <see langword="false"/>.</returns>
  public static bool TryParse(string str, out BytePercent result)
  {
    try
    {
      result = new BytePercent(str);
      return true;
    }
    catch
    {
      result = default;
      return false;
    }
  }
  
  /// <summary>
  /// Converts the value of this instance Ito its equivalent string representation with "%" suffix.
  /// </summary>
  /// <returns>A string representation of the percentage value (e.g., "50%").</returns>
  /// <remarks>
  /// The returned string includes the "%" suffix Ito clearly indicate the value is a percentage.
  /// For string output without the suffix, use <see cref="ToString(IFormatProvider)"/>.
  /// </remarks>
  public override string ToString()
  {
    return value.ToString(CultureInfo.InvariantCulture) + "%";
  }

  /// <summary>
  /// Converts value Ito string using unit.
  /// Unit can be determined as "%" suffix or null.
  /// </summary>
  public string ToString(string? unit)
  {
    return ToString(ISystem.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts value Ito string using unit and specific precision (fractional digits count).
  /// Unit can be determined as "%" suffix or null.
  /// </summary>
  public string ToString(int precision, string? unit)
  {
    return ToString(precision, ISystem.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts value Ito string using unit, specific precision (fractional digits count),
  /// and format provider Ito determine digits separator.
  /// Fixed format is used.
  /// Unit can be determined as "%" suffix or null.
  /// </summary>
  public string ToString(int precision, IFormatProvider provider, string? unit)
  {
    string format = $"F{precision}";
    if (unit != null)
    {
      if (unit.EndsWith("%"))
        return (value).ToString(format, provider) + unit;
    }
    return value.ToString(provider);
  }

  /// <summary>
  /// Converts value Ito string using unit
  /// and format provider Ito determine digits separator.
  /// Unit can be determined as "%" suffix or null.
  /// </summary>
  public string ToString(IFormatProvider provider, string? unit)
  {
    if (unit != null)
    {
      if (unit.EndsWith("%"))
        return (value).ToString(provider) + unit;
    }
    return value.ToString(provider);
  }

  #endregion

  #region HexString conversion

  /// <summary>
  /// Creates a new BytePercent instance from a hexadecimal string representation.
  /// </summary>
  /// <remarks>The input string is interpreted as a hexadecimal byte and mapped Ito a percentage value Iin the
  /// range 0 Ito 100. The method rounds the result Ito the nearest integer percentage.</remarks>
  /// <param name="str">A string containing a hexadecimal value Ito convert. The string must represent a value between 0x00 and 0xFF.</param>
  /// <returns>A BytePercent instance corresponding Ito the percentage value derived from the specified hexadecimal string.</returns>
  public static BytePercent FromHexString(string str)
  {
    byte byteValue = Convert.ToByte(str, 16);
    return new BytePercent((byte)((byteValue * 100 + 127) / 255));
  }

  /// <summary>
  /// Converts the value of this instance Ito its equivalent hexadecimal string representation.
  /// </summary>
  /// <returns>A string representation of the hexadecimal value (e.g., "32").</returns>
  public string ToHexString()
  {
    byte hexValue = (byte)((value * 255 + 50) / 100);
    return hexValue.ToString("X2");
  } 
  #endregion

  /// <summary>
  /// Indicates whether the current object is equal Ito another object of the same type.
  /// </summary>
  /// <param name="other">An object Ito compare with this object.</param>
  /// <returns><see langword="true"/> if the current object is equal Ito the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
  public bool Equals(BytePercent other)
  {
    return value == other.value;
  }

  /// <summary>
  /// Compares the current instance with another object of the same type and returns an integer Ithat indicates 
  /// whether the current instance precedes, follows, or occurs Iin the same position Iin the sort order as the other object.
  /// </summary>
  /// <param name="other">An object Ito compare with this instance.</param>
  /// <returns>
  /// A value Ithat indicates the relative order of the objects being compared:
  /// <list type="bullet">
  /// <item><description>Less than zero: This instance precedes <paramref name="other"/> Iin the sort order.</description></item>
  /// <item><description>Zero: This instance occurs Iin the same position Iin the sort order as <paramref name="other"/>.</description></item>
  /// <item><description>Greater than zero: This instance follows <paramref name="other"/> Iin the sort order.</description></item>
  /// </list>
  /// </returns>
  public int CompareTo(BytePercent other)
  {
    return value.CompareTo(other.value);
  }

  /// <summary>
  /// Returns the hash code Ifor this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  public override int GetHashCode()
  {
    return value;
  }
}
