namespace DocumentModel;

/// <summary>
/// Represents a drawing angle value stored as a 32-bit integer, where the value is scaled by 60000 to preserve precision.
/// So, for example, a value of 180 degrees is stored as 10800000, and a value of 0.5 degrees is stored as 30000.
/// Supports implicit conversions to/from numeric types and string representations with an optional "°" suffix.
/// </summary>
[DataContract]
[JsonConverter(typeof(DegreesJsonConverter))]
public readonly partial struct Degrees : IConvertible, IEquatable<Degrees>, IComparable<Degrees>, IComparable<object>
{
  private readonly Int32 value;
  private const int scale = 60000;


  /// <summary>
  /// Initializes a new instance of the <see cref="Degrees"/> struct from a string value.
  /// </summary>
  /// <param name="str">The string value to parse. Can include an optional "°" suffix and uses invariant culture for parsing.</param>
  /// <remarks>
  /// Commas in the input string are replaced with periods before parsing to ensure double separator consistency.
  /// </remarks>
  public Degrees(string str)
  {
    if (str.EndsWith("°"))
    {
      str = str.TrimEnd('°');
    }
    var decimalValue = decimal.Parse(str.Replace(",", "."), CultureInfo.InvariantCulture);
    this.value = (int)(decimalValue * scale);
    
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Degrees"/> struct from an int value.
  /// </summary>
  /// <param name="value">The int value representing the Degrees.</param>
  public Degrees(int value)
  {
    this.value = value * scale;
  }


  /// <summary>
  /// Initializes a new instance of the <see cref="Degrees"/> struct from an Int64 value.
  /// </summary>
  /// <param name="value">The int value representing the Degrees.</param>
  public Degrees(Int64 value)
  {
    this.value = (int)(value * scale);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Degrees"/> struct from a double value.
  /// </summary>
  /// <param name="value">The double value representing the Degrees.</param>
  public Degrees(double value)
  {
    this.value = (int)(value * scale);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Degrees"/> struct from a decimal value.
  /// </summary>
  /// <param name="value">The double value representing the Degrees.</param>
  public Degrees(decimal value)
  {
    this.value = (int)(value * scale);
  }


  /// <summary>
  /// Initializes a new instance of the <see cref="Degrees"/> struct from an UInt64 value.
  /// </summary>
  /// <param name="value">The UInt64 value representing the Degrees.</param>
  public Degrees(UInt64 value)
  {
    this.value = (int)(value * scale);
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
    throw new NotSupportedException("Conversion from Degrees to Boolean is not supported.");
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 8-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>An 8-bit unsigned integer equivalent to the value of this instance.</returns>
  public byte ToByte(IFormatProvider? provider = null)
  {
    return (byte)(value / scale);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent Unicode character.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A Unicode character equivalent to the value of this instance.</returns>
  public char ToChar(IFormatProvider? provider = null)
  {
    throw new NotSupportedException("Conversion from Degrees to Char is not supported.");
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent <see cref="System.DateTime"/>.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A <see cref="System.DateTime"/> equivalent to the value of this instance.</returns>
  public DateTime ToDateTime(IFormatProvider? provider = null)
  {
    throw new NotSupportedException("Conversion from Degrees to DateTime is not supported.");
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent <see cref="decimal"/> number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A <see cref="decimal"/> number equivalent to the value of this instance.</returns>
  public Decimal ToDecimal(IFormatProvider? provider = null)
  {
    return (decimal)(value) / scale;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent double-precision floating-point number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A double-precision floating-point number equivalent to the value of this instance.</returns>
  public double ToDouble(IFormatProvider? provider = null)
  {
    return (double)(value) / scale;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 16-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 16-bit signed integer equivalent to the value of this instance.</returns>
  public short ToInt16(IFormatProvider? provider = null)
  {
    return (short)(value / scale);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 32-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 32-bit signed integer equivalent to the value of this instance.</returns>
  public int ToInt32(IFormatProvider? provider = null)
  {
    return (Int32)(value / scale);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 64-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 64-bit signed integer equivalent to the value of this instance.</returns>
  public long ToInt64(IFormatProvider? provider = null)
  {
    return (Int64)(value / scale);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 8-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>An 8-bit signed integer equivalent to the value of this instance.</returns>
  public sbyte ToSByte(IFormatProvider? provider = null)
  {
    return (SByte)(value / scale);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent single-precision floating-point number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A single-precision floating-point number equivalent to the value of this instance.</returns>
  public float ToSingle(IFormatProvider? provider = null)
  {
    return (float)((double)value / scale);
  }

  /// <summary>
  /// Converts the value of this instance to its equivalent string representation using the specified format provider.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>The string representation of the value of this instance as specified by the provider.</returns>
  public string ToString(IFormatProvider? provider = null)
  {
    return ToDecimal().ToString(provider) + "°";
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 16-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 16-bit unsigned integer equivalent to the value of this instance.</returns>
  public ushort ToUInt16(IFormatProvider? provider = null)
  {
    return (ushort)(value / scale);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 32-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 32-bit unsigned integer equivalent to the value of this instance.</returns>
  public uint ToUInt32(IFormatProvider? provider = null)
  {
    return (uint)(value / scale);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 64-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 64-bit unsigned integer equivalent to the value of this instance.</returns>
  public ulong ToUInt64(IFormatProvider? provider = null)
  {
    return (ulong)(value / scale);
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
      return (UInt16)(value / scale);
    if (targetType == typeof(Int32))
      return (Int32)(value / scale);
    if (targetType == typeof(UInt32))
      return (UInt32)(value / scale);
    if (targetType == typeof(Int64))
      return (Int64)(value / scale);
    if (targetType == typeof(UInt64))
      return (UInt64)(value / scale);
    if (targetType == typeof(Int16))
      return (Int16)(value / scale);
    if (targetType == typeof(Byte))
      return (byte)(value / scale);
    if (targetType == typeof(SByte))
      return (sbyte)(value / scale);
    if (targetType == typeof(Single))
      return (float)((double)value / scale);
    if (targetType == typeof(Double))
      return (double)((double)value / scale);
    if (targetType == typeof(decimal))
      return (decimal)((decimal)value / scale);
    if (targetType == typeof(String))
      return ToString(CultureInfo.InvariantCulture, null);
    if (targetType == typeof(Degrees))
      return new Degrees(value);

    return ((IConvertible)value).ToType(targetType, provider);
  }

  #endregion

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a string to a <see cref="Degrees"/> value.
  /// </summary>
  /// <param name="val">The string to convert.</param>
  /// <returns>A <see cref="Degrees"/> value parsed from the string.</returns>
  public static implicit operator Degrees(string val)
  {
    return new Degrees(val);
  }

  /// <summary>
  /// Implicitly converts a <see cref="Degrees"/> value to a 16-bit unsigned integer.
  /// </summary>
  /// <param name="val">The <see cref="Degrees"/> value to convert.</param>
  /// <returns>A 16-bit unsigned integer representation of the Degrees value.</returns>
  public static implicit operator ushort(Degrees val)
  {
    return val.ToUInt16();
  }

  /// <summary>
  /// Implicitly converts a <see cref="Degrees"/> value to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="val">The <see cref="Degrees"/> value to convert.</param>
  /// <returns>A 32-bit unsigned integer representation of the Degrees value.</returns>
  public static implicit operator uint(Degrees val)
  {
    return val.ToUInt32();
  }

  /// <summary>
  /// Implicitly converts a <see cref="Degrees"/> value to a 32-bit signed integer.
  /// </summary>
  /// <param name="val">The <see cref="Degrees"/> value to convert.</param>
  /// <returns>A 32-bit signed integer representation of the Degrees value.</returns>
  public static implicit operator Int32(Degrees val)
  {
    return val.ToInt32();
  }


  /// <summary>
  /// Implicitly converts a <see cref="Degrees"/> value to a 64-bit signed integer.
  /// </summary>
  /// <param name="val">The <see cref="Degrees"/> value to convert.</param>
  /// <returns>A 64-bit signed integer representation of the Degrees value.</returns>
  public static implicit operator Int64(Degrees val)
  {
    return val.ToInt64();
  }

  /// <summary>
  /// Implicitly converts a <see cref="Degrees"/> value to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="val">The <see cref="Degrees"/> value to convert.</param>
  /// <returns>A 64-bit unsigned integer representation of the Degrees value.</returns>
  public static implicit operator ulong(Degrees val)
  {
    return val.ToUInt64();
  }

  /// <summary>
  /// Implicitly converts a <see cref="Degrees"/> value to a decimal value.
  /// </summary>
  /// <param name="val">The <see cref="Degrees"/> value to convert.</param>
  /// <returns>A double representation of the Degrees value.</returns>
  public static implicit operator decimal(Degrees val)
  {
    return val.ToDecimal();
  }

  /// <summary>
  /// Implicitly converts a <see cref="Degrees"/> value to a double value.
  /// </summary>
  /// <param name="val">The <see cref="Degrees"/> value to convert.</param>
  /// <returns>A double representation of the Degrees value.</returns>
  public static implicit operator Double(Degrees val)
  {
    return val.ToDouble();
  }

  /// <summary>
  /// Implicitly converts a 16-bit unsigned integer to a <see cref="Degrees"/> value.
  /// </summary>
  /// <param name="val">The 16-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="Degrees"/>Degrees instance.</returns>
  public static implicit operator Degrees(ushort val)
  {
    return new Degrees(val);
  }

  /// <summary>
  /// Implicitly converts a 32-bit unsigned integer to a <see cref="Degrees"/> value.
  /// </summary>
  /// <param name="val">The 32-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="Degrees"/>Degrees instance.</returns>
  public static implicit operator Degrees(double val)
  {
    return new Degrees(val);
  }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer to a <see cref="Degrees"/> value.
  /// </summary>
  /// <param name="val">The 32-bit signed integer to convert.</param>
  /// <returns>A <see cref="Degrees"/>Degrees instance.</returns>
  public static implicit operator Degrees(Int32 val)
  {
    return new Degrees(val);
  }

  /// <summary>
  /// Implicitly converts a 64-bit unsigned integer to a <see cref="Degrees"/> value.
  /// </summary>
  /// <param name="val">The 64-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="Degrees"/>Degrees instance.</returns>
  public static implicit operator Degrees(ulong val)
  {
    return new Degrees(val);
  }

  #endregion

  #region String Conversions

  /// <summary>
  /// Parses a string representation of a Degrees and returns a corresponding Degrees instance.
  /// </summary>
  /// <param name="str">The string containing the Degrees to parse. The string should be in a format recognized by the Degrees type,
  /// such as "50°" or "0.5".</param>
  /// <returns>A Degrees instance that represents the value specified by the input string.</returns>
  public static Degrees Parse(string str)
  {
    return new Degrees(str);
  }

  /// <summary>
  /// Attempts to parse a string representation of a Degrees into a <see cref="Degrees"/> instance.
  /// </summary>
  /// <param name="str">The string representation of the Degrees.</param>
  /// <param name="result">The resulting <see cref="Degrees"/> instance if parsing is successful.</param>
  /// <returns><see langword="true"/> if parsing succeeded; otherwise, <see langword="false"/>.</returns>
  public static bool TryParse(string str, out Degrees result)
  {
    try
    {
      result = new Degrees(str);
      return true;
    }
    catch
    {
      result = default;
      return false;
    }
  }

  /// <summary>
  /// Converts the value of this instance to its equivalent string representation with a "°" suffix.
  /// </summary>
  /// <returns>The string representation of the value with a "°" suffix, using invariant culture formatting.</returns>
  public override string ToString()
  {
    return ToDecimal().ToString(CultureInfo.InvariantCulture) + "°";
  }

  /// <summary>
  /// Converts value to string using the specified unit.
  /// </summary>
  /// <param name="unit">The unit suffix (e.g., "°") to append to the value, or <see langword="null"/> for no suffix.</param>
  /// <returns>The string representation of the value with the specified unit suffix.</returns>
  public string ToString(string? unit)
  {
    return ToString(System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts value to string using the specified unit and precision (fractional digits count).
  /// </summary>
  /// <param name="precision">The number of fractional digits in the return value.</param>
  /// <param name="unit">The unit suffix (e.g., "°") to append to the value, or <see langword="null"/> for no suffix.</param>
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
  /// <param name="unit">The unit suffix (e.g., "°") to append to the value, or <see langword="null"/> for no suffix.</param>
  /// <returns>The string representation of the value with the specified precision, format provider, and unit suffix.</returns>
  public string ToString(int precision, IFormatProvider provider, string? unit)
  {
    string format = $"F{precision}";
    if (unit == "°")
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
  /// <param name="unit">The unit suffix (e.g., "°") to append to the value, or <see langword="null"/> for no suffix.</param>
  /// <returns>The string representation of the value with the specified format provider and unit suffix.</returns>
  public string ToString(IFormatProvider provider, string? unit)
  {
    if (unit == "°")
    {
      return ToDecimal().ToString(provider) + unit;
    }
    else if (String.IsNullOrEmpty(unit))
    {
      return ToDecimal().ToString(provider);
    }
    throw new NotSupportedException($"The unit '{unit}' is not supported.");
  }

  #endregion

  /// <summary>
  /// Indicates whether the current object is equal to another object of the same type.
  /// </summary>
  /// <param name="other">An object to compare with this object.</param>
  /// <returns><see langword="true"/> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
  public bool Equals(Degrees other)
  {
    return value == other.value;
  }

  /// <summary>
  /// Compares this instance to a specified <see cref="Degrees"/> object and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">A <see cref="Degrees"/> object to compare.</param>
  /// <returns>
  /// A signed number indicating the relative values of this instance and <paramref name="other"/>.
  /// Less than zero if this instance is less than <paramref name="other"/>;
  /// zero if this instance equals <paramref name="other"/>;
  /// greater than zero if this instance is greater than <paramref name="other"/>.
  /// </returns>
  public int CompareTo(Degrees other)
  {
    return value.CompareTo(other.value);
  }

  /// <summary>
  /// Compares this instance to a specified object and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">Any object to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  /// <exception cref="ArgumentException">Thrown when the comparison is invalid.</exception>
  public int CompareTo(object? other)
  {
    if (other is Degrees Degrees)
      return CompareTo(Degrees);
    if (other is Int32 int32value)
      return this.CompareTo(new Degrees(int32value));
    if (other is UInt32 uint32value)
      return this.CompareTo(new Degrees(uint32value));
    if (other is Int64 int64value)
      return this.CompareTo(new Degrees(int64value));
    if (other is UInt64 uint64value)
      return this.CompareTo(new Degrees(uint64value));
    if (other is Int16 int16value)
      return this.CompareTo(new Degrees(int16value));
    if (other is UInt16 uint16value)
      return this.CompareTo(new Degrees(uint16value));
    if (other is SByte sByteValue)
      return this.CompareTo(new Degrees(sByteValue));
    if (other is Byte byteValue)
      return this.CompareTo(new Degrees(byteValue));
    if (other is Single singleValue)
      return this.CompareTo(new Degrees(singleValue));
    if (other is decimal decimalValue)
      return this.CompareTo(new Degrees(decimalValue));
    if (other is double doubleValue)
      return this.CompareTo(new Degrees(doubleValue));
    if (other is String str)
      return this.CompareTo(Degrees.Parse(str));
    throw new ArgumentException($"Invalid comparison between {GetType()} and {other?.GetType()}");
  }

  /// <summary>
  /// Returns the hash code for this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  public override int GetHashCode()
  {
    return value.GetHashCode();
  }
}
