namespace DocumentModel;

/// <summary>
/// Represents a percentage value stored as an byte number.
/// Supports implicit conversions to/from numeric types and string representations with optional "%" suffix.
/// Conversion to/from double and single precision floating-point types means scaling by 100 to support fractional percentages.
/// </summary>
[DataContract]
[JsonConverter(typeof(BytePercentJsonConverter))]
public readonly partial struct BytePercent : IEquatable<BytePercent>, IComparable<BytePercent>, IComparable<object>, IPercentage
{
  /// <summary>
  /// Gets the underlying integer value of the percentage.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public readonly byte Value;

  /// <summary>
  /// Initializes a new instance of the <see cref="BytePercent"/> struct from a string value.
  /// </summary>
  /// <param name="str">The string value to parse. Can include an optional "%" suffix and uses invariant culture for parsing.</param>
  /// <remarks>
  /// Commas in the input string are replaced with periods before parsing to ensure decimal separator consistency.
  /// </remarks>
  public BytePercent(string str)
  {
    str = str.TrimEnd('%');
    Value = byte.Parse(str.Replace(",", "."), CultureInfo.InvariantCulture);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="BytePercent"/> struct from a byte value.
  /// </summary>
  /// <param name="value">The byte value representing the percentage.</param>
  public BytePercent(byte value)
  {
    this.Value = value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="BytePercent"/> struct from a SByte value.
  /// </summary>
  /// <param name="value">The SByte value representing the percentage.</param>
  public BytePercent(sbyte value)
  {
    this.Value = (byte)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="BytePercent"/> struct from an Int16 value.
  /// </summary>
  /// <param name="value">The Int16 value representing the percentage.</param>
  public BytePercent(Int16 value)
  {
    this.Value = (byte)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="BytePercent"/> struct from an Int32 value.
  /// </summary>
  /// <param name="value">The Int32 value representing the percentage.</param>
  public BytePercent(Int32 value)
  {
    this.Value = (byte)value;
  }


  /// <summary>
  /// Initializes a new instance of the <see cref="BytePercent"/> struct from an Int64 value.
  /// </summary>
  /// <param name="value">The int value representing the percentage.</param>
  public BytePercent(Int64 value)
  {
    this.Value = (byte)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="BytePercent"/> struct from an UInt16 value.
  /// </summary>
  /// <param name="value">The UInt16 value representing the percentage.</param>
  public BytePercent(UInt16 value)
  {
    this.Value = (byte)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="BytePercent"/> struct from an UInt32 value.
  /// </summary>
  /// <param name="value">The UInt32 value representing the percentage.</param>
  public BytePercent(UInt32 value)
  {
    this.Value = (byte)value;
  }


  /// <summary>
  /// Initializes a new instance of the <see cref="BytePercent"/> struct from an UInt64 value.
  /// </summary>
  /// <param name="value">The UInt value representing the percentage.</param>
  public BytePercent(UInt64 value)
  {
    this.Value = (byte)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="BytePercent"/> struct from a Decimal value.
  /// </summary>
  /// <param name="value">The Decimal value representing the percentage.</param>
  public BytePercent(Decimal value)
  {
    this.Value = (byte)value;
  }


  /// <summary>
  /// Initializes a new instance of the <see cref="BytePercent"/> struct from a Single value.
  /// </summary>
  /// <param name="value">The Single value representing the percentage.</param>
  public BytePercent(Single value)
  {
    this.Value = (byte)(value * 100.0);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="BytePercent"/> struct from a Double value.
  /// </summary>
  /// <param name="value">The Double value representing the percentage.</param>
  public BytePercent(Double value)
  {
    this.Value = (byte)(value * 100.0);
  }

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a string to a <see cref="BytePercent"/> value.
  /// </summary>
  /// <param name="val">The string to convert.</param>
  /// <returns>A <see cref="BytePercent"/> value parsed from the string.</returns>
  public static implicit operator BytePercent(string val)
  {
    return new BytePercent(val);
  }

  /// <summary>
  /// Implicitly converts a <see cref="BytePercent"/> value to a string representation.
  /// </summary>
  /// <param name="val">The <see cref="BytePercent"/> value to convert.</param>
  /// <returns>A string representation of the <see cref="BytePercent"/> value.</returns>
  public static implicit operator string(BytePercent val)
  {
    return val.ToString();
  }

  /// <summary>
  /// Implicitly converts a <see cref="BytePercent"/> value to a 16-bit unsigned integer.
  /// </summary>
  /// <param name="val">The <see cref="BytePercent"/> value to convert.</param>
  /// <returns>A 16-bit unsigned integer representation of the percentage value.</returns>
  public static implicit operator ushort(BytePercent val)
  {
    return (ushort)val.Value;
  }

  /// <summary>
  /// Implicitly converts a <see cref="BytePercent"/> value to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="val">The <see cref="BytePercent"/> value to convert.</param>
  /// <returns>A 32-bit unsigned integer representation of the percentage value.</returns>
  public static implicit operator uint(BytePercent val)
  {
    return (uint)val.Value;
  }

  /// <summary>
  /// Implicitly converts a <see cref="BytePercent"/> value to a 32-bit signed integer.
  /// </summary>
  /// <param name="val">The <see cref="BytePercent"/> value to convert.</param>
  /// <returns>A 32-bit signed integer representation of the percentage value.</returns>
  public static implicit operator Int32(BytePercent val)
  {
    return (byte)val.Value;
  }


  /// <summary>
  /// Implicitly converts a <see cref="BytePercent"/> value to a 64-bit signed integer.
  /// </summary>
  /// <param name="val">The <see cref="BytePercent"/> value to convert.</param>
  /// <returns>A 64-bit signed integer representation of the percentage value.</returns>
  public static implicit operator Int64(BytePercent val)
  {
    return (long)val.Value;
  }

  /// <summary>
  /// Implicitly converts a <see cref="BytePercent"/> value to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="val">The <see cref="BytePercent"/> value to convert.</param>
  /// <returns>A 64-bit unsigned integer representation of the percentage value.</returns>
  public static implicit operator ulong(BytePercent val)
  {
    return (ulong)val.Value;
  }

  /// <summary>
  /// Implicitly converts a <see cref="BytePercent"/> value to a decimal value.
  /// </summary>
  /// <param name="val">The <see cref="BytePercent"/> value to convert.</param>
  /// <returns>A decimal representation of the percentage value.</returns>
  public static implicit operator Decimal(BytePercent val)
  {
    return (Decimal)val.Value;
  }

  /// <summary>
  /// Implicitly converts a <see cref="BytePercent"/> value to a double value.
  /// </summary>
  /// <param name="val">The <see cref="BytePercent"/> value to convert.</param>
  /// <returns>A decimal representation of the percentage value.</returns>
  public static implicit operator Double(BytePercent val)
  {
    return (Double)val.Value / 100;
  }

  /// <summary>
  /// Implicitly converts a 16-bit unsigned integer to a <see cref="BytePercent"/> value.
  /// </summary>
  /// <param name="val">The 16-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="BytePercent"/>BytePercent instance.</returns>
  public static implicit operator BytePercent(ushort val)
  {
    return new BytePercent(val);
  }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer to a <see cref="BytePercent"/> value.
  /// </summary>
  /// <param name="val">The 32-bit signed integer to convert.</param>
  /// <returns>A <see cref="BytePercent"/>BytePercent instance.</returns>
  public static implicit operator BytePercent(Int32 val)
  {
    return new BytePercent(val);
  }

  /// <summary>
  /// Implicitly converts a 64-bit unsigned integer to a <see cref="BytePercent"/> value.
  /// </summary>
  /// <param name="val">The 64-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="BytePercent"/>BytePercent instance.</returns>
  public static implicit operator BytePercent(ulong val)
  {
    return new BytePercent((decimal)val);
  }


  /// <summary>
  /// Implicitly converts a double value to a <see cref="BytePercent"/> value.
  /// </summary>
  /// <param name="val">The double value to convert.</param>
  /// <returns>A <see cref="BytePercent"/>BytePercent instance.</returns>
  public static implicit operator BytePercent(double val)
  {
    return new BytePercent(val);
  }

  /// <summary>
  /// Implicitly converts a decimal value to a <see cref="BytePercent"/> value.
  /// </summary>
  /// <param name="val">The decimal value to convert.</param>
  /// <returns>A <see cref="BytePercent"/>BytePercent instance.</returns>
  public static implicit operator BytePercent(decimal val)
  {
    return new BytePercent(val);
  }

  #endregion

  #region String Conversions

  /// <summary>
  /// Parses a string representation of a percentage and returns a corresponding BytePercent instance.
  /// </summary>
  /// <param name="str">The string containing the percentage to parse. The string should be in a format recognized by the BytePercent type,
  /// such as "50%" or "0.5".</param>
  /// <returns>A BytePercent instance that represents the value specified by the input string.</returns>
  public static BytePercent Parse(string str)
  {
    return new BytePercent(str);
  }

  /// <summary>
  /// Attempts to parse a string representation of a percentage into a <see cref="BytePercent"/> instance.
  /// </summary>
  /// <param name="str">The string representation of the percentage.</param>
  /// <param name="result">The resulting <see cref="BytePercent"/> instance if parsing is successful.</param>
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
  /// Converts the value of this instance to its equivalent string representation with a "%" suffix.
  /// </summary>
  /// <returns>The string representation of the value with a "%" suffix, using invariant culture formatting.</returns>
  public override string ToString()
  {
    return Value.ToString(CultureInfo.InvariantCulture) + "%";
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
        return (Value).ToString(format, provider) + unit;
    }
    return Value.ToString(provider);
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
        return (Value).ToString(provider) + unit;
    }
    return Value.ToString(provider);
  }

  #endregion

  /// <summary>
  /// Indicates whether the current object is equal to another object of the same type.
  /// </summary>
  /// <param name="other">An object to compare with this object.</param>
  /// <returns><see langword="true"/> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
  public bool Equals(BytePercent other)
  {
    return Value == other.Value;
  }

  /// <summary>
  /// Compares this instance to a specified <see cref="BytePercent"/> object and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">A <see cref="BytePercent"/> object to compare.</param>
  /// <returns>
  /// A signed number indicating the relative values of this instance and <paramref name="other"/>.
  /// Less than zero if this instance is less than <paramref name="other"/>;
  /// zero if this instance equals <paramref name="other"/>;
  /// greater than zero if this instance is greater than <paramref name="other"/>.
  /// </returns>
  public int CompareTo(BytePercent other)
  {
    return Value.CompareTo(other.Value);
  }

  /// <summary>
  /// Compares this instance to a specified Byte value and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">An Byte value to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  public int CompareTo(Byte other)
  {
    return Value.CompareTo(other);
  }

  /// <summary>
  /// Compares this instance to a specified SByte value and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">An SByte value to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  public int CompareTo(SByte other)
  {
    return Value.CompareTo(other);
  }

  /// <summary>
  /// Compares this instance to a specified Int16 value and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">An Int16 value to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  public int CompareTo(Int16 other)
  {
    return Value.CompareTo(other);
  }

  /// <summary>
  /// Compares this instance to a specified Int32 value and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">An Int32 value to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  public int CompareTo(Int32 other)
  {
    return Value.CompareTo(other);
  }

  /// <summary>
  /// Compares this instance to a specified Int64 value and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">An Int64 value to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  public int CompareTo(Int64 other)
  {
    return Value.CompareTo(other);
  }

  /// <summary>
  /// Compares this instance to a specified UInt16 value and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">An UInt16 value to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  public int CompareTo(UInt16 other)
  {
    return Value.CompareTo(other);
  }

  /// <summary>
  /// Compares this instance to a specified UInt32 value and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">An UInt32 value to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  public int CompareTo(UInt32 other)
  {
    return Value.CompareTo(other);
  }

  /// <summary>
  /// Compares this instance to a specified UInt64 value and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">An UInt64 value to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  public int CompareTo(UInt64 other)
  {
    return Value.CompareTo(other);
  }

  /// <summary>
  /// Compares this instance to a specified object and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">Any object to compare.</param>
  /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
  /// <exception cref="ArgumentException">Thrown when the comparison is invalid.</exception>
  public int CompareTo(object? other)
  {
    if (other is BytePercent percent)
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
      return this.CompareTo(BytePercent.Parse(str));
    throw new ArgumentException($"Invalid comparison between {GetType()} and {other?.GetType()}");
  }

  /// <summary>
  /// Returns the hash code for this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  public override int GetHashCode()
  {
    return ((double)Value / 100).GetHashCode();
  }
  
  /// <summary>
  /// Gets the percentage value as an integer in the range of 0 to 100.
  /// </summary>
  /// <returns>The integer representation of the percentage value.</returns>  
  public int AsInteger() => Value;

  /// <summary>
  /// Returns the decimal representation of the percentage value.
  /// </summary>
  /// <returns>A decimal value representing the percentage.</returns>
  public decimal AsDecimal() => Value;

  /// <summary>
  /// Returns the double representation of the percentage value.
  /// </summary>
  /// <returns>A double value representing the percentage.</returns>
  public double AsDouble() => (double)Value / 100;

}
