namespace DocumentModel;

/// <summary>
/// Represents a percentage value stored as a double-precision floating-point number.
/// Supports implicit conversions to/from numeric types and string representations with optional "%" suffix.
/// </summary>
[JsonConverter(typeof(PercentJsonConverter))]
public readonly partial struct Percent : IConvertible, IEquatable<Percent>, IComparable<Percent>, IComparable<object>
{
  private readonly int value;

  /// <summary>
  /// Initializes a new instance of the <see cref="Percent"/> struct from a string value.
  /// </summary>
  /// <param name="str">The string value to parse. Can include an optional "%" suffix and uses invariant culture for parsing.</param>
  /// <remarks>
  /// Commas in the input string are replaced with periods before parsing to ensure decimal separator consistency.
  /// </remarks>
  public Percent(string str)
  {
    str = str.TrimEnd('%');
    value = int.Parse(str.Replace(",", "."), CultureInfo.InvariantCulture);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Percent"/> struct from a byte value.
  /// </summary>
  /// <param name="value">The byte value representing the percentage.</param>
  public Percent(byte value)
  {
    this.value = (int)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Percent"/> struct from a SByte value.
  /// </summary>
  /// <param name="value">The SByte value representing the percentage.</param>
  public Percent(sbyte value)
  {
    this.value = (int)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Percent"/> struct from an Int16 value.
  /// </summary>
  /// <param name="value">The Int16 value representing the percentage.</param>
  public Percent(Int16 value)
  {
    this.value = (int)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Percent"/> struct from an Int32 value.
  /// </summary>
  /// <param name="value">The Int32 value representing the percentage.</param>
  public Percent(Int32 value)
  {
    this.value = (int)value;
  }


  /// <summary>
  /// Initializes a new instance of the <see cref="Percent"/> struct from an Int64 value.
  /// </summary>
  /// <param name="value">The int value representing the percentage.</param>
  public Percent(Int64 value)
  {
    this.value = (int)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Percent"/> struct from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value representing the percentage.</param>
  public Percent(UInt16 value)
  {
    this.value = (int)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Percent"/> struct from an UInt32 value.
  /// </summary>
  /// <param name="value">The UInt32 value representing the percentage.</param>
  public Percent(UInt32 value)
  {
    this.value = (int)value;
  }


  /// <summary>
  /// Initializes a new instance of the <see cref="Percent"/> struct from an UInt64 value.
  /// </summary>
  /// <param name="value">The UInt value representing the percentage.</param>
  public Percent(UInt64 value)
  {
    this.value = (int)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Percent"/> struct from a Decimal value.
  /// </summary>
  /// <param name="value">The Decimal value representing the percentage.</param>
  public Percent(Decimal value)
  {
    this.value = (int)value;
  }


  /// <summary>
  /// Initializes a new instance of the <see cref="Percent"/> struct from a Single value.
  /// </summary>
  /// <param name="value">The Single value representing the percentage.</param>
  public Percent(Single value)
  {
    this.value = (int)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Percent"/> struct from a Double value.
  /// </summary>
  /// <param name="value">The Double value representing the percentage.</param>
  public Percent(Double value)
  {
    this.value = (int)value;
  }

  #region IConvertible Implementation

  /// <summary>
  /// Returns the <see cref="TypeCode"/> for this instance.
  /// </summary>
  /// <returns>The type code of the underlying value.</returns>
  public TypeCode GetTypeCode()
  {
    return value.GetTypeCode();
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent Boolean value.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns><see langword="true"/> if value is not zero; otherwise, <see langword="false"/>.</returns>
  public bool ToBoolean(IFormatProvider? provider)
  {
    throw new NotSupportedException("Conversion from Percent to Boolean is not supported.");
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 8-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>An 8-bit unsigned integer equivalent to the value of this instance.</returns>
  public byte ToByte(IFormatProvider? provider)
  {
    return (byte)(value);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent Unicode character.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A Unicode character equivalent to the value of this instance.</returns>
  public char ToChar(IFormatProvider? provider)
  {
    throw new NotSupportedException("Conversion from Percent to Char is not supported.");
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent <see cref="DateTime"/>.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A <see cref="DateTime"/> equivalent to the value of this instance.</returns>
  public DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new NotSupportedException("Conversion from Percent to DateTime is not supported.");
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent <see cref="decimal"/> number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A <see cref="decimal"/> number equivalent to the value of this instance.</returns>
  public decimal ToDecimal(IFormatProvider? provider)
  {
    return (Decimal)(value);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent double-precision floating-point number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A double-precision floating-point number equivalent to the value of this instance.</returns>
  public double ToDouble(IFormatProvider? provider)
  {
    return (double)value;
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 16-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 16-bit signed integer equivalent to the value of this instance.</returns>
  public short ToInt16(IFormatProvider? provider)
  {
    return (short)(value);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 32-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 32-bit signed integer equivalent to the value of this instance.</returns>
  public int ToInt32(IFormatProvider? provider)
  {
    return (Int32)(value);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 64-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 64-bit signed integer equivalent to the value of this instance.</returns>
  public long ToInt64(IFormatProvider? provider)
  {
    return (Int64)(value);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 8-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>An 8-bit signed integer equivalent to the value of this instance.</returns>
  public sbyte ToSByte(IFormatProvider? provider)
  {
    return (SByte)(value);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent single-precision floating-point number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A single-precision floating-point number equivalent to the value of this instance.</returns>
  public float ToSingle(IFormatProvider? provider)
  {
    return (float)value;
  }

  /// <summary>
  /// Converts the value of this instance to its equivalent string representation using the specified format provider.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>The string representation of the value of this instance as specified by the provider.</returns>
  public string ToString(IFormatProvider? provider)
  {
    return value.ToString(provider) + "%";
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 16-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 16-bit unsigned integer equivalent to the value of this instance.</returns>
  public ushort ToUInt16(IFormatProvider? provider)
  {
    return (ushort)(value);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 32-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 32-bit unsigned integer equivalent to the value of this instance.</returns>
  public uint ToUInt32(IFormatProvider? provider)
  {
    return (uint)(value);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 64-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 64-bit unsigned integer equivalent to the value of this instance.</returns>
  public ulong ToUInt64(IFormatProvider? provider)
  {
    return (ulong)(value);
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
      return (UInt16)value;
    if (targetType == typeof(Int32))
      return (Int32)value;
    if (targetType == typeof(UInt32))
      return (UInt32)value;
    if (targetType == typeof(Int64))
      return (Int64)value;
    if (targetType == typeof(UInt64))
      return (UInt64)value;
    if (targetType == typeof(Int16))
      return (Int16)value;
    if (targetType == typeof(Byte))
      return (byte)value;
    if (targetType == typeof(SByte))
      return (sbyte)value;
    if (targetType == typeof(Single))
      return (float)(value);
    if (targetType == typeof(Double))
      return (double)value;
    if (targetType == typeof(Decimal))
      return (decimal)value;
    if (targetType == typeof(String))
      return ToString(CultureInfo.InvariantCulture, null);
    if (targetType == typeof(Percent))
      return new Percent(value);

    return ((IConvertible)value).ToType(targetType, provider);
  }

  #endregion

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a string to a <see cref="Percent"/> value.
  /// </summary>
  /// <param name="val">The string to convert.</param>
  /// <returns>A <see cref="Percent"/> value parsed from the string.</returns>
  public static implicit operator Percent(string val)
  {
    return new Percent(val);
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percent"/> value to a 16-bit unsigned integer.
  /// </summary>
  /// <param name="val">The <see cref="Percent"/> value to convert.</param>
  /// <returns>A 16-bit unsigned integer representation of the percentage value.</returns>
  public static implicit operator ushort(Percent val)
  {
    return (ushort)val.value;
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percent"/> value to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="val">The <see cref="Percent"/> value to convert.</param>
  /// <returns>A 32-bit unsigned integer representation of the percentage value.</returns>
  public static implicit operator uint(Percent val)
  {
    return (uint)val.value;
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percent"/> value to a 32-bit signed integer.
  /// </summary>
  /// <param name="val">The <see cref="Percent"/> value to convert.</param>
  /// <returns>A 32-bit signed integer representation of the percentage value.</returns>
  public static implicit operator Int32(Percent val)
  {
    return (int)val.value;
  }


  /// <summary>
  /// Implicitly converts a <see cref="Percent"/> value to a 64-bit signed integer.
  /// </summary>
  /// <param name="val">The <see cref="Percent"/> value to convert.</param>
  /// <returns>A 64-bit signed integer representation of the percentage value.</returns>
  public static implicit operator Int64(Percent val)
  {
    return (long)val.value;
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percent"/> value to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="val">The <see cref="Percent"/> value to convert.</param>
  /// <returns>A 64-bit unsigned integer representation of the percentage value.</returns>
  public static implicit operator ulong(Percent val)
  {
    return (ulong)val.value;
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percent"/> value to a decimal value.
  /// </summary>
  /// <param name="val">The <see cref="Percent"/> value to convert.</param>
  /// <returns>A decimal representation of the percentage value.</returns>
  public static implicit operator Decimal(Percent val)
  {
    return (Decimal)val.value;
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percent"/> value to a double value.
  /// </summary>
  /// <param name="val">The <see cref="Percent"/> value to convert.</param>
  /// <returns>A decimal representation of the percentage value.</returns>
  public static implicit operator Double(Percent val)
  {
    return (Double)val.value;
  }

  /// <summary>
  /// Implicitly converts a 16-bit unsigned integer to a <see cref="Percent"/> value.
  /// </summary>
  /// <param name="val">The 16-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="Percent"/>Percent instance.</returns>
  public static implicit operator Percent(ushort val)
  {
    return new Percent(val);
  }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer to a <see cref="Percent"/> value.
  /// </summary>
  /// <param name="val">The 32-bit signed integer to convert.</param>
  /// <returns>A <see cref="Percent"/>Percent instance.</returns>
  public static implicit operator Percent(Int32 val)
  {
    return new Percent(val);
  }

  /// <summary>
  /// Implicitly converts a 64-bit unsigned integer to a <see cref="Percent"/> value.
  /// </summary>
  /// <param name="val">The 64-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="Percent"/>Percent instance.</returns>
  public static implicit operator Percent(ulong val)
  {
    return new Percent((decimal)val);
  }


  /// <summary>
  /// Implicitly converts a double value to a <see cref="Percent"/> value.
  /// </summary>
  /// <param name="val">The double value to convert.</param>
  /// <returns>A <see cref="Percent"/>Percent instance.</returns>
  public static implicit operator Percent(double val)
  {
    return new Percent((decimal)val);
  }

  /// <summary>
  /// Implicitly converts a decimal value to a <see cref="Percent"/> value.
  /// </summary>
  /// <param name="val">The decimal value to convert.</param>
  /// <returns>A <see cref="Percent"/>Percent instance.</returns>
  public static implicit operator Percent(decimal val)
  {
    return new Percent(val);
  }

  #endregion

  #region String Conversions

  /// <summary>
  /// Parses a string representation of a percentage and returns a corresponding Percent instance.
  /// </summary>
  /// <param name="str">The string containing the percentage to parse. The string should be in a format recognized by the Percent type,
  /// such as "50%" or "0.5".</param>
  /// <returns>A Percent instance that represents the value specified by the input string.</returns>
  public static Percent Parse(string str)
  {
    return new Percent(str);
  }

  /// <summary>
  /// Attempts to parse a string representation of a percentage into a <see cref="Percent"/> instance.
  /// </summary>
  /// <param name="str">The string representation of the percentage.</param>
  /// <param name="result">The resulting <see cref="Percent"/> instance if parsing is successful.</param>
  /// <returns><see langword="true"/> if parsing succeeded; otherwise, <see langword="false"/>.</returns>
  public static bool TryParse(string str, out Percent result)
  {
    try
    {
      result = new Percent(str);
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
    return value.ToString(CultureInfo.InvariantCulture) + "%";
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
    if (unit != null)
    {
      if (unit.EndsWith("%"))
        return (value).ToString(format, provider) + unit;
    }
    return value.ToString(provider);
  }

  /// <summary>
  /// Converts value to string using the specified unit and format provider to determine digit separator.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> that supplies culture-specific formatting information.</param>
  /// <param name="unit">The unit suffix (e.g., "%") to append to the value, or <see langword="null"/> for no suffix.</param>
  /// <returns>The string representation of the value with the specified format provider and unit suffix.</returns>
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

  /// <summary>
  /// Indicates whether the current object is equal to another object of the same type.
  /// </summary>
  /// <param name="other">An object to compare with this object.</param>
  /// <returns><see langword="true"/> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
  public bool Equals(Percent other)
  {
    return value == other.value;
  }

  /// <summary>
  /// Compares this instance to a specified <see cref="Percent"/> object and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">A <see cref="Percent"/> object to compare.</param>
  /// <returns>
  /// A signed number indicating the relative values of this instance and <paramref name="other"/>.
  /// Less than zero if this instance is less than <paramref name="other"/>;
  /// zero if this instance equals <paramref name="other"/>;
  /// greater than zero if this instance is greater than <paramref name="other"/>.
  /// </returns>
  public int CompareTo(Percent other)
  {
    return value.CompareTo(other.value);
  }

  /// <summary>
  /// Compares this instance to a specified Byte value and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">An Byte value to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  public int CompareTo(Byte other)
  {
    return value.CompareTo(other);
  }

  /// <summary>
  /// Compares this instance to a specified SByte value and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">An SByte value to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  public int CompareTo(SByte other)
  {
    return value.CompareTo(other);
  }

  /// <summary>
  /// Compares this instance to a specified Int16 value and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">An Int16 value to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  public int CompareTo(Int16 other)
  {
    return value.CompareTo(other);
  }

  /// <summary>
  /// Compares this instance to a specified Int32 value and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">An Int32 value to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  public int CompareTo(Int32 other)
  {
    return value.CompareTo(other);
  }

  /// <summary>
  /// Compares this instance to a specified Int64 value and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">An Int64 value to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  public int CompareTo(Int64 other)
  {
    return value.CompareTo(other);
  }

  /// <summary>
  /// Compares this instance to a specified UInt16 value and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">An UInt16 value to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  public int CompareTo(UInt16 other)
  {
    return value.CompareTo(other);
  }

  /// <summary>
  /// Compares this instance to a specified UInt32 value and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">An UInt32 value to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  public int CompareTo(UInt32 other)
  {
    return value.CompareTo(other);
  }

  /// <summary>
  /// Compares this instance to a specified UInt64 value and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">An UInt64 value to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  public int CompareTo(UInt64 other)
  {
    return value.CompareTo(other);
  }

  /// <summary>
  /// Compares this instance to a specified object and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">Any object to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  /// <exception cref="ArgumentException">Thrown when the comparison is invalid.</exception>
  public int CompareTo(object? other)
  {
    if (other is Percent percent)
      return CompareTo(percent);
    if (other is Int32 int32value)
      return this.CompareTo(int32value);
    if (other is UInt32 uint32value)
      return this.CompareTo(uint32value);
    if (other is Int64 int64value)
      return this.CompareTo(int64value);
    if (other is UInt64 uint64value)
      return this.CompareTo(uint64value);
    if (other is Int16 int16value)
      return this.CompareTo(int16value);
    if (other is UInt16 uint16value)
      return this.CompareTo(uint16value);
    if (other is SByte sByteValue)
      return this.CompareTo(sByteValue);
    if (other is Byte byteValue)
      return this.CompareTo(byteValue);
    if (other is Single singleValue)
      return this.CompareTo((decimal)singleValue);
    if (other is Double doubleValue)
      return this.CompareTo((decimal)doubleValue);
    if (other is Decimal decimalValue)
      return this.CompareTo((decimal)decimalValue);
    if (other is String str)
      return this.CompareTo(Percent.Parse(str));
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