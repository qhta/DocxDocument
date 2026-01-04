using System.Text.Json.Serialization;

namespace DocumentModel;

/// <summary>
/// Represents a percentage value stored as a byte (0-100), commonly used in Office Open XML documents.
/// </summary>
/// <remarks>
/// <para>
/// This structure provides a type-safe representation of percentage values that are stored as byte values
/// in Office Open XML specifications. It supports conversion between different numeric formats and provides
/// functionality for parsing and formatting percentage strings with "%" suffix.
/// </para>
/// <para>
/// The BytePercent type also supports conversion to/from hexadecimal format (0x00-0xFF scale) which is
/// commonly used in color representations where byte percentages need to be converted to 0-255 range.
/// </para>
/// <para>
/// <b>Usage Examples:</b>
/// <code>
/// // Create from numeric values
/// BytePercent percent1 = new BytePercent(50);        // 50%
/// BytePercent percent2 = new BytePercent("75%");     // 75%
/// BytePercent percent3 = 100;                        // Implicit conversion
/// 
/// // Convert to string
/// string str = percent1.ToString();                  // "50%"
/// string hex = percent1.ToHexString();               // "80" (128 in hex)
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
  /// <param name="val">The string to parse. Can optionally include "%" suffix.</param>
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
    if (val.EndsWith("%"))
      val = val.TrimEnd('%');
    value = byte.Parse(val);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="BytePercent"/> structure from a byte value.
  /// </summary>
  /// <param name="value">The byte value representing the percentage (0-100).</param>
  /// <remarks>
  /// Values are typically in the range 0-100 representing 0% to 100%, though the byte type
  /// allows values up to 255.
  /// </remarks>
  public BytePercent(byte value)
  {
    this.value = value;
  }


  #region IConvertible Implementation

  /// <summary>
  /// Returns the <see cref="TypeCode"/> for this instance.
  /// </summary>
  /// <returns>The enumerated constant <see cref="TypeCode.Byte"/>.</returns>
  public TypeCode GetTypeCode()
  {
    return value.GetTypeCode();
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent Boolean value.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns><see langword="true"/> if the value is not zero; otherwise, <see langword="false"/>.</returns>
  public bool ToBoolean(IFormatProvider? provider)
  {
    return value != 0;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 8-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>An 8-bit unsigned integer equivalent to the value of this instance.</returns>
  public byte ToByte(IFormatProvider? provider)
  {
    return (byte)value;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent Unicode character.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A Unicode character equivalent to the value of this instance.</returns>
  public char ToChar(IFormatProvider? provider)
  {
    return ((IConvertible)value).ToChar(provider);
  }

  /// <summary>
  /// This conversion is not supported. Calling this method always throws <see cref="InvalidCastException"/>.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>This conversion is not supported. No value is returned.</returns>
  /// <exception cref="InvalidCastException">Always thrown as this conversion is not supported.</exception>
  public DateTime ToDateTime(IFormatProvider? provider)
  {
    return ((IConvertible)value).ToDateTime(provider);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent <see cref="Decimal"/> number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A <see cref="Decimal"/> number equivalent to the value of this instance.</returns>
  public decimal ToDecimal(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent double-precision floating-point number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A double-precision floating-point number equivalent to the value of this instance.</returns>
  public double ToDouble(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 16-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 16-bit signed integer equivalent to the value of this instance.</returns>
  public short ToInt16(IFormatProvider? provider)
  {
    return (short)value;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 32-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 32-bit signed integer equivalent to the value of this instance.</returns>
  public int ToInt32(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 64-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 64-bit signed integer equivalent to the value of this instance.</returns>
  public long ToInt64(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 8-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>An 8-bit signed integer equivalent to the value of this instance.</returns>
  public sbyte ToSByte(IFormatProvider? provider)
  {
    return (sbyte)value;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent single-precision floating-point number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A single-precision floating-point number equivalent to the value of this instance.</returns>
  public float ToSingle(IFormatProvider? provider)
  {
    return value;
  }

  /// <summary>
  /// Converts the value of this instance to its equivalent string representation.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>The string representation of the value of this instance without "%" suffix.</returns>
  public string ToString(IFormatProvider? provider)
  {
    return value.ToString(provider);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 16-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 16-bit unsigned integer equivalent to the value of this instance.</returns>
  public ushort ToUInt16(IFormatProvider? provider)
  {
    return (ushort)value;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 32-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 32-bit unsigned integer equivalent to the value of this instance.</returns>
  public uint ToUInt32(IFormatProvider? provider)
  {
    return (uint)value;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 64-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 64-bit unsigned integer equivalent to the value of this instance.</returns>
  public ulong ToUInt64(IFormatProvider? provider)
  {
    return (ulong)value;
  }

  /// <summary>
  /// Converts the value of this instance to an <see cref="Object"/> of the specified <see cref="Type"/> 
  /// that has an equivalent value, using the specified culture-specific formatting information.
  /// </summary>
  /// <param name="targetType">The <see cref="Type"/> to which the value of this instance is converted.</param>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>An <see cref="Object"/> instance of type <paramref name="targetType"/> whose value is equivalent to the value of this instance.</returns>
  /// <remarks>
  /// <para>
  /// This method supports conversion to the following types:
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
  /// This conversion is not supported for the specified <paramref name="targetType"/>.
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
  /// Implicitly converts a string to a <see cref="BytePercent"/> value.
  /// </summary>
  /// <param name="val">The string to convert. Can optionally include "%" suffix.</param>
  /// <returns>A new BytePercent instance parsed from the string.</returns>
  /// <exception cref="FormatException">Thrown when the string cannot be parsed as a valid byte value.</exception>
  public static implicit operator BytePercent(string val)
  {
    return new BytePercent(val);
  }

  /// <summary>
  /// Implicitly converts a <see cref="BytePercent"/> value to a 16-bit unsigned integer.
  /// </summary>
  /// <param name="val">The BytePercent value to convert.</param>
  /// <returns>The underlying byte value cast to UInt16.</returns>
  public static implicit operator ushort(BytePercent val)
  {
    return (ushort)val.value;
  }

  /// <summary>
  /// Implicitly converts a <see cref="BytePercent"/> value to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="val">The BytePercent value to convert.</param>
  /// <returns>The underlying byte value cast to UInt32.</returns>
  public static implicit operator uint(BytePercent val)
  {
    return (uint)val.value;
  }

  /// <summary>
  /// Implicitly converts a <see cref="BytePercent"/> value to a 32-bit signed integer.
  /// </summary>
  /// <param name="val">The BytePercent value to convert.</param>
  /// <returns>The underlying byte value cast to Int32.</returns>
  public static implicit operator Int32(BytePercent val)
  {
    return val.value;
  }

  /// <summary>
  /// Implicitly converts a <see cref="BytePercent"/> value to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="val">The BytePercent value to convert.</param>
  /// <returns>The underlying byte value cast to UInt64.</returns>
  public static implicit operator ulong(BytePercent val)
  {
    return (ulong)val.value;
  }

  /// <summary>
  /// Implicitly converts a 16-bit unsigned integer to a <see cref="BytePercent"/> value.
  /// </summary>
  /// <param name="val">The unsigned integer value to convert.</param>
  /// <returns>A new BytePercent instance with the converted value.</returns>
  /// <remarks>Values greater than 255 will overflow when cast to byte.</remarks>
  public static implicit operator BytePercent(ushort val)
  {
    return new BytePercent((byte)val);
  }

  /// <summary>
  /// Implicitly converts a 32-bit unsigned integer to a <see cref="BytePercent"/> value.
  /// </summary>
  /// <param name="val">The unsigned integer value to convert.</param>
  /// <returns>A new BytePercent instance with the converted value.</returns>
  /// <remarks>Values greater than 255 will overflow when cast to byte.</remarks>
  public static implicit operator BytePercent(uint val)
  {
    return new BytePercent((byte)val);
  }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer to a <see cref="BytePercent"/> value.
  /// </summary>
  /// <param name="val">The signed integer value to convert.</param>
  /// <returns>A new BytePercent instance with the converted value.</returns>
  /// <remarks>Values less than 0 or greater than 255 will overflow when cast to byte.</remarks>
  public static implicit operator BytePercent(Int32 val)
  {
    return new BytePercent((byte)val);
  }

  /// <summary>
  /// Implicitly converts a 64-bit unsigned integer to a <see cref="BytePercent"/> value.
  /// </summary>
  /// <param name="val">The unsigned long value to convert.</param>
  /// <returns>A new BytePercent instance with the converted value.</returns>
  /// <remarks>Values greater than 255 will overflow when cast to byte.</remarks>
  public static implicit operator BytePercent(ulong val)
  {
    return new BytePercent((byte)val);
  }

  /// <summary>
  /// Implicitly converts a <see cref="BytePercent"/> value to a <see cref="HexBinary"/> value.
  /// </summary>
  /// <param name="value">The BytePercent value to convert.</param>
  /// <returns>A new HexBinary instance created from the string representation of the BytePercent value.</returns>
  public static implicit operator HexBinary(BytePercent value) => new HexBinary(value.ToString());

  /// <summary>
  /// Implicitly converts a <see cref="HexBinary"/> value to a <see cref="BytePercent"/> value.
  /// </summary>
  /// <param name="value">The HexBinary value to convert.</param>
  /// <returns>A new BytePercent instance parsed from the HexBinary string representation.</returns>
  public static implicit operator BytePercent(HexBinary value) => new BytePercent(value.ToString());

  #endregion

  /// <summary>
  /// Converts the value of this instance to its equivalent string representation with "%" suffix.
  /// </summary>
  /// <returns>A string representation of the percentage value (e.g., "50%").</returns>
  /// <remarks>
  /// The returned string includes the "%" suffix to clearly indicate the value is a percentage.
  /// For string output without the suffix, use <see cref="ToString(IFormatProvider)"/>.
  /// </remarks>
  public override string ToString()
  {
    return value.ToString() + "%";
  }

  /// <summary>
  /// Indicates whether the current object is equal to another object of the same type.
  /// </summary>
  /// <param name="other">An object to compare with this object.</param>
  /// <returns><see langword="true"/> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
  public bool Equals(BytePercent other)
  {
    return value == other.value;
  }

  /// <summary>
  /// Compares the current instance with another object of the same type and returns an integer that indicates 
  /// whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
  /// </summary>
  /// <param name="other">An object to compare with this instance.</param>
  /// <returns>
  /// A value that indicates the relative order of the objects being compared:
  /// <list type="bullet">
  /// <item><description>Less than zero: This instance precedes <paramref name="other"/> in the sort order.</description></item>
  /// <item><description>Zero: This instance occurs in the same position in the sort order as <paramref name="other"/>.</description></item>
  /// <item><description>Greater than zero: This instance follows <paramref name="other"/> in the sort order.</description></item>
  /// </list>
  /// </returns>
  public int CompareTo(BytePercent other)
  {
    return value.CompareTo(other.value);
  }

  /// <summary>
  /// Returns the hash code for this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  public override int GetHashCode()
  {
    return value;
  }
}