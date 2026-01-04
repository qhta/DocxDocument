namespace DocumentModel;

/// <summary>
/// Represents a measurement in twips (twentieth of a point).
/// A twip is 1/1440 of an inch, commonly used in word processing and document formatting.
/// Supports conversions to/from millimeters, centimeters, inches, and points.
/// </summary>
/// <remarks>
/// Twips provide a precise, integer-based unit for document measurements.
/// This struct supports implicit conversions to/from various integer types and string representations with unit suffixes.
/// </remarks>
[JsonConverter(typeof(TwipsJsonConverter))]
public readonly partial struct Twips : IComparable<Twips>, IEquatable<Twips>
{
  /// <summary>
  /// How many twips are in one millimeter.
  /// There is a small difference between real and nominal factors.
  /// </summary>
  /// <remarks>
  /// The value is approximately 56.69 twips per millimeter, calculated as 1440 / 25.4.
  /// </remarks>
  public const double TwipsInMM = 1440 / 25.4; //56,695238095238095238095238095238;

  /// <summary>
  /// How many twips are in one centimeter.
  /// There is a small difference between real and nominal factors.
  /// </summary>
  /// <remarks>
  /// The value is approximately 566.9 twips per centimeter, calculated as TwipsInMM / 10.0.
  /// </remarks>
  public const double TwipsInCM = TwipsInMM / 10.0;

  /// <summary>
  /// How many twips are in one inch.
  /// </summary>
  /// <remarks>
  /// By definition, there are exactly 1440 twips in one inch.
  /// </remarks>
  public const double TwipsInInch = 1440;

  /// <summary>
  /// How many twips are in one point.
  /// </summary>
  /// <remarks>
  /// By definition, there are exactly 20 twips in one point (1/72 of an inch).
  /// </remarks>
  public const double TwipsInPoint = 20;

  private readonly Int64 value;

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> struct from a string value.
  /// </summary>
  /// <param name="str">The string value to parse. Can include optional unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), or "in" (inches).</param>
  /// <remarks>
  /// <para>Supported formats:</para>
  /// <list type="bullet">
  /// <item><description>"100" - interpreted as twips</description></item>
  /// <item><description>"10mm" - millimeters</description></item>
  /// <item><description>"1cm" - centimeters</description></item>
  /// <item><description>"12pt" - points</description></item>
  /// <item><description>"1in" - inches</description></item>
  /// </list>
  /// <para>Commas in the input string are replaced with periods before parsing to ensure decimal separator consistency.</para>
  /// </remarks>
  public Twips(string str)
  {
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), CultureInfo.InvariantCulture) * TwipsInMM;
      value = (Int64)val;
    }
    if (str.EndsWith("cm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), CultureInfo.InvariantCulture) * TwipsInCM;
      value = (Int64)val;
    }
    else if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), CultureInfo.InvariantCulture) * TwipsInInch;
      value = (int)val;
    }
    else if (str.EndsWith("pt"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), CultureInfo.InvariantCulture) * TwipsInPoint;
      value = (Int64)val;
    }
    else value = Int32.Parse(str);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> struct from a 32-bit unsigned integer value.
  /// </summary>
  /// <param name="value">The value in twips.</param>
  public Twips(UInt32 value)
  {
    this.value = value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> struct from a 32-bit signed integer value.
  /// </summary>
  /// <param name="value">The value in twips.</param>
  public Twips(Int32 value)
  {
    this.value = value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> struct from a 64-bit unsigned integer value.
  /// </summary>
  /// <param name="value">The value in twips.</param>
  public Twips(UInt64 value)
  {
    this.value = (Int64)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> struct from a 64-bit signed integer value.
  /// </summary>
  /// <param name="value">The value in twips.</param>
  public Twips(Int64 value)
  {
    this.value = value;
  }

  /// <summary>
  /// Converts the twips value to millimeters.
  /// </summary>
  /// <returns>The measurement in millimeters as a double-precision floating-point number.</returns>
  public double ToMM()
    => value / TwipsInMM;

  /// <summary>
  /// Converts the twips value to centimeters.
  /// </summary>
  /// <returns>The measurement in centimeters as a double-precision floating-point number.</returns>
  public double ToCM()
    => value / TwipsInCM;

  /// <summary>
  /// Converts the twips value to inches.
  /// </summary>
  /// <returns>The measurement in inches as a double-precision floating-point number.</returns>
  public double ToInch()
    => value / TwipsInInch;

  /// <summary>
  /// Converts the twips value to points.
  /// </summary>
  /// <returns>The measurement in points as a double-precision floating-point number.</returns>
  /// <remarks>
  /// A point is defined as 1/72 of an inch.
  /// </remarks>
  public double ToPoints()
    => value / TwipsInPoint;

  /// <summary>
  /// Converts the value of this instance to its equivalent string representation.
  /// </summary>
  /// <returns>The string representation of the twips value without unit suffix.</returns>
  public override string ToString()
  {
    return ToString(null);
  }

  /// <summary>
  /// Converts the value to string using the specified unit.
  /// </summary>
  /// <param name="unit">The unit suffix to append (e.g., "mm", "cm", "pt", "in"), or <see langword="null"/> for no suffix.</param>
  /// <returns>The string representation of the value with the specified unit suffix.</returns>
  /// <remarks>
  /// When a unit is specified, the value is converted from twips to the target unit before formatting.
  /// </remarks>
  public string ToString(string? unit)
  {
    return ToString(System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts the value to string using the specified unit and precision (fractional digits count).
  /// </summary>
  /// <param name="precision">The number of fractional digits in the return value.</param>
  /// <param name="unit">The unit suffix to append (e.g., "mm", "cm", "pt", "in"), or <see langword="null"/> for no suffix.</param>
  /// <returns>The string representation of the value with the specified precision and unit suffix.</returns>
  /// <remarks>
  /// When a unit is specified, the value is converted from twips to the target unit before formatting.
  /// Fixed format is used for the numeric part.
  /// </remarks>
  public string ToString(int precision, string? unit)
  {
    return ToString(precision, System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts the value to string using the specified unit, precision (fractional digits count),
  /// and format provider to determine digit separator. Fixed format is used.
  /// </summary>
  /// <param name="precision">The number of fractional digits in the return value.</param>
  /// <param name="provider">An <see cref="IFormatProvider"/> that supplies culture-specific formatting information.</param>
  /// <param name="unit">The unit suffix to append (e.g., "mm", "cm", "pt", "in"), or <see langword="null"/> for no suffix.</param>
  /// <returns>The string representation of the value with the specified precision, format provider, and unit suffix.</returns>
  /// <remarks>
  /// <para>When a unit is specified, the value is converted from twips to the target unit before formatting.</para>
  /// <para>If the value is zero, "0" is returned regardless of precision.</para>
  /// <para>Supported unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), "in" (inches).</para>
  /// </remarks>
  public string ToString(int precision, IFormatProvider provider, string? unit)
  {
    string format = $"F{precision}";
    if (unit != null)
    {
      if (value == 0)
        return "0";
      if (unit.EndsWith("mm"))
        return (value / TwipsInMM).ToString(format, provider) + unit;
      if (unit.EndsWith("cm"))
        return (value / TwipsInCM).ToString(format, provider) + unit;
      if (unit.EndsWith("in"))
        return (value / TwipsInInch).ToString(format, provider) + unit;
      if (unit.EndsWith("pt"))
        return (value / TwipsInPoint).ToString(format, provider) + unit;
    }
    return value.ToString();
  }

  /// <summary>
  /// Converts the value to string using the specified unit and format provider to determine digit separator.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> that supplies culture-specific formatting information.</param>
  /// <param name="unit">The unit suffix to append (e.g., "mm", "cm", "pt", "in"), or <see langword="null"/> for no suffix.</param>
  /// <returns>The string representation of the value with the specified format provider and unit suffix.</returns>
  /// <remarks>
  /// <para>When a unit is specified, the value is converted from twips to the target unit before formatting.</para>
  /// <para>If the value is zero, "0" is returned regardless of the unit.</para>
  /// <para>Supported unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), "in" (inches).</para>
  /// </remarks>
  public string ToString(IFormatProvider provider, string? unit)
  {
    if (unit != null)
    {
      if (value == 0)
        return "0";
      if (unit.EndsWith("mm"))
        return (value / TwipsInMM).ToString(provider) + unit;
      if (unit.EndsWith("cm"))
        return (value / TwipsInCM).ToString(provider) + unit;
      if (unit.EndsWith("in"))
        return (value / TwipsInInch).ToString(provider) + unit;
      if (unit.EndsWith("pt"))
        return (value / TwipsInPoint).ToString(provider) + unit;
    }
    return value.ToString();
  }

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a string to a <see cref="Twips"/> value.
  /// </summary>
  /// <param name="value">The string to convert.</param>
  /// <returns>A <see cref="Twips"/> value parsed from the string.</returns>
  public static implicit operator Twips(string value) { return new Twips(value); }

  /// <summary>
  /// Implicitly converts a <see cref="Twips"/> value to a string.
  /// </summary>
  /// <param name="value">The <see cref="Twips"/> value to convert.</param>
  /// <returns>A string representation of the twips value.</returns>
  public static implicit operator string(Twips value) { return value.value.ToString(); }

  /// <summary>
  /// Implicitly converts a 16-bit signed integer to a <see cref="Twips"/> value.
  /// </summary>
  /// <param name="value">The 16-bit signed integer to convert.</param>
  /// <returns>A <see cref="Twips"/> value representing the integer.</returns>
  public static implicit operator Twips(Int16 value) { return new Twips(value); }

  /// <summary>
  /// Implicitly converts a <see cref="Twips"/> value to a 16-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="Twips"/> value to convert.</param>
  /// <returns>A 16-bit signed integer representation of the twips value.</returns>
  public static implicit operator Int16(Twips value) { return (Int16)value.value; }

  /// <summary>
  /// Implicitly converts a 16-bit unsigned integer to a <see cref="Twips"/> value.
  /// </summary>
  /// <param name="value">The 16-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="Twips"/> value representing the integer.</returns>
  public static implicit operator Twips(UInt16 value) { return new Twips(value); }

  /// <summary>
  /// Implicitly converts a <see cref="Twips"/> value to a 16-bit unsigned integer.
  /// </summary>
  /// <param name="value">The <see cref="Twips"/> value to convert.</param>
  /// <returns>A 16-bit unsigned integer representation of the twips value.</returns>
  public static implicit operator UInt16(Twips value) { return (UInt16)value.value; }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer to a <see cref="Twips"/> value.
  /// </summary>
  /// <param name="value">The 32-bit signed integer to convert.</param>
  /// <returns>A <see cref="Twips"/> value representing the integer.</returns>
  public static implicit operator Twips(Int32 value) { return new Twips(value); }

  /// <summary>
  /// Implicitly converts a <see cref="Twips"/> value to a 32-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="Twips"/> value to convert.</param>
  /// <returns>A 32-bit signed integer representation of the twips value.</returns>
  public static implicit operator Int32(Twips value) { return (Int32)value.value; }

  /// <summary>
  /// Implicitly converts a 32-bit unsigned integer to a <see cref="Twips"/> value.
  /// </summary>
  /// <param name="value">The 32-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="Twips"/> value representing the integer.</returns>
  public static implicit operator Twips(UInt32 value) { return new Twips(value); }

  /// <summary>
  /// Implicitly converts a <see cref="Twips"/> value to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="value">The <see cref="Twips"/> value to convert.</param>
  /// <returns>A 32-bit unsigned integer representation of the twips value.</returns>
  public static implicit operator UInt32(Twips value) { return (UInt32)value.value; }

  /// <summary>
  /// Implicitly converts a 64-bit signed integer to a <see cref="Twips"/> value.
  /// </summary>
  /// <param name="value">The 64-bit signed integer to convert.</param>
  /// <returns>A <see cref="Twips"/> value representing the integer.</returns>
  public static implicit operator Twips(Int64 value) { return new Twips(value); }

  /// <summary>
  /// Implicitly converts a <see cref="Twips"/> value to a 64-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="Twips"/> value to convert.</param>
  /// <returns>A 64-bit signed integer representation of the twips value.</returns>
  public static implicit operator Int64(Twips value) { return (Int64)value.value; }

  /// <summary>
  /// Implicitly converts a 64-bit unsigned integer to a <see cref="Twips"/> value.
  /// </summary>
  /// <param name="value">The 64-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="Twips"/> value representing the integer.</returns>
  public static implicit operator Twips(UInt64 value) { return new Twips(value); }

  /// <summary>
  /// Implicitly converts a <see cref="Twips"/> value to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="value">The <see cref="Twips"/> value to convert.</param>
  /// <returns>A 64-bit unsigned integer representation of the twips value.</returns>
  public static implicit operator UInt64(Twips value) { return (UInt64)value.value; }

  #endregion

  /// <summary>
  /// Compares this instance to a specified <see cref="Twips"/> object and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">A <see cref="Twips"/> object to compare.</param>
  /// <returns>
  /// A signed number indicating the relative values of this instance and <paramref name="other"/>.
  /// Less than zero if this instance is less than <paramref name="other"/>;
  /// zero if this instance equals <paramref name="other"/>;
  /// greater than zero if this instance is greater than <paramref name="other"/>.
  /// </returns>
  public int CompareTo(Twips other)
  {
    return value.CompareTo(other.value);
  }

  /// <summary>
  /// Indicates whether the current object is equal to another object of the same type.
  /// </summary>
  /// <param name="other">An object to compare with this object.</param>
  /// <returns><see langword="true"/> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
  public bool Equals(Twips other)
  {
    return value.Equals(other.value);
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