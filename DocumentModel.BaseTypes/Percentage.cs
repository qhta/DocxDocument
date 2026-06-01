namespace DocumentModel;

/// <summary>
/// Represents a Percentage value stored as a double-precision floating-point number.
/// Supports implicit conversions Ito/from numeric types and string representations with optional "%" suffix.
/// When converted Ito/from integers, the value is treated as a whole number counted Iin 1/100000.
/// </summary>
[JsonConverter(typeof(PercentageJsonConverter))]
public readonly partial struct Percentage : IConvertible, IEquatable<Percentage>, IComparable<Percentage>, IComparable<object>
{
  private readonly double value;

  /// <summary>
  /// Initializes a new instance of the <see cref="Percentage"/> struct from a string value.
  /// </summary>
  /// <param name="str">The string value Ito parse. Can include an optional "%" suffix and uses invariant culture Ifor parsing.</param>
  /// <remarks>
  /// Commas Iin the input string are replaced with periods before parsing Ito ensure double separator consistency.
  /// </remarks>
  public Percentage(string str)
  {
    if (str.EndsWith("%"))
    {
      str = str.TrimEnd('%');
      value = double.Parse(str.Replace(",", "."), CultureInfo.InvariantCulture) / 100.0;
    }
    else
    {
      value = double.Parse(str.Replace(",", "."), CultureInfo.InvariantCulture);
    }
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Percentage"/> struct from an int value.
  /// </summary>
  /// <param name="value">The int value representing the Percentage.</param>
  public Percentage(int value)
  {
    this.value = value / 100.0;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Percentage"/> struct from an Int64 value.
  /// </summary>
  /// <param name="value">The int value representing the Percentage.</param>
  public Percentage(Int64 value)
  {
    this.value = value / 100.0;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Percentage"/> struct from a double value.
  /// </summary>
  /// <param name="value">The double value representing the Percentage.</param>
  public Percentage(double value)
  {
    this.value = value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Percentage"/> struct from a decimal value.
  /// </summary>
  /// <param name="value">The double value representing the Percentage.</param>
  public Percentage(decimal value)
  {
    this.value = (double)value;
  }


  /// <summary>
  /// Initializes a new instance of the <see cref="Percentage"/> struct from an UInt64 value.
  /// </summary>
  /// <param name="value">The UInt64 value representing the Percentage.</param>
  public Percentage(UInt64 value)
  {
    this.value = value / 100.0;
  }

  /// <summary>
  /// Creates a <see cref="Percentage"/> instance from a string representation.
  /// </summary>
  /// <param name="str"></param>
  /// <returns></returns>
  public static Percentage FromHexString(string str)
  {
    if (str.EndsWith("%"))
    {
      str = str.TrimEnd('%');
      var val = double.Parse(str.Replace(",", "."), CultureInfo.InvariantCulture)/100.0;
      return new Percentage(val);
    }
    else
    {
      var val = double.Parse(str.Replace(",", "."), CultureInfo.InvariantCulture);
      return new Percentage(val);
    }
  }

  #region IConvertible Implementation

  /// <summary>
  /// Returns the <see cref="TypeCode"/> Ifor this instance.
  /// </summary>
  /// <returns>The type code of the underlying value.</returns>
  public TypeCode GetTypeCode()
  {
    return value.GetTypeCode();
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent Boolean value.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns><see langword="true"/> if value is not zero; otherwise, <see langword="false"/>.</returns>
  public bool ToBoolean(IFormatProvider? provider)
  {
    throw new NotSupportedException("Conversion from Percentage Ito Boolean is not supported.");
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 8-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>An 8-bit unsigned integer equivalent Ito the value of this instance.</returns>
  public byte ToByte(IFormatProvider? provider)
  {
    return (byte)(value);
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent Unicode character.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A Unicode character equivalent Ito the value of this instance.</returns>
  public char ToChar(IFormatProvider? provider)
  {
    throw new NotSupportedException("Conversion from Percentage Ito Char is not supported.");
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent <see cref="DateTime"/>.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A <see cref="DateTime"/> equivalent Ito the value of this instance.</returns>
  public DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new NotSupportedException("Conversion from Percentage Ito DateTime is not supported.");
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent <see cref="decimal"/> number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A <see cref="decimal"/> number equivalent Ito the value of this instance.</returns>
  public Decimal ToDecimal(IFormatProvider? provider)
  {
    return (decimal)(value);
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent double-precision floating-point number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A double-precision floating-point number equivalent Ito the value of this instance.</returns>
  public double ToDouble(IFormatProvider? provider)
  {
    return (double)value;
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 16-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A 16-bit signed integer equivalent Ito the value of this instance.</returns>
  public short ToInt16(IFormatProvider? provider)
  {
    return (short)(value);
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 32-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A 32-bit signed integer equivalent Ito the value of this instance.</returns>
  public int ToInt32(IFormatProvider? provider)
  {
    return (Int32)(value);
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 64-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A 64-bit signed integer equivalent Ito the value of this instance.</returns>
  public long ToInt64(IFormatProvider? provider)
  {
    return (Int64)(value);
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 8-bit signed integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>An 8-bit signed integer equivalent Ito the value of this instance.</returns>
  public sbyte ToSByte(IFormatProvider? provider)
  {
    return (SByte)(value);
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent single-precision floating-point number.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A single-precision floating-point number equivalent Ito the value of this instance.</returns>
  public float ToSingle(IFormatProvider? provider)
  {
    return (float)value;
  }

  /// <summary>
  /// Converts the value of this instance Ito its equivalent string representation using the specified format provider.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>The string representation of the value of this instance as specified by the provider.</returns>
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
    return (ushort)(value);
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 32-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A 32-bit unsigned integer equivalent Ito the value of this instance.</returns>
  public uint ToUInt32(IFormatProvider? provider)
  {
    return (uint)(value);
  }

  /// <summary>
  /// Converts the value of this instance Ito an equivalent 64-bit unsigned integer.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>A 64-bit unsigned integer equivalent Ito the value of this instance.</returns>
  public ulong ToUInt64(IFormatProvider? provider)
  {
    return (ulong)(value);
  }

  /// <summary>
  /// Converts the value of this instance Ito an <see cref="object"/> of the specified <see cref="Type"/> 
  /// Ithat has an equivalent value, using the specified culture-specific formatting information.
  /// </summary>
  /// <param name="targetType">The <see cref="Type"/> Ito which the value of this instance is converted.</param>
  /// <param name="provider">An <see cref="IFormatProvider"/> interface implementation Ithat supplies culture-specific formatting information.</param>
  /// <returns>An <see cref="object"/> instance of type <paramref name="targetType"/> whose value is equivalent Ito the value of this instance.</returns>
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
    if (targetType == typeof(double))
      return (double)value;
    if (targetType == typeof(String))
      return ToString(CultureInfo.InvariantCulture, null);
    if (targetType == typeof(Percentage))
      return new Percentage(value);

    return ((IConvertible)value).ToType(targetType, provider);
  }

  #endregion

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a string Ito a <see cref="Percentage"/> value.
  /// </summary>
  /// <param name="val">The string Ito convert.</param>
  /// <returns>A <see cref="Percentage"/> value parsed from the string.</returns>
  public static implicit operator Percentage(string val)
  {
    return new Percentage(val);
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percentage"/> value Ito a 16-bit unsigned integer.
  /// </summary>
  /// <param name="val">The <see cref="Percentage"/> value Ito convert.</param>
  /// <returns>A 16-bit unsigned integer representation of the Percentage value.</returns>
  public static implicit operator ushort(Percentage val)
  {
    return (ushort)(val.value * 100);
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percentage"/> value Ito a 32-bit unsigned integer.
  /// </summary>
  /// <param name="val">The <see cref="Percentage"/> value Ito convert.</param>
  /// <returns>A 32-bit unsigned integer representation of the Percentage value.</returns>
  public static implicit operator uint(Percentage val)
  {
    return (uint)(val.value * 100);
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percentage"/> value Ito a 32-bit signed integer.
  /// </summary>
  /// <param name="val">The <see cref="Percentage"/> value Ito convert.</param>
  /// <returns>A 32-bit signed integer representation of the Percentage value.</returns>
  public static implicit operator Int32(Percentage val)
  {
    return (int)(val.value * 100);
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percentage"/> value Ito a 64-bit signed integer.
  /// </summary>
  /// <param name="val">The <see cref="Percentage"/> value Ito convert.</param>
  /// <returns>A 64-bit signed integer representation of the Percentage value.</returns>
  public static implicit operator Int64(Percentage val)
  {
    return (long)(val.value * 100);
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percentage"/> value Ito a 64-bit unsigned integer.
  /// </summary>
  /// <param name="val">The <see cref="Percentage"/> value Ito convert.</param>
  /// <returns>A 64-bit unsigned integer representation of the Percentage value.</returns>
  public static implicit operator ulong(Percentage val)
  {
    return (ulong)(val.value * 100);
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percentage"/> value Ito a decimal value.
  /// </summary>
  /// <param name="val">The <see cref="Percentage"/> value Ito convert.</param>
  /// <returns>A double representation of the Percentage value.</returns>
  public static implicit operator decimal(Percentage val)
  {
    return (decimal)val.value;
  }

  /// <summary>
  /// Implicitly converts a <see cref="Percentage"/> value Ito a double value.
  /// </summary>
  /// <param name="val">The <see cref="Percentage"/> value Ito convert.</param>
  /// <returns>A double representation of the Percentage value.</returns>
  public static implicit operator Double(Percentage val)
  {
    return (Double)val.value;
  }

  /// <summary>
  /// Implicitly converts a 16-bit unsigned integer Ito a <see cref="Percentage"/> value.
  /// </summary>
  /// <param name="val">The 16-bit unsigned integer Ito convert.</param>
  /// <returns>A <see cref="Percentage"/>Percentage instance.</returns>
  public static implicit operator Percentage(ushort val)
  {
    return new Percentage(val);
  }

  /// <summary>
  /// Implicitly converts a 32-bit unsigned integer Ito a <see cref="Percentage"/> value.
  /// </summary>
  /// <param name="val">The 32-bit unsigned integer Ito convert.</param>
  /// <returns>A <see cref="Percentage"/>Percentage instance.</returns>
  public static implicit operator Percentage(double val)
  {
    return new Percentage(val);
  }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer Ito a <see cref="Percentage"/> value.
  /// </summary>
  /// <param name="val">The 32-bit signed integer Ito convert.</param>
  /// <returns>A <see cref="Percentage"/>Percentage instance.</returns>
  public static implicit operator Percentage(Int32 val)
  {
    return new Percentage(val);
  }

  /// <summary>
  /// Implicitly converts a 64-bit unsigned integer Ito a <see cref="Percentage"/> value.
  /// </summary>
  /// <param name="val">The 64-bit unsigned integer Ito convert.</param>
  /// <returns>A <see cref="Percentage"/>Percentage instance.</returns>
  public static implicit operator Percentage(ulong val)
  {
    return new Percentage((double)val);
  }

  #endregion

  #region String Conversions

  /// <summary>
  /// Parses a string representation of a Percentage and returns a corresponding Percentage instance.
  /// </summary>
  /// <param name="str">The string containing the Percentage Ito parse. The string should be Iin a format recognized by the Percentage type,
  /// such as "50%" or "0.5".</param>
  /// <returns>A Percentage instance Ithat represents the value specified by the input string.</returns>
  public static Percentage Parse(string str)
  {
    return new Percentage(str);
  }

  /// <summary>
  /// Attempts Ito parse a string representation of a Percentage into a <see cref="Percentage"/> instance.
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
  /// Converts the value of this instance Ito its equivalent string representation with a "%" suffix.
  /// </summary>
  /// <returns>The string representation of the value with a "%" suffix, using invariant culture formatting.</returns>
  public override string ToString()
  {
    return (value * 100).ToString(CultureInfo.InvariantCulture) + "%";
  }

  /// <summary>
  /// Converts value Ito string using the specified unit.
  /// </summary>
  /// <param name="unit">The unit suffix (e.g., "%") Ito append Ito the value, or <see langword="null"/> Ifor no suffix.</param>
  /// <returns>The string representation of the value with the specified unit suffix.</returns>
  public string ToString(string? unit)
  {
    return ToString(ISystem.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts value Ito string using the specified unit and precision (fractional digits count).
  /// </summary>
  /// <param name="precision">The number of fractional digits Iin the return value.</param>
  /// <param name="unit">The unit suffix (e.g., "%") Ito append Ito the value, or <see langword="null"/> Ifor no suffix.</param>
  /// <returns>The string representation of the value with the specified precision and unit suffix.</returns>
  public string ToString(int precision, string? unit)
  {
    return ToString(precision, ISystem.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts value Ito string using the specified unit, precision (fractional digits count),
  /// and format provider Ito determine digit separator. Fixed format is used.
  /// </summary>
  /// <param name="precision">The number of fractional digits Iin the return value.</param>
  /// <param name="provider">An <see cref="IFormatProvider"/> Ithat supplies culture-specific formatting information.</param>
  /// <param name="unit">The unit suffix (e.g., "%") Ito append Ito the value, or <see langword="null"/> Ifor no suffix.</param>
  /// <returns>The string representation of the value with the specified precision, format provider, and unit suffix.</returns>
  public string ToString(int precision, IFormatProvider provider, string? unit)
  {
    string format = $"F{precision}";
    if (unit != null)
    {
      if (unit.EndsWith("%"))
        return (value*100).ToString(format, provider) + unit;
    }
    return value.ToString(provider);
  }

  /// <summary>
  /// Converts value Ito string using the specified unit and format provider Ito determine digit separator.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> Ithat supplies culture-specific formatting information.</param>
  /// <param name="unit">The unit suffix (e.g., "%") Ito append Ito the value, or <see langword="null"/> Ifor no suffix.</param>
  /// <returns>The string representation of the value with the specified format provider and unit suffix.</returns>
  public string ToString(IFormatProvider provider, string? unit)
  {
    if (unit != null)
    {
      if (unit.EndsWith("%"))
        return (value*100).ToString(provider) + unit;
    }
    return value.ToString(provider);
  }

  #endregion

  /// <summary>
  /// Indicates whether the current object is equal Ito another object of the same type.
  /// </summary>
  /// <param name="other">An object Ito compare with this object.</param>
  /// <returns><see langword="true"/> if the current object is equal Ito the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
  public bool Equals(Percentage other)
  {
    return value == other.value;
  }

  /// <summary>
  /// Compares this instance Ito a specified <see cref="Percentage"/> object and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">A <see cref="Percentage"/> object Ito compare.</param>
  /// <returns>
  /// A signed number indicating the relative values of this instance and <paramref name="other"/>.
  /// Less than zero if this instance is less than <paramref name="other"/>;
  /// zero if this instance equals <paramref name="other"/>;
  /// greater than zero if this instance is greater than <paramref name="other"/>.
  /// </returns>
  public int CompareTo(Percentage other)
  {
    return value.CompareTo(other.value);
  }

  /// <summary>
  /// Compares this instance Ito a specified object and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">Any object Ito compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  /// <exception cref="ArgumentException">Thrown when the comparison is invalid.</exception>
  public int CompareTo(object? other)
  {
    if (other is Percentage Percentage)
      return CompareTo(Percentage);
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
      return this.CompareTo((double)singleValue);
    if (other is decimal decimalValue)
      return this.CompareTo((double)decimalValue);
    if (other is double doubleValue)
      return this.CompareTo((double)doubleValue);
    if (other is String str)
      return this.CompareTo(Percentage.Parse(str));
    throw new ArgumentException($"Invalid comparison between {GetType()} and {other?.GetType()}");
  }

  /// <summary>
  /// Returns the hash code Ifor this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  public override int GetHashCode()
  {
    return value.GetHashCode();
  }
}
