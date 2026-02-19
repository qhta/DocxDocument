namespace DocumentModel;

/// <summary>
/// Represents a measurement in half-points (half of a typographic point).
/// A half-point is defined as 1/144 of an inch, commonly used for fine-grained typography adjustments.
/// Supports conversions to/from millimeters, centimeters, inches, and points.
/// </summary>
/// <remarks>
/// Half-points provide finer precision than points for typographic measurements in desktop publishing and word processing.
/// This struct supports implicit conversions to/from various integer types and string representations with unit suffixes.
/// Note: 1 half-point = 0.5 points = 1/144 inch.
/// </remarks>
[JsonConverter(typeof(HPSJsonConverter))]
public readonly partial struct HPS : ILengthMeasure, IComparable<HPS>, IEquatable<HPS>
{
  /// <summary>
  /// How many half-points are in one millimeter.
  /// There is a small difference between real and nominal factors.
  /// </summary>
  /// <remarks>
  /// The value is approximately 5.67 half-points per millimeter, calculated as 144 / 25.4.
  /// </remarks>
  public const double HPSinMM = 144 / 25.4; //5.6695238095238095238095238095238;

  /// <summary>
  /// How many half-points are in one centimeter.
  /// </summary>
  /// <remarks>
  /// The value is approximately 56.7 half-points per centimeter, calculated as HPSinMM * 10.0.
  /// </remarks>
  public const double HPSinCM = HPSinMM * 10.0;

  /// <summary>
  /// How many half-points are in one inch.
  /// </summary>
  /// <remarks>
  /// By definition, there are exactly 144 half-points in one inch.
  /// </remarks>
  public const double HPSinInch = 144;

  /// <summary>
  /// How many half-points are in one point.
  /// </summary>
  /// <remarks>
  /// By definition, there are exactly 2 half-points in one point.
  /// </remarks>
  public const double HPSinPT = 2;

  /// <summary>
  /// How many half-points are in one twips.
  /// </summary>
  /// <remarks>
  /// By definition, there are exactly 10 twips in one half-point.
  /// </remarks>
  public const double HPSinTwips = 1.0 / 10.0;

  /// <summary>
  /// The internal value storing the measurement in half-points.
  /// </summary>
  private readonly UInt64 value;

  /// <summary>
  /// Initializes a new instance of the <see cref="HPS"/> struct from a string value.
  /// </summary>
  /// <param name="str">The string value to parse. Can include optional unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), or "in" (inches).</param>
  /// <remarks>
  /// <para>Supported formats:</para>
  /// <list type="bullet">
  /// <item><description>"100" - interpreted as half-points</description></item>
  /// <item><description>"10mm" - millimeters</description></item>
  /// <item><description>"1cm" - centimeters</description></item>
  /// <item><description>"12pt" - points (will be converted to 24 half-points)</description></item>
  /// <item><description>"1in" - inches (will be converted to 144 half-points)</description></item>
  /// </list>
  /// <para>Commas in the input string are replaced with periods before parsing to ensure decimal separator consistency.</para>
  /// </remarks>
  public HPS(string str)
  {
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * HPSinMM;
      value = (UInt64)val;
    }
    if (str.EndsWith("cm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * HPSinCM;
      value = (UInt64)val;
    }
    else if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * HPSinInch;
      value = (UInt64)val;
    }
    else if (str.EndsWith("pt"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * HPSinPT;
      value = (UInt64)val;
    }
    else value = UInt64.Parse(str);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="HPS"/> struct from a 32-bit unsigned integer value.
  /// </summary>
  /// <param name="value">The value in half-points.</param>
  public HPS(UInt32 value)
  {
    this.value = value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="HPS"/> struct from a 32-bit signed integer value.
  /// </summary>
  /// <param name="value">The value in half-points.</param>
  public HPS(Int32 value)
  {
    this.value = (UInt64)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="HPS"/> struct from a 64-bit unsigned integer value.
  /// </summary>
  /// <param name="value">The value in half-points.</param>
  public HPS(UInt64 value)
  {
    this.value = (UInt64)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="HPS"/> struct from a 64-bit signed integer value.
  /// </summary>
  /// <param name="value">The value in half-points.</param>
  public HPS(Int64 value)
  {
    this.value = (UInt64)value;
  }

  /// <summary>
  /// Converts the half-points value to millimeters.
  /// </summary>
  /// <returns>The measurement in millimeters as a double-precision floating-point number.</returns>
  public double ToMM()
    => value / HPSinMM;

  /// <summary>
  /// Converts the half-points value to centimeters.
  /// </summary>
  /// <returns>The measurement in centimeters as a double-precision floating-point number.</returns>
  public double ToCM()
    => value / HPSinCM;

  /// <summary>
  /// Converts the half-points value to inches.
  /// </summary>
  /// <returns>The measurement in inches as a double-precision floating-point number.</returns>
  public double ToInch()
    => value / HPSinInch;

  /// <summary>
  /// Converts the half-points value to points.
  /// </summary>
  /// <returns>The measurement in points as a double-precision floating-point number.</returns>
  /// <remarks>
  /// Since there are 2 half-points per point, this method divides the internal value by 2.
  /// </remarks>
  public double ToPT()
    => value / HPSinPT;

  /// <summary>
  /// Converts the half-points value to twips.
  /// </summary>
  /// <returns>The measurement in twips as a double-precision floating-point number.</returns>
  public double ToTwips()
    => value / HPSinTwips;

  /// <summary>
  /// Converts the value of this instance to its equivalent string representation.
  /// </summary>
  /// <returns>The string representation of the half-points value without unit suffix.</returns>
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
  /// When a unit is specified, the value is converted from half-points to the target unit before formatting.
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
  /// When a unit is specified, the value is converted from half-points to the target unit before formatting.
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
  /// <para>When a unit is specified, the value is converted from half-points to the target unit before formatting.</para>
  /// <para>Supported unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), "in" (inches).</para>
  /// </remarks>
  public string ToString(int precision, IFormatProvider provider, string? unit)
  {
    string format = $"F{precision}";
    if (unit != null)
    {
      if (unit.EndsWith("mm"))
        return (value / HPSinMM).ToString(format, provider) + unit;
      if (unit.EndsWith("cm"))
        return (value / HPSinCM).ToString(format, provider) + unit;
      if (unit.EndsWith("in"))
        return (value / HPSinInch).ToString(format, provider) + unit;
      if (unit.EndsWith("pt"))
        return (value / HPSinPT).ToString(format, provider) + unit;
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
  /// <para>When a unit is specified, the value is converted from half-points to the target unit before formatting.</para>
  /// <para>Supported unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), "in" (inches).</para>
  /// </remarks>
  public string ToString(IFormatProvider provider, string? unit)
  {
    if (unit != null)
    {
      if (unit.EndsWith("mm"))
        return (value / HPSinMM).ToString(provider) + unit;
      if (unit.EndsWith("cm"))
        return (value / HPSinCM).ToString(provider) + unit;
      if (unit.EndsWith("in"))
        return (value / HPSinInch).ToString(provider) + unit;
      if (unit.EndsWith("pt"))
        return (value / HPSinPT).ToString(provider) + unit;
    }
    return value.ToString();
  }

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a string to a <see cref="HPS"/> value.
  /// </summary>
  /// <param name="value">The string to convert.</param>
  /// <returns>A <see cref="HPS"/> value parsed from the string.</returns>
  public static implicit operator HPS(string value) { return new HPS(value); }

  /// <summary>
  /// Implicitly converts a <see cref="HPS"/> value to a string.
  /// </summary>
  /// <param name="value">The <see cref="HPS"/> value to convert.</param>
  /// <returns>A string representation of the half-points value.</returns>
  public static implicit operator string(HPS value) { return value.value.ToString(); }

  /// <summary>
  /// Implicitly converts a 16-bit signed integer to a <see cref="HPS"/> value.
  /// </summary>
  /// <param name="value">The 16-bit signed integer to convert.</param>
  /// <returns>A <see cref="HPS"/> value representing the integer.</returns>
  public static implicit operator HPS(Int16 value) { return new HPS(value); }

  /// <summary>
  /// Implicitly converts a <see cref="HPS"/> value to a 16-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="HPS"/> value to convert.</param>
  /// <returns>A 16-bit signed integer representation of the half-points value.</returns>
  public static implicit operator Int16(HPS value) { return (Int16)value.value; }

  /// <summary>
  /// Implicitly converts a 16-bit unsigned integer to a <see cref="HPS"/> value.
  /// </summary>
  /// <param name="value">The 16-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="HPS"/> value representing the integer.</returns>
  public static implicit operator HPS(UInt16 value) { return new HPS(value); }

  /// <summary>
  /// Implicitly converts a <see cref="HPS"/> value to a 16-bit unsigned integer.
  /// </summary>
  /// <param name="value">The <see cref="HPS"/> value to convert.</param>
  /// <returns>A 16-bit unsigned integer representation of the half-points value.</returns>
  public static implicit operator UInt16(HPS value) { return (UInt16)value.value; }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer to a <see cref="HPS"/> value.
  /// </summary>
  /// <param name="value">The 32-bit signed integer to convert.</param>
  /// <returns>A <see cref="HPS"/> value representing the integer.</returns>
  public static implicit operator HPS(Int32 value) { return new HPS(value); }

  /// <summary>
  /// Implicitly converts a <see cref="HPS"/> value to a 32-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="HPS"/> value to convert.</param>
  /// <returns>A 32-bit signed integer representation of the half-points value.</returns>
  public static implicit operator Int32(HPS value) { return (Int32)value.value; }

  /// <summary>
  /// Implicitly converts a 32-bit unsigned integer to a <see cref="HPS"/> value.
  /// </summary>
  /// <param name="value">The 32-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="HPS"/> value representing the integer.</returns>
  public static implicit operator HPS(UInt32 value) { return new HPS(value); }

  /// <summary>
  /// Implicitly converts a <see cref="HPS"/> value to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="value">The <see cref="HPS"/> value to convert.</param>
  /// <returns>A 32-bit unsigned integer representation of the half-points value.</returns>
  public static implicit operator UInt32(HPS value) { return (UInt32)value.value; }

  /// <summary>
  /// Implicitly converts a 64-bit signed integer to a <see cref="HPS"/> value.
  /// </summary>
  /// <param name="value">The 64-bit signed integer to convert.</param>
  /// <returns>A <see cref="HPS"/> value representing the integer.</returns>
  public static implicit operator HPS(Int64 value) { return new HPS(value); }

  /// <summary>
  /// Implicitly converts a <see cref="HPS"/> value to a 64-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="HPS"/> value to convert.</param>
  /// <returns>A 64-bit signed integer representation of the half-points value.</returns>
  public static implicit operator Int64(HPS value) { return (Int64)value.value; }

  /// <summary>
  /// Implicitly converts a 64-bit unsigned integer to a <see cref="HPS"/> value.
  /// </summary>
  /// <param name="value">The 64-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="HPS"/> value representing the integer.</returns>
  public static implicit operator HPS(UInt64 value) { return new HPS(value); }

  /// <summary>
  /// Implicitly converts a <see cref="HPS"/> value to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="value">The <see cref="HPS"/> value to convert.</param>
  /// <returns>A 64-bit unsigned integer representation of the half-points value.</returns>
  public static implicit operator UInt64(HPS value) { return (UInt64)value.value; }

  #endregion

  /// <summary>
  /// Compares this instance to a specified <see cref="HPS"/> object and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">A <see cref="HPS"/> object to compare.</param>
  /// <returns>
  /// A signed number indicating the relative values of this instance and <paramref name="other"/>.
  /// Less than zero if this instance is less than <paramref name="other"/>;
  /// zero if this instance equals <paramref name="other"/>;
  /// greater than zero if this instance is greater than <paramref name="other"/>.
  /// </returns>
  public int CompareTo(HPS other)
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

  /// <summary>
  /// Compares this instance to another <see cref="HPS"/> object for equality.
  /// </summary>
  /// <param name="other"></param>
  /// <returns></returns>
  public bool Equals(HPS other)
  {
    return value == other.value;
  }

  /// <summary>
  /// Determines whether the specified object is equal to the current HalfPoints instance.
  /// </summary>
  /// <remarks>This method provides a type-specific equality comparison for HalfPoints objects, overriding the
  /// base implementation to ensure accurate value comparison.</remarks>
  /// <param name="obj">The object to compare with the current HalfPoints instance. This parameter can be null.</param>
  /// <returns><see langword="true"/> if the specified object is a HalfPoints instance and is equal to the current instance;
  /// otherwise, <see langword="false"/>.</returns>
  public override bool Equals(object? obj)
  {
    return obj is HPS other && Equals(other);
  }
}