namespace DocumentModel;

/// <summary>
/// Represents a measurement in eighth-points (one-eighth of a typographic point).
/// An eighth-point is defined as 1/576 of an inch, providing extremely fine-grained precision for typography.
/// Supports conversions to/from millimeters, centimeters, inches, and points.
/// </summary>
/// <remarks>
/// Eighth-points provide the finest precision among point-based measurements for typographic adjustments.
/// This struct supports implicit conversions to/from various integer types and string representations with unit suffixes.
/// Note: 1 eighth-point = 0.125 points = 1/576 inch. There are 8 eighth-points in 1 point.
/// </remarks>
[JsonConverter(typeof(EighthPointsJsonConverter))]
public readonly partial struct EighthPoints : IComparable<EighthPoints>
{
  /// <summary>
  /// How many eighth-points are in one millimeter.
  /// There is a small difference between real and nominal factors.
  /// </summary>
  /// <remarks>
  /// The value is approximately 22.68 eighth-points per millimeter, calculated as 576 / 25.4.
  /// </remarks>
  public const double EighthPointsInMM = 576 / 25.4; //22.677795275590551181102362204724;

  /// <summary>
  /// How many eighth-points are in one centimeter.
  /// </summary>
  /// <remarks>
  /// The value is approximately 226.8 eighth-points per centimeter, calculated as EighthPointsInMM * 10.0.
  /// </remarks>
  public const double EighthPointsInCM = EighthPointsInMM * 10.0;

  /// <summary>
  /// How many eighth-points are in one inch.
  /// </summary>
  /// <remarks>
  /// By definition, there are exactly 576 eighth-points in one inch.
  /// </remarks>
  public const double EighthPointsInInch = 576;

  /// <summary>
  /// How many eighth-points are in one point.
  /// </summary>
  /// <remarks>
  /// By definition, there are exactly 8 eighth-points in one point.
  /// </remarks>
  public const double EighthPointsInPoint = 8;

  /// <summary>
  /// The internal value storing the measurement in eighth-points.
  /// </summary>
  private readonly Int64 value;

  /// <summary>
  /// Initializes a new instance of the <see cref="EighthPoints"/> struct from a string value.
  /// </summary>
  /// <param name="str">The string value to parse. Can include optional unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), or "in" (inches).</param>
  /// <remarks>
  /// <para>Supported formats:</para>
  /// <list type="bullet">
  /// <item><description>"100" - interpreted as eighth-points</description></item>
  /// <item><description>"10mm" - millimeters</description></item>
  /// <item><description>"1cm" - centimeters</description></item>
  /// <item><description>"12pt" - points (will be converted to 96 eighth-points)</description></item>
  /// <item><description>"1in" - inches (will be converted to 576 eighth-points)</description></item>
  /// </list>
  /// <para>Commas in the input string are replaced with periods before parsing to ensure decimal separator consistency.</para>
  /// </remarks>
  public EighthPoints(string str)
  {
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * EighthPointsInMM;
      value = (Int64)val;
    }
    if (str.EndsWith("cm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * EighthPointsInCM;
      value = (Int64)val;
    }
    else if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * EighthPointsInInch;
      value = (int)val;
    }
    else if (str.EndsWith("pt"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * EighthPointsInPoint;
      value = (Int64)val;
    }
    else value = Int32.Parse(str);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="EighthPoints"/> struct from a 32-bit unsigned integer value.
  /// </summary>
  /// <param name="value">The value in eighth-points.</param>
  public EighthPoints(UInt32 value)
  {
    this.value = value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="EighthPoints"/> struct from a 32-bit signed integer value.
  /// </summary>
  /// <param name="value">The value in eighth-points.</param>
  public EighthPoints(Int32 value)
  {
    this.value = value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="EighthPoints"/> struct from a 64-bit unsigned integer value.
  /// </summary>
  /// <param name="value">The value in eighth-points.</param>
  public EighthPoints(UInt64 value)
  {
    this.value = (Int64)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="EighthPoints"/> struct from a 64-bit signed integer value.
  /// </summary>
  /// <param name="value">The value in eighth-points.</param>
  public EighthPoints(Int64 value)
  {
    this.value = value;
  }

  /// <summary>
  /// Converts the eighth-points value to millimeters.
  /// </summary>
  /// <returns>The measurement in millimeters as a double-precision floating-point number.</returns>
  public double ToMM()
    => value / EighthPointsInMM;

  /// <summary>
  /// Converts the eighth-points value to centimeters.
  /// </summary>
  /// <returns>The measurement in centimeters as a double-precision floating-point number.</returns>
  public double ToCM()
    => value / EighthPointsInCM;

  /// <summary>
  /// Converts the eighth-points value to inches.
  /// </summary>
  /// <returns>The measurement in inches as a double-precision floating-point number.</returns>
  public double ToInch()
    => value / EighthPointsInInch;

  /// <summary>
  /// Converts the eighth-points value to points.
  /// </summary>
  /// <returns>The measurement in points as a double-precision floating-point number.</returns>
  /// <remarks>
  /// Since there are 8 eighth-points per point, this method divides the internal value by 8.
  /// </remarks>
  public double ToPoints()
    => value / EighthPointsInPoint;

  /// <summary>
  /// Converts the value of this instance to its equivalent string representation.
  /// </summary>
  /// <returns>The string representation of the eighth-points value without unit suffix.</returns>
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
  /// When a unit is specified, the value is converted from eighth-points to the target unit before formatting.
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
  /// When a unit is specified, the value is converted from eighth-points to the target unit before formatting.
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
  /// <para>When a unit is specified, the value is converted from eighth-points to the target unit before formatting.</para>
  /// <para>Supported unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), "in" (inches).</para>
  /// </remarks>
  public string ToString(int precision, IFormatProvider provider, string? unit)
  {
    string format = $"F{precision}";
    if (unit != null)
    {
      if (unit.EndsWith("mm"))
        return (value / EighthPointsInMM).ToString(format, provider) + unit;
      if (unit.EndsWith("cm"))
        return (value / EighthPointsInCM).ToString(format, provider) + unit;
      if (unit.EndsWith("in"))
        return (value / EighthPointsInInch).ToString(format, provider) + unit;
      if (unit.EndsWith("pt"))
        return (value / EighthPointsInPoint).ToString(format, provider) + unit;
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
  /// <para>When a unit is specified, the value is converted from eighth-points to the target unit before formatting.</para>
  /// <para>Supported unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), "in" (inches).</para>
  /// </remarks>
  public string ToString(IFormatProvider provider, string? unit)
  {
    if (unit != null)
    {
      if (unit.EndsWith("mm"))
        return (value / EighthPointsInMM).ToString(provider) + unit;
      if (unit.EndsWith("cm"))
        return (value / EighthPointsInCM).ToString(provider) + unit;
      if (unit.EndsWith("in"))
        return (value / EighthPointsInInch).ToString(provider) + unit;
      if (unit.EndsWith("pt"))
        return (value / EighthPointsInPoint).ToString(provider) + unit;
    }
    return value.ToString();
  }

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a string to an <see cref="EighthPoints"/> value.
  /// </summary>
  /// <param name="value">The string to convert.</param>
  /// <returns>An <see cref="EighthPoints"/> value parsed from the string.</returns>
  public static implicit operator EighthPoints(string value) { return new EighthPoints(value); }

  /// <summary>
  /// Implicitly converts an <see cref="EighthPoints"/> value to a string.
  /// </summary>
  /// <param name="value">The <see cref="EighthPoints"/> value to convert.</param>
  /// <returns>A string representation of the eighth-points value.</returns>
  public static implicit operator string(EighthPoints value) { return value.value.ToString(); }

  /// <summary>
  /// Implicitly converts a 16-bit signed integer to an <see cref="EighthPoints"/> value.
  /// </summary>
  /// <param name="value">The 16-bit signed integer to convert.</param>
  /// <returns>An <see cref="EighthPoints"/> value representing the integer.</returns>
  public static implicit operator EighthPoints(Int16 value) { return new EighthPoints(value); }

  /// <summary>
  /// Implicitly converts an <see cref="EighthPoints"/> value to a 16-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="EighthPoints"/> value to convert.</param>
  /// <returns>A 16-bit signed integer representation of the eighth-points value.</returns>
  public static implicit operator Int16(EighthPoints value) { return (Int16)value.value; }

  /// <summary>
  /// Implicitly converts a 16-bit unsigned integer to an <see cref="EighthPoints"/> value.
  /// </summary>
  /// <param name="value">The 16-bit unsigned integer to convert.</param>
  /// <returns>An <see cref="EighthPoints"/> value representing the integer.</returns>
  public static implicit operator EighthPoints(UInt16 value) { return new EighthPoints(value); }

  /// <summary>
  /// Implicitly converts an <see cref="EighthPoints"/> value to a 16-bit unsigned integer.
  /// </summary>
  /// <param name="value">The <see cref="EighthPoints"/> value to convert.</param>
  /// <returns>A 16-bit unsigned integer representation of the eighth-points value.</returns>
  public static implicit operator UInt16(EighthPoints value) { return (UInt16)value.value; }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer to an <see cref="EighthPoints"/> value.
  /// </summary>
  /// <param name="value">The 32-bit signed integer to convert.</param>
  /// <returns>An <see cref="EighthPoints"/> value representing the integer.</returns>
  public static implicit operator EighthPoints(Int32 value) { return new EighthPoints(value); }

  /// <summary>
  /// Implicitly converts an <see cref="EighthPoints"/> value to a 32-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="EighthPoints"/> value to convert.</param>
  /// <returns>A 32-bit signed integer representation of the eighth-points value.</returns>
  public static implicit operator Int32(EighthPoints value) { return (Int32)value.value; }

  /// <summary>
  /// Implicitly converts a 32-bit unsigned integer to an <see cref="EighthPoints"/> value.
  /// </summary>
  /// <param name="value">The 32-bit unsigned integer to convert.</param>
  /// <returns>An <see cref="EighthPoints"/> value representing the integer.</returns>
  public static implicit operator EighthPoints(UInt32 value) { return new EighthPoints(value); }

  /// <summary>
  /// Implicitly converts an <see cref="EighthPoints"/> value to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="value">The <see cref="EighthPoints"/> value to convert.</param>
  /// <returns>A 32-bit unsigned integer representation of the eighth-points value.</returns>
  public static implicit operator UInt32(EighthPoints value) { return (UInt32)value.value; }

  /// <summary>
  /// Implicitly converts a 64-bit signed integer to an <see cref="EighthPoints"/> value.
  /// </summary>
  /// <param name="value">The 64-bit signed integer to convert.</param>
  /// <returns>An <see cref="EighthPoints"/> value representing the integer.</returns>
  public static implicit operator EighthPoints(Int64 value) { return new EighthPoints(value); }

  /// <summary>
  /// Implicitly converts an <see cref="EighthPoints"/> value to a 64-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="EighthPoints"/> value to convert.</param>
  /// <returns>A 64-bit signed integer representation of the eighth-points value.</returns>
  public static implicit operator Int64(EighthPoints value) { return (Int64)value.value; }

  /// <summary>
  /// Implicitly converts a 64-bit unsigned integer to an <see cref="EighthPoints"/> value.
  /// </summary>
  /// <param name="value">The 64-bit unsigned integer to convert.</param>
  /// <returns>An <see cref="EighthPoints"/> value representing the integer.</returns>
  public static implicit operator EighthPoints(UInt64 value) { return new EighthPoints(value); }

  /// <summary>
  /// Implicitly converts an <see cref="EighthPoints"/> value to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="value">The <see cref="EighthPoints"/> value to convert.</param>
  /// <returns>A 64-bit unsigned integer representation of the eighth-points value.</returns>
  public static implicit operator UInt64(EighthPoints value) { return (UInt64)value.value; }

  #endregion

  /// <summary>
  /// Compares this instance to a specified <see cref="EighthPoints"/> object and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">An <see cref="EighthPoints"/> object to compare.</param>
  /// <returns>
  /// A signed number indicating the relative values of this instance and <paramref name="other"/>.
  /// Less than zero if this instance is less than <paramref name="other"/>;
  /// zero if this instance equals <paramref name="other"/>;
  /// greater than zero if this instance is greater than <paramref name="other"/>.
  /// </returns>
  public int CompareTo(EighthPoints other)
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