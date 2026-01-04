namespace DocumentModel;

/// <summary>
/// Represents a measurement in points (typographic unit).
/// A point is defined as 1/72 of an inch, commonly used for font sizes and typography.
/// Supports conversions to/from millimeters, centimeters, and inches.
/// </summary>
/// <remarks>
/// Points provide a standard unit for typographic measurements in desktop publishing and word processing.
/// This struct supports implicit conversions to/from various integer types and string representations with unit suffixes.
/// </remarks>
[JsonConverter(typeof(PointsJsonConverter))]
public readonly partial struct Points : IComparable<Points>
{
  /// <summary>
  /// How many points are in one millimeter.
  /// There is a small difference between real and nominal factors.
  /// </summary>
  /// <remarks>
  /// The value is approximately 2.83 points per millimeter, calculated as 72 / 25.4.
  /// </remarks>
  public const double PointsInMM = 72 / 25.4; //2.8346456692913385826771653543307

  /// <summary>
  /// How many points are in one centimeter.
  /// </summary>
  /// <remarks>
  /// The value is approximately 28.35 points per centimeter, calculated as PointsInMM / 10.0.
  /// </remarks>
  public const double PointsInCM = PointsInMM / 10.0;

  /// <summary>
  /// How many points are in one inch.
  /// </summary>
  /// <remarks>
  /// By definition, there are exactly 72 points in one inch.
  /// </remarks>
  public const double PointsInInch = 72;

  /// <summary>
  /// The internal value storing the measurement in points.
  /// </summary>
  private readonly Int64 value;

  /// <summary>
  /// Initializes a new instance of the <see cref="Points"/> struct from a string value.
  /// </summary>
  /// <param name="str">The string value to parse. Can include optional unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), or "in" (inches).</param>
  /// <remarks>
  /// <para>Supported formats:</para>
  /// <list type="bullet">
  /// <item><description>"100" - interpreted as points</description></item>
  /// <item><description>"10mm" - millimeters</description></item>
  /// <item><description>"1cm" - centimeters</description></item>
  /// <item><description>"12pt" - points</description></item>
  /// <item><description>"1in" - inches</description></item>
  /// </list>
  /// <para>Commas in the input string are replaced with periods before parsing to ensure decimal separator consistency.</para>
  /// </remarks>
  public Points(string str)
  {
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * PointsInMM;
      value = (Int64)val;
    }
    if (str.EndsWith("cm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * PointsInCM;
      value = (Int64)val;
    }
    else if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * PointsInInch;
      value = (int)val;
    }
    else if (str.EndsWith("pt"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
      value = (Int64)val;
    }
    else value = Int32.Parse(str);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Points"/> struct from a 32-bit unsigned integer value.
  /// </summary>
  /// <param name="value">The value in points.</param>
  public Points(UInt32 value)
  {
    this.value = value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Points"/> struct from a 32-bit signed integer value.
  /// </summary>
  /// <param name="value">The value in points.</param>
  public Points(Int32 value)
  {
    this.value = value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Points"/> struct from a 64-bit unsigned integer value.
  /// </summary>
  /// <param name="value">The value in points.</param>
  public Points(UInt64 value)
  {
    this.value = (Int64)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Points"/> struct from a 64-bit signed integer value.
  /// </summary>
  /// <param name="value">The value in points.</param>
  public Points(Int64 value)
  {
    this.value = value;
  }

  /// <summary>
  /// Converts the points value to millimeters.
  /// </summary>
  /// <returns>The measurement in millimeters as a double-precision floating-point number.</returns>
  public double ToMM()
    => value / PointsInMM;

  /// <summary>
  /// Converts the points value to centimeters.
  /// </summary>
  /// <returns>The measurement in centimeters as a double-precision floating-point number.</returns>
  public double ToCM()
    => value / PointsInCM;

  /// <summary>
  /// Converts the points value to inches.
  /// </summary>
  /// <returns>The measurement in inches as a double-precision floating-point number.</returns>
  public double ToInch()
    => value / PointsInInch;

  /// <summary>
  /// Converts the points value to points (returns the value itself as a double).
  /// </summary>
  /// <returns>The measurement in points as a double-precision floating-point number.</returns>
  /// <remarks>
  /// This method is provided for consistency with other conversion methods and returns the internal value as a double.
  /// </remarks>
  public double ToPoints()
    => value;

  /// <summary>
  /// Converts the value of this instance to its equivalent string representation.
  /// </summary>
  /// <returns>The string representation of the points value without unit suffix.</returns>
  public override string ToString()
  {
    return value.ToString();
  }

  /// <summary>
  /// Converts the value to string using the specified unit.
  /// </summary>
  /// <param name="unit">The unit suffix to append (e.g., "mm", "cm", "pt", "in").</param>
  /// <returns>The string representation of the value with the specified unit suffix.</returns>
  /// <remarks>
  /// When a unit is specified, the value is converted from points to the target unit before formatting.
  /// </remarks>
  public string ToString(string unit)
  {
    return ToString(System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts the value to string using the specified unit and precision (fractional digits count).
  /// </summary>
  /// <param name="precision">The number of fractional digits in the return value.</param>
  /// <param name="unit">The unit suffix to append (e.g., "mm", "cm", "pt", "in").</param>
  /// <returns>The string representation of the value with the specified precision and unit suffix.</returns>
  /// <remarks>
  /// When a unit is specified, the value is converted from points to the target unit before formatting.
  /// Fixed format is used for the numeric part.
  /// </remarks>
  public string ToString(int precision, string unit)
  {
    return ToString(precision, System.Globalization.CultureInfo.InvariantCulture, unit);
  }

  /// <summary>
  /// Converts the value to string using the specified unit, precision (fractional digits count),
  /// and format provider to determine digit separator. Fixed format is used.
  /// </summary>
  /// <param name="precision">The number of fractional digits in the return value.</param>
  /// <param name="provider">An <see cref="IFormatProvider"/> that supplies culture-specific formatting information.</param>
  /// <param name="unit">The unit suffix to append (e.g., "mm", "cm", "pt", "in").</param>
  /// <returns>The string representation of the value with the specified precision, format provider, and unit suffix.</returns>
  /// <remarks>
  /// <para>When a unit is specified, the value is converted from points to the target unit before formatting.</para>
  /// <para>Supported unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), "in" (inches).</para>
  /// </remarks>
  public string ToString(int precision, IFormatProvider provider, string unit)
  {
    string format = $"F{precision}";
    if (unit.EndsWith("mm"))
      return (value / PointsInMM).ToString(format, provider) + unit;
    if (unit.EndsWith("cm"))
      return (value / PointsInCM).ToString(format, provider) + unit;
    if (unit.EndsWith("in"))
      return (value / PointsInInch).ToString(format, provider) + unit;
    if (unit.EndsWith("pt"))
      return (value).ToString(format, provider) + unit;
    return value.ToString();
  }

  /// <summary>
  /// Converts the value to string using the specified unit and format provider to determine digit separator.
  /// </summary>
  /// <param name="provider">An <see cref="IFormatProvider"/> that supplies culture-specific formatting information.</param>
  /// <param name="unit">The unit suffix to append (e.g., "mm", "cm", "pt", "in").</param>
  /// <returns>The string representation of the value with the specified format provider and unit suffix.</returns>
  /// <remarks>
  /// <para>When a unit is specified, the value is converted from points to the target unit before formatting.</para>
  /// <para>Supported unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), "in" (inches).</para>
  /// </remarks>
  public string ToString(IFormatProvider provider, string unit)
  {
    if (unit.EndsWith("mm"))
      return (value / PointsInMM).ToString(provider) + unit;
    if (unit.EndsWith("cm"))
      return (value / PointsInCM).ToString(provider) + unit;
    if (unit.EndsWith("in"))
      return (value / PointsInInch).ToString(provider) + unit;
    if (unit.EndsWith("pt"))
      return (value).ToString(provider) + unit;
    return value.ToString();
  }

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a string to a <see cref="Points"/> value.
  /// </summary>
  /// <param name="value">The string to convert.</param>
  /// <returns>A <see cref="Points"/> value parsed from the string.</returns>
  public static implicit operator Points(string value) { return new Points(value); }

  /// <summary>
  /// Implicitly converts a <see cref="Points"/> value to a string.
  /// </summary>
  /// <param name="value">The <see cref="Points"/> value to convert.</param>
  /// <returns>A string representation of the points value.</returns>
  public static implicit operator string(Points value) { return value.value.ToString(); }

  /// <summary>
  /// Implicitly converts a 16-bit signed integer to a <see cref="Points"/> value.
  /// </summary>
  /// <param name="value">The 16-bit signed integer to convert.</param>
  /// <returns>A <see cref="Points"/> value representing the integer.</returns>
  public static implicit operator Points(Int16 value) { return new Points(value); }

  /// <summary>
  /// Implicitly converts a <see cref="Points"/> value to a 16-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="Points"/> value to convert.</param>
  /// <returns>A 16-bit signed integer representation of the points value.</returns>
  public static implicit operator Int16(Points value) { return (Int16)value.value; }

  /// <summary>
  /// Implicitly converts a 16-bit unsigned integer to a <see cref="Points"/> value.
  /// </summary>
  /// <param name="value">The 16-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="Points"/> value representing the integer.</returns>
  public static implicit operator Points(UInt16 value) { return new Points(value); }

  /// <summary>
  /// Implicitly converts a <see cref="Points"/> value to a 16-bit unsigned integer.
  /// </summary>
  /// <param name="value">The <see cref="Points"/> value to convert.</param>
  /// <returns>A 16-bit unsigned integer representation of the points value.</returns>
  public static implicit operator UInt16(Points value) { return (UInt16)value.value; }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer to a <see cref="Points"/> value.
  /// </summary>
  /// <param name="value">The 32-bit signed integer to convert.</param>
  /// <returns>A <see cref="Points"/> value representing the integer.</returns>
  public static implicit operator Points(Int32 value) { return new Points(value); }

  /// <summary>
  /// Implicitly converts a <see cref="Points"/> value to a 32-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="Points"/> value to convert.</param>
  /// <returns>A 32-bit signed integer representation of the points value.</returns>
  public static implicit operator Int32(Points value) { return (Int32)value.value; }

  /// <summary>
  /// Implicitly converts a 32-bit unsigned integer to a <see cref="Points"/> value.
  /// </summary>
  /// <param name="value">The 32-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="Points"/> value representing the integer.</returns>
  public static implicit operator Points(UInt32 value) { return new Points(value); }

  /// <summary>
  /// Implicitly converts a <see cref="Points"/> value to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="value">The <see cref="Points"/> value to convert.</param>
  /// <returns>A 32-bit unsigned integer representation of the points value.</returns>
  public static implicit operator UInt32(Points value) { return (UInt32)value.value; }

  /// <summary>
  /// Implicitly converts a 64-bit signed integer to a <see cref="Points"/> value.
  /// </summary>
  /// <param name="value">The 64-bit signed integer to convert.</param>
  /// <returns>A <see cref="Points"/> value representing the integer.</returns>
  public static implicit operator Points(Int64 value) { return new Points(value); }

  /// <summary>
  /// Implicitly converts a <see cref="Points"/> value to a 64-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="Points"/> value to convert.</param>
  /// <returns>A 64-bit signed integer representation of the points value.</returns>
  public static implicit operator Int64(Points value) { return (Int64)value.value; }

  /// <summary>
  /// Implicitly converts a 64-bit unsigned integer to a <see cref="Points"/> value.
  /// </summary>
  /// <param name="value">The 64-bit unsigned integer to convert.</param>
  /// <returns>A <see cref="Points"/> value representing the integer.</returns>
  public static implicit operator Points(UInt64 value) { return new Points(value); }

  /// <summary>
  /// Implicitly converts a <see cref="Points"/> value to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="value">The <see cref="Points"/> value to convert.</param>
  /// <returns>A 64-bit unsigned integer representation of the points value.</returns>
  public static implicit operator UInt64(Points value) { return (UInt64)value.value; }

  #endregion

  /// <summary>
  /// Compares this instance to a specified <see cref="Points"/> object and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">A <see cref="Points"/> object to compare.</param>
  /// <returns>
  /// A signed number indicating the relative values of this instance and <paramref name="other"/>.
  /// Less than zero if this instance is less than <paramref name="other"/>;
  /// zero if this instance equals <paramref name="other"/>;
  /// greater than zero if this instance is greater than <paramref name="other"/>.
  /// </returns>
  public int CompareTo(Points other)
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