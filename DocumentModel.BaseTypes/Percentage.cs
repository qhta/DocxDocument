using System.Net.Security;

namespace DocumentModel;

/// <summary>
/// Represents a percentage value stored as a decimal value to preserve precision.
/// Supports implicit conversions to/from numeric types and string representations with optional "%" suffix.
/// Conversion to/from double and single precision floating-point types means scaling by 100 to support fractional percentages.
/// </summary>
[DataContract]
[JsonConverter(typeof(PercentageJsonConverter))]
public readonly partial struct Percentage : IConvertible, IEquatable<Percentage>, IComparable<Percentage>, IComparable<object>
{
  /// <summary>
  /// Internal decimal representation of the percentage value.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  public readonly Decimal Value;

  /// <summary>
  /// Initializes a new instance of the <see cref="Percentage"/> struct from a string value.
  /// </summary>
  /// <param name="str">The string value to parse. Can include an optional "%" suffix and uses invariant culture for parsing.</param>
  /// <remarks>
  /// Commas in the input string are replaced with periods before parsing to ensure double separator consistency.
  /// </remarks>
  public Percentage(string str)
  {
    if (str.EndsWith("%"))
    {
      str = str.TrimEnd('%');
      var decimalValue = decimal.Parse(str.Replace(',', '.'), CultureInfo.InvariantCulture);
      this.Value = decimalValue;
    }
    else
    {
      var decimalValue = decimal.Parse(str.Replace(',', '.'), CultureInfo.InvariantCulture);
      this.Value = decimalValue;
    }
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Percentage"/> struct from an int value.
  /// </summary>
  /// <param name="value">The int value representing the Percentage.</param>
  public Percentage(int value)
  {
    this.Value = (decimal)(value);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Percentage"/> struct from a double value.
  /// </summary>
  /// <param name="value">The double value representing the Percentage.</param>
  public Percentage(double value)
  {
    this.Value = (decimal)(value * 100);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Percentage"/> struct from a decimal value.
  /// </summary>
  /// <param name="value">The double value representing the Percentage.</param>
  public Percentage(decimal value)
  {
    this.Value = (decimal)(value);
  }

  /// <summary>
  /// Creates a <see cref="Percentage"/> instance from a hexadecimal string representation.
  /// This representation should not contain a '%' suffix but can start with a '#' character.
  /// It should consist of two hexadecimal digits representing a byte value, which is then converted to a percentage
  /// such that 0x00 corresponds to 0% and 0xFF corresponds to 100%.
  /// </summary>
  /// <param name="str">The hexadecimal string representation of the percentage.</param>
  /// <returns>A <see cref="Percentage"/> instance.</returns>
  public static Percentage FromHexString(string str)
  {
    if (str.EndsWith("%"))
    {
      throw new ApplicationException("Hexadecimal string representation should not contain a '%' suffix.");
    }
    if (str.StartsWith("#"))
    {
      str = str.TrimStart('#');
    }
    var byteValue = byte.Parse(str, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
    int intValue = byteValue*100/255; // Convert byte to percentage
    return new Percentage(intValue);
  }

  #region IConvertible Implementation

  /// <summary>
  /// Returns the <see cref="TypeCode"/> for this instance.
  /// </summary>
  /// <returns>The type code of the underlying value.</returns>
  public TypeCode GetTypeCode()
  {
    return TypeCode.Decimal;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent Boolean value.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns><see langword="true"/> if value is not zero; otherwise, <see langword="false"/>.</returns>
  public bool ToBoolean(IFormatProvider? provider = null)
  {
    throw new NotSupportedException("Conversion from Percentage to Boolean is not supported.");
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 8-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>An 8-bit unsigned integer equivalent to the value of this instance.</returns>
  public byte ToByte(IFormatProvider? provider = null)
  {
    return (byte)(Value);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent Unicode character.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A Unicode character equivalent to the value of this instance.</returns>
  public char ToChar(IFormatProvider? provider = null)
  {
    throw new NotSupportedException("Conversion from Percentage to Char is not supported.");
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent <see cref="System.DateTime"/>.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A <see cref="System.DateTime"/> equivalent to the value of this instance.</returns>
  public DateTime ToDateTime(IFormatProvider? provider = null)
  {
    throw new NotSupportedException("Conversion from Percentage to DateTime is not supported.");
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent <see cref="decimal"/> number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A <see cref="decimal"/> number equivalent to the value of this instance.</returns>
  public Decimal ToDecimal(IFormatProvider? provider = null)
  {
    return (decimal)(Value);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent double-precision floating-point number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A double-precision floating-point number equivalent to the value of this instance.</returns>
  public double ToDouble(IFormatProvider? provider = null)
  {
    return (double)(Value) / 100.0;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 16-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 16-bit signed integer equivalent to the value of this instance.</returns>
  public short ToInt16(IFormatProvider? provider = null)
  {
    return (short)(Value);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 32-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 32-bit signed integer equivalent to the value of this instance.</returns>
  public int ToInt32(IFormatProvider? provider = null)
  {
    return (Int32)(Value);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 64-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 64-bit signed integer equivalent to the value of this instance.</returns>
  public long ToInt64(IFormatProvider? provider = null)
  {
    return (Int64)(Value);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 8-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>An 8-bit signed integer equivalent to the value of this instance.</returns>
  public sbyte ToSByte(IFormatProvider? provider = null)
  {
    return (SByte)(Value);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent single-precision floating-point number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A single-precision floating-point number equivalent to the value of this instance.</returns>
  public float ToSingle(IFormatProvider? provider = null)
  {
    return (float)(Value);
  }

  /// <summary>
  /// Converts the value of this instance to its equivalent string representation using the specified format provider.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>The string representation of the value of this instance as specified by the provider.</returns>
  public string ToString(IFormatProvider? provider = null)
  {
    return ToString(provider ?? CultureInfo.InvariantCulture, "%");
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 16-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 16-bit unsigned integer equivalent to the value of this instance.</returns>
  public ushort ToUInt16(IFormatProvider? provider = null)
  {
    return (ushort)(Value);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 32-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 32-bit unsigned integer equivalent to the value of this instance.</returns>
  public uint ToUInt32(IFormatProvider? provider = null)
  {
    return (uint)(Value);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 64-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 64-bit unsigned integer equivalent to the value of this instance.</returns>
  public ulong ToUInt64(IFormatProvider? provider = null)
  {
    return (ulong)(Value);
  }

  /// <summary>
  /// Converts the value of this instance to an <see cref="object"/> of the specified <see cref="Type"/> 
  /// that has an equivalent value, using the specified culture-specific formatting information.
  /// </summary>
  /// <param name="targetType">The <see cref="Type"/> to which the value of this instance is converted.</param>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>An <see cref="object"/> instance of type <paramref name="targetType"/> whose value is equivalent to the value of this instance.</returns>
  public object ToType(Type targetType, IFormatProvider? provider)
  {
    if (targetType == typeof(UInt16))
      return (UInt16)(Value);
    if (targetType == typeof(Int32))
      return (Int32)(Value);
    if (targetType == typeof(UInt32))
      return (UInt32)(Value);
    if (targetType == typeof(Int64))
      return (Int64)(Value);
    if (targetType == typeof(UInt64))
      return (UInt64)(Value);
    if (targetType == typeof(Int16))
      return (Int16)(Value);
    if (targetType == typeof(Byte))
      return (byte)(Value);
    if (targetType == typeof(SByte))
      return (sbyte)(Value);
    if (targetType == typeof(Decimal))
      return (decimal)(Value);
    if (targetType == typeof(Single))
      return (float)(Value) / 100.0f;
    if (targetType == typeof(Double))
      return (double)(Value) / 100.0;
    if (targetType == typeof(String))
      return ToString(CultureInfo.InvariantCulture, null);
    if (targetType == typeof(Percentage))
      return new Percentage(Value);

    return ((IConvertible)Value).ToType(targetType, provider);
  }

  #endregion

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a string to a <see cref="Percentage"/> value.
  /// </summary>
  /// <param name="val">The string to convert.</param>
  /// <returns>A <see cref="Percentage"/> value parsed from the string.</returns>
  public static implicit operator Percentage(string val)
  {
    return new Percentage(val);
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percentage"/> value to a string representation.
  /// </summary>
  /// <param name="val">The <see cref="Percentage"/> value to convert.</param>
  /// <returns>A string representation of the <see cref="Percentage"/> value.</returns>
  public static implicit operator string(Percentage val)
  {
    return val.ToString();
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percentage"/> value to a 16-bit unsigned integer.
  /// </summary>
  /// <param name="val">The <see cref="Percentage"/> value to convert.</param>
  /// <returns>A 16-bit unsigned integer representation of the Percentage value.</returns>
  public static implicit operator ushort(Percentage val)
  {
    return val.ToUInt16();
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percentage"/> value to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="val">The <see cref="Percentage"/> value to convert.</param>
  /// <returns>A 32-bit unsigned integer representation of the Percentage value.</returns>
  public static implicit operator uint(Percentage val)
  {
    return val.ToUInt32();
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percentage"/> value to a 32-bit signed integer.
  /// </summary>
  /// <param name="val">The <see cref="Percentage"/> value to convert.</param>
  /// <returns>A 32-bit signed integer representation of the Percentage value.</returns>
  public static implicit operator Int32(Percentage val)
  {
    return val.ToInt32();
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percentage"/> value to a 64-bit signed integer.
  /// </summary>
  /// <param name="val">The <see cref="Percentage"/> value to convert.</param>
  /// <returns>A 64-bit signed integer representation of the Percentage value.</returns>
  public static implicit operator Int64(Percentage val)
  {
    return val.ToInt64();
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percentage"/> value to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="val">The <see cref="Percentage"/> value to convert.</param>
  /// <returns>A 64-bit unsigned integer representation of the Percentage value.</returns>
  public static implicit operator ulong(Percentage val)
  {
    return val.ToUInt64();
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percentage"/> value to a decimal value.
  /// </summary>
  /// <param name="val">The <see cref="Percentage"/> value to convert.</param>
  /// <returns>A double representation of the Percentage value.</returns>
  public static implicit operator decimal(Percentage val)
  {
    return val.ToDecimal();
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percentage"/> value to a double value.
  /// </summary>
  /// <param name="val">The <see cref="Percentage"/> value to convert.</param>
  /// <returns>A double representation of the Percentage value.</returns>
  public static implicit operator Double(Percentage val)
  {
    return val.ToDouble();
  }

  /// <summary>
  /// Implicitly converts a 16-bit unsigned integer to a <see cref="Percentage"/> value.
  /// </summary>
  /// <param name="val">The 16-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="Percentage"/>Percentage instance.</returns>
  public static implicit operator Percentage(ushort val)
  {
    return new Percentage(val);
  }

  /// <summary>
  /// Implicitly converts a 32-bit unsigned integer to a <see cref="Percentage"/> value.
  /// </summary>
  /// <param name="val">The 32-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="Percentage"/>Percentage instance.</returns>
  public static implicit operator Percentage(double val)
  {
    return new Percentage(val);
  }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer to a <see cref="Percentage"/> value.
  /// </summary>
  /// <param name="val">The 32-bit signed integer to convert.</param>
  /// <returns>A <see cref="Percentage"/>Percentage instance.</returns>
  public static implicit operator Percentage(Int32 val)
  {
    return new Percentage(val);
  }

  #endregion

  #region String Conversions

  /// <summary>
  /// Parses a string representation of a Percentage and returns a corresponding Percentage instance.
  /// </summary>
  /// <param name="str">The string containing the Percentage to parse. The string should be in a format recognized by the Percentage type,
  /// such as "50%" or "0.5".</param>
  /// <returns>A Percentage instance that represents the value specified by the input string.</returns>
  public static Percentage Parse(string str)
  {
    return new Percentage(str);
  }

  /// <summary>
  /// Attempts to parse a string representation of a Percentage into a <see cref="Percentage"/> instance.
  /// </summary>
  /// <param name="str">The string representation of the Percentage.</param>
  /// <param name="result">The resulting <see cref="Percentage"/> instance if parsing is successful.</param>
  /// <returns><see langword="true"/> if parsing succeeded; otherwise, <see langword="false"/>.</returns>
  public static bool TryParse(string str, out Percentage result)
  {
    try
    {
      result = new Percentage(str);
      return true;
    }
    catch
    {
      result = default;
      return false;
    }
  }

  /// <summary>
  /// Converts the value of this instance to its equivalent string representation with a "%" suffix.
  /// </summary>
  /// <returns>The string representation of the value with a "%" suffix, using invariant culture formatting.</returns>
  public override string ToString()
  {
    return ToString(System.Globalization.CultureInfo.InvariantCulture, "%");
  }

  /// <summary>
  /// Converts value to string using the specified unit.
  /// </summary>
  /// <param name="unit">The unit suffix (e.g., "%") to append to the value, or <see langword="null"/> for no suffix.</param>
  /// <returns>The string representation of the value with the specified unit suffix.</returns>
  public string ToString(string? unit)
  {
    return ToString(System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts value to string using the specified unit and precision (fractional digits count).
  /// </summary>
  /// <param name="precision">The number of fractional digits in the return value.</param>
  /// <param name="unit">The unit suffix (e.g., "%") to append to the value, or <see langword="null"/> for no suffix.</param>
  /// <returns>The string representation of the value with the specified precision and unit suffix.</returns>
  public string ToString(int precision, string? unit)
  {
    return ToString(precision, System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts value to string using the specified unit, precision (fractional digits count),
  /// and format provider to determine digit separator. Fixed format is used.
  /// </summary>
  /// <param name="precision">The number of fractional digits in the return value.</param>
  /// <param name="provider">An <see cref="IFormatProvider"/> that supplies culture-specific formatting information.</param>
  /// <param name="unit">The unit suffix (e.g., "%") to append to the value, or <see langword="null"/> for no suffix.</param>
  /// <returns>The string representation of the value with the specified precision, format provider, and unit suffix.</returns>
  public string ToString(int precision, IFormatProvider provider, string? unit)
  {
    string format = $"F{precision}";
    if (unit == "%")
    {
      return ToDecimal().ToString(format, provider) + unit;
    }
    else if (String.IsNullOrEmpty(unit))
    {
      return ToDecimal().ToString(provider);
    }
    throw new NotSupportedException($"The unit '{unit}' is not supported.");
  }

  /// <summary>
  /// Converts value to string using the specified unit and format provider to determine digit separator.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> that supplies culture-specific formatting information.</param>
  /// <param name="unit">The unit suffix (e.g., "%") to append to the value, or <see langword="null"/> for no suffix.</param>
  /// <returns>The string representation of the value with the specified format provider and unit suffix.</returns>
  public string ToString(IFormatProvider provider, string? unit)
  {
    if (unit == "%" || string.IsNullOrEmpty(unit))
    {
      var str = Value.ToString(provider);
      return str + unit;
    }
    throw new NotSupportedException($"The unit '{unit}' is not supported.");
  }

  #endregion

  /// <summary>
  /// Indicates whether the current object is equal to another object of the same type.
  /// </summary>
  /// <param name="other">An object to compare with this object.</param>
  /// <returns><see langword="true"/> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
  public bool Equals(Percentage other)
  {
    return Value == other.Value;
  }

  /// <summary>
  /// Compares this instance to a specified <see cref="Percentage"/> object and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">A <see cref="Percentage"/> object to compare.</param>
  /// <returns>
  /// A signed number indicating the relative values of this instance and <paramref name="other"/>.
  /// Less than zero if this instance is less than <paramref name="other"/>;
  /// zero if this instance equals <paramref name="other"/>;
  /// greater than zero if this instance is greater than <paramref name="other"/>.
  /// </returns>
  public int CompareTo(Percentage other)
  {
    return Value.CompareTo(other.Value);
  }

  /// <summary>
  /// Compares this instance to a specified object and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">Any object to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  /// <exception cref="ArgumentException">Thrown when the comparison is invalid.</exception>
  public int CompareTo(object? other)
  {
    if (other is Percentage Percentage)
      return CompareTo(Percentage);
    if (other is Int32 int32value)
      return this.Value.CompareTo(int32value);
    if (other is UInt32 uint32value)
      return this.Value.CompareTo(uint32value);
    if (other is Int64 int64value)
      return this.Value.CompareTo(int64value);
    if (other is UInt64 uint64value)
      return this.Value.CompareTo((long)(uint64value));
    if (other is Int16 int16value)
      return this.Value.CompareTo(int16value);
    if (other is UInt16 uint16value)
      return this.Value.CompareTo(uint16value);
    if (other is SByte sByteValue)
      return this.Value.CompareTo(sByteValue);
    if (other is Byte byteValue)
      return this.Value.CompareTo(byteValue);
    if (other is Decimal decimalValue)
      return this.Value.CompareTo(decimalValue);
    if (other is Single singleValue)
      return this.Value.CompareTo(singleValue / 100.0f);
    if (other is double doubleValue)
      return this.Value.CompareTo(doubleValue / 100.0);
    if (other is String str)
      return this.CompareTo(Percentage.Parse(str));
    throw new ArgumentException($"Invalid comparison between {GetType()} and {other?.GetType()}");
  }

  /// <summary>
  /// Returns the hash code for this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  public override int GetHashCode()
  {
    return ((double)this).GetHashCode();
  }
}
