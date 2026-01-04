namespace DocumentModel;

/// <summary>
/// Represents a percentage value stored as a double-precision floating-point number.
/// Supports implicit conversions to/from numeric types and string representations with optional "%" suffix.
/// </summary>
[JsonConverter(typeof(PercentJsonConverter))]
public readonly partial struct Percent : IConvertible, IEquatable<Percent>, IComparable<Percent>
{
  private readonly double value;

  /// <summary>
  /// Initializes a new instance of the <see cref="Percent"/> struct from a string value.
  /// </summary>
  /// <param name="val">The string value to parse. Can include an optional "%" suffix and uses invariant culture for parsing.</param>
  /// <remarks>
  /// Commas in the input string are replaced with periods before parsing to ensure decimal separator consistency.
  /// </remarks>
  public Percent(string val)
  {
    if (val.EndsWith("%"))
      val = val.TrimEnd('%');
    value = double.Parse(val.Replace(",", "."), CultureInfo.InvariantCulture); ;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Percent"/> struct from a double value.
  /// </summary>
  /// <param name="value">The double value representing the percentage.</param>
  public Percent(double value)
  {
    this.value = value;
  }


  #region IConvertible Implementation

  /// <summary>
  /// Returns the <see cref="TypeCode"/> for this instance.
  /// </summary>
  /// <returns>The type code of the underlying double value.</returns>
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
  /// Converts the value of this instance to an equivalent <see cref="DateTime"/>.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A <see cref="DateTime"/> equivalent to the value of this instance.</returns>
  public DateTime ToDateTime(IFormatProvider? provider)
  {
    return ((IConvertible)value).ToDateTime(provider);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent <see cref="decimal"/> number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A <see cref="decimal"/> number equivalent to the value of this instance.</returns>
  public decimal ToDecimal(IFormatProvider? provider)
  {
    return ((IConvertible)value).ToDecimal(provider);
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
    return ((IConvertible)value).ToInt32(provider);
  }

  /// <summary>
  /// Converts the value of this instance to an equivalent 64-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>A 64-bit signed integer equivalent to the value of this instance.</returns>
  public long ToInt64(IFormatProvider? provider)
  {
    return ((IConvertible)value).ToInt64(provider);
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
    return (float)value;
  }

  /// <summary>
  /// Converts the value of this instance to its equivalent string representation using the specified format provider.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>The string representation of the value of this instance as specified by the provider.</returns>
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
  /// Converts the value of this instance to an <see cref="object"/> of the specified <see cref="Type"/> 
  /// that has an equivalent value, using the specified culture-specific formatting information.
  /// </summary>
  /// <param name="targetType">The <see cref="Type"/> to which the value of this instance is converted.</param>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation that supplies culture-specific formatting information.</param>
  /// <returns>An <see cref="object"/> instance of type <paramref name="targetType"/> whose value is equivalent to the value of this instance.</returns>
  public object ToType(Type targetType, IFormatProvider? provider)
  {
    if (targetType == typeof(UInt16))
      return (UInt16)Math.Round(value);
    if (targetType == typeof(Int32))
      return (Int32)Math.Round(value);
    if (targetType == typeof(UInt32))
      return (UInt32)Math.Round(value);
    if (targetType == typeof(Int64))
      return (Int64)Math.Round(value);
    if (targetType == typeof(UInt64))
      return (UInt64)Math.Round(value);
    if (targetType == typeof(Int16))
      return (Int16)Math.Round(value);
    if (targetType == typeof(Byte))
      return (byte)Math.Round(value);
    if (targetType == typeof(SByte))
      return (sbyte)Math.Round(value);
    if (targetType == typeof(Single))
      return (float)(value);
    if (targetType == typeof(Double))
      return value;
    if (targetType == typeof(Decimal))
      return (decimal)value;
    if (targetType == typeof(String))
      return ToString(CultureInfo.InvariantCulture,null);
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
    return (uint)Math.Round(val.value);
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percent"/> value to a 32-bit signed integer.
  /// </summary>
  /// <param name="val">The <see cref="Percent"/> value to convert.</param>
  /// <returns>A 32-bit signed integer representation of the percentage value.</returns>
  public static implicit operator Int32(Percent val)
  {
    return (int)Math.Round(val.value);
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percent"/> value to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="val">The <see cref="Percent"/> value to convert.</param>
  /// <returns>A 64-bit unsigned integer representation of the percentage value.</returns>
  public static implicit operator ulong(Percent val)
  {
    return (ulong)Math.Round(val.value);
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percent"/> value to a double value.
  /// </summary>
  /// <param name="val">The <see cref="Percent"/> value to convert.</param>
  /// <returns>A double representation of the percentage value.</returns>
  public static implicit operator double(Percent val)
  {
    return (double)val.value;
  }

  /// <summary>
  /// Implicitly converts a 16-bit unsigned integer to a <see cref="Percent"/> value.
  /// </summary>
  /// <param name="val">The 16-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="Percent"/>Percent instance.</returns>
  public static implicit operator Percent(ushort val)
  {
    return new Percent((double)val);
  }

  /// <summary>
  /// Implicitly converts a 32-bit unsigned integer to a <see cref="Percent"/> value.
  /// </summary>
  /// <param name="val">The 32-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="Percent"/>Percent instance.</returns>
  public static implicit operator Percent(uint val)
  {
    return new Percent((double)val);
  }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer to a <see cref="Percent"/> value.
  /// </summary>
  /// <param name="val">The 32-bit signed integer to convert.</param>
  /// <returns>A <see cref="Percent"/>Percent instance.</returns>
  public static implicit operator Percent(Int32 val)
  {
    return new Percent((double)val);
  }

  /// <summary>
  /// Implicitly converts a 64-bit unsigned integer to a <see cref="Percent"/> value.
  /// </summary>
  /// <param name="val">The 64-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="Percent"/>Percent instance.</returns>
  public static implicit operator Percent(ulong val)
  {
    return new Percent((double)val);
  }

  /// <summary>
  /// Implicitly converts double value to a <see cref="Percent"/> value.
  /// </summary>
  /// <param name="val">Double value to convert.</param>
  /// <returns>A <see cref="Percent"/>Percent instance.</returns>
  public static implicit operator Percent(double val)
  {
    return new Percent((double)val);
  }

  #endregion

  #region String Conversions

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
  /// Returns the hash code for this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  public override int GetHashCode()
  {
    return value.GetHashCode();
  }
}