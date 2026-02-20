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
public readonly partial struct HPS: ILengthMeasure, IComparable<HPS>, IEquatable<HPS>, IEquatable<object>
{
  /// <summary>
  /// The internal value storing the measurement in half-points.
  /// </summary>
  private readonly Double value;

  /// <summary>
  /// Gets the value of this instance in half-points.
  /// </summary>
  public Double Value => value;

  #region Constant Factors

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

  #endregion

  #region Constructors

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
    str = str.Replace(",", ".").Trim();
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      value = Double.Parse(str, CultureInfo.InvariantCulture) * HPSinMM;
      return;
    }
    if (str.EndsWith("cm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      value = Double.Parse(str, CultureInfo.InvariantCulture) * HPSinCM;
      return;
    }
    if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      value = Double.Parse(str, CultureInfo.InvariantCulture) * HPSinInch;
      return;
    }
    if (str.EndsWith("pt"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      value = Double.Parse(str, CultureInfo.InvariantCulture) * HPSinPT;
      return;
    }
    if (str.EndsWith("tw"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      value = Double.Parse(str, CultureInfo.InvariantCulture) * HPSinTwips;
      return;
    }
    value = Double.Parse(str, CultureInfo.InvariantCulture);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="HPS"/> struct from a 64-bit signed integer value.
  /// </summary>
  /// <param name="value">The value in half-points.</param>
  public HPS(Int64 value)
  {
    this.value = value;
  }


  /// <summary>
  /// Initializes a new instance of the <see cref="HPS"/> struct from a 64-bit floating-point value.
  /// </summary>
  /// <param name="value">The value in half-points.</param>
  public HPS(Double value)
  {
    this.value = value;
  }

  #endregion

  #region Conversion methods

  /// <summary>
  /// Converts the half-points value to millimeters.
  /// </summary>
  /// <returns>The measurement in millimeters as a double-precision floating-point number.</returns>
  public double ToMM() => value / HPSinMM;

  /// <summary>
  /// Converts the half-points value to centimeters.
  /// </summary>
  /// <returns>The measurement in centimeters as a double-precision floating-point number.</returns>
  public double ToCM() => value / HPSinCM;

  /// <summary>
  /// Converts the half-points value to inches.
  /// </summary>
  /// <returns>The measurement in inches as a double-precision floating-point number.</returns>
  public double ToInch() => value / HPSinInch;

  /// <summary>
  /// Converts the half-points value to points.
  /// </summary>
  /// <returns>The measurement in points as a double-precision floating-point number.</returns>
  /// <remarks>
  /// Since there are 2 half-points per point, this method divides the internal value by 2.
  /// </remarks>
  public double ToPT() => value / HPSinPT;

  /// <summary>
  /// Converts the half-points value to twips.
  /// </summary>
  /// <returns>The measurement in twips as a double-precision floating-point number.</returns>
  public double ToTwips() => value / HPSinTwips;

  /// <summary>
  /// Converts the current length value to the specified unit of measurement.
  /// </summary>
  /// <param name="unit">The target unit to which the length value will be converted. Supported units include Twips, Points, Millimeters,
  /// Centimeters, and Inches.</param>
  /// <returns>The length value converted to the specified unit.</returns>
  /// <exception cref="ArgumentException">Thrown if the specified unit is not supported.</exception>
  public double ConvertTo(LengthUnit unit)
  {
    return unit switch
    {
      LengthUnit.Twips => ToTwips(),
      LengthUnit.Points => ToPT(),
      LengthUnit.Millimeters => ToMM(),
      LengthUnit.Centimeters => ToCM(),
      LengthUnit.Inches => ToInch(),
      _ => throw new ArgumentException($"Unsupported length unit: {unit}", nameof(unit))
    };
  }

  #endregion

  #region Static Factory Methods

  /// <summary>
  /// Creates an instance of an <see cref="ILengthMeasure"/> that represents the specified value in twips.
  /// </summary>
  public static ILengthMeasure FromTwips(double twips) => new HPS((Int64)(twips * HPSinTwips));

  /// <summary>
  /// Creates an instance of an <see cref="ILengthMeasure"/> that represents the specified value in points.
  /// </summary>
  public static ILengthMeasure FromPT(double points) => new HPS((Int64)(points * HPSinPT));

  /// <summary>
  /// Creates a new instance of an object that represents a length specified in millimeters.
  /// </summary>
  public static ILengthMeasure FromMM(double millimeters) => new HPS((Int64)(millimeters * HPSinMM));

  /// <summary>
  /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in
  /// centimeters.
  /// </summary>
  public static ILengthMeasure FromCM(double centimeters) => new HPS((Int64)(centimeters * HPSinCM));

  /// <summary>
  /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in inches.
  /// </summary>
  public static ILengthMeasure FromInch(double inches) => new HPS((Int64)(inches * HPSinInch));

  /// <summary>
  /// Parses a string representation of a length measure and returns the corresponding ILengthMeasure instance.
  /// </summary>
  /// <remarks>If the input string does not conform to a valid length measure format, an exception may be
  /// thrown.</remarks>
  /// <param name="value">The string that represents the length measure to parse. The value must be in a format recognized by the parser.</param>
  /// <returns>An instance of ILengthMeasure that represents the parsed length measure.</returns>
  public static ILengthMeasure Parse(string value) => new HPS(value);

  /// <summary>
  /// Converts a length value from the specified unit to an equivalent length measure.
  /// </summary>
  /// <remarks>Use this method to create an ILengthMeasure instance from a raw numeric value and its associated
  /// unit. Ensure that the provided unit is valid to avoid conversion errors.</remarks>
  /// <param name="value">The numeric value representing the length to convert.</param>
  /// <param name="unit">The unit of the input length value, specified as a member of the LengthUnit enumeration.</param>
  /// <returns>An object that represents the converted length value as an ILengthMeasure.</returns>
  public static ILengthMeasure ConvertFrom(double value, LengthUnit unit) => unit switch
  {
    LengthUnit.Twips => FromTwips(value),
    LengthUnit.Points => FromPT(value),
    LengthUnit.Millimeters => FromMM(value),
    LengthUnit.Centimeters => FromCM(value),
    LengthUnit.Inches => FromInch(value),
    _ => throw new ArgumentException($"Unsupported length unit: {unit}", nameof(unit))
  };

  #endregion

  #region Parsing Methods

  /// <summary>
  /// Attempts to parse the specified string representation of a length measure and returns a value that indicates
  /// whether the parsing succeeded.
  /// </summary>
  /// <remarks>This method does not throw an exception if parsing fails. Instead, it returns <see
  /// langword="false"/> and sets <paramref name="result"/> to <see langword="null"/>.</remarks>
  /// <param name="value">The string representation of the length measure to parse.</param>
  /// <param name="result">When this method returns, contains the parsed length measure if the parsing succeeded; otherwise, <see
  /// langword="null"/>.</param>
  /// <returns><see langword="true"/> if the string was parsed successfully; otherwise, <see langword="false"/>.</returns>
  public static bool TryParse(string value, out ILengthMeasure? result)
  {
    try
    {
      result = new HPS(value);
      return true;
    } catch
    {
      result = null!;
      return false;
    }
  }

  #endregion
  
  #region ToString conversions

  /// <summary>
  /// Converts the current length measure to its string representation. Raw number formats are expected in InvariantCulture.
  /// </summary>
  public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);

  /// <summary>
  /// Converts the current length measure to its string representation using the specified format provider.
  /// This allows for culture-specific formatting of the output string, such as using different decimal separators
  /// based on the culture settings provided by the formatProvider.
  /// If the formatProvider is null, the method should use invariant culture's formatting conventions.
  /// </summary>
  /// <param name="formatProvider">An object that supplies culture-specific formatting information. If null, invariant culture's formatting conventions are used.</param>
  /// <returns>A string representation of the current length measure, formatted according to the specified format provider.</returns>
  public string ToString(IFormatProvider? formatProvider)
    => Value.ToString(formatProvider ?? CultureInfo.InvariantCulture);

  /// <summary>
  /// Converts the current length measure to its string representation using the specified format string and format provider.
  /// The format string can specify how the numeric value should be formatted (e.g., number of decimal places, unit symbols)
  /// while the format provider allows for culture-specific formatting.
  /// If the format string is null or empty, a default numeric format should be used.
  /// If the format provider is null, invariant culture's formatting conventions should be applied.
  /// </summary>
  /// <param name="format">A standard or custom numeric format string. If null or empty, a default numeric format is used.</param>
  /// <param name="formatProvider">An object that supplies culture-specific formatting information.
  /// If null, invariant culture's formatting conventions are used.</param>
  /// <returns>A string representation of the current length measure,
  /// formatted according to the specified format string and format provider.</returns>
  public string ToString(string? format, IFormatProvider? formatProvider)
    => Value.ToString(format, formatProvider ?? CultureInfo.InvariantCulture);

  /// <summary>
  /// Converts the current instance to its string representation using the specified format string.
  /// </summary>
  /// <remarks>If the format string is not recognized or is invalid, a FormatException may be thrown. Supported
  /// format strings may include both standard and custom formats, depending on the implementation.</remarks>
  /// <param name="format">A format string that defines how the value should be represented.
  /// If null, a default format is used.</param>
  /// <returns>A string representation of the current instance, formatted according to the specified format string.</returns>
  public string ToString(string? format) => Value.ToString(format);

  /// <summary>
  /// Converts the current length measure to its string representation using the specified unit.
  ///   The output string should include the numeric value followed by the appropriate unit symbol (e.g., "10 mm", "2.5 in").
  /// </summary>
  /// <param name="unit">The unit to use for the string representation.</param>
  /// <returns>A string representation of the current length measure, formatted according to the specified unit.</returns>
  public string ToString(LengthUnit unit)
    => $"{ConvertTo(unit).ToString(CultureInfo.InvariantCulture)} {LengthUnitSuffixes[(int)unit]}";

  /// <summary>
  /// Converts the current length measure to its string representation using the specified unit and format provider.
  ///   The output string should include the numeric value followed by the appropriate unit symbol (e.g., "10 mm", "2.5 in").
  /// </summary>
  /// <param name="formatProvider">An object that supplies culture-specific formatting information. If null, invariant culture's formatting conventions are used.</param>
  /// <param name="unit">The unit to use for the string representation.</param>
  /// <returns>A string representation of the current length measure, formatted according to the specified unit and format provider.</returns>
  public string ToString(IFormatProvider? formatProvider, LengthUnit unit)
  => $"{ConvertTo(unit).ToString(formatProvider ?? CultureInfo.InvariantCulture)} {LengthUnitSuffixes[(int)unit]}";

  /// <summary>
  /// Converts the current length value to its string representation using the specified unit, format, and format
  /// provider. 
  /// The output should include the numeric value followed by the appropriate unit symbol (e.g., "10 mm", "2.5 in").
  /// Format string should not include unit symbols, as they will be added based on the specified unit parameter.
  /// If the format string is null or empty, a default numeric format should be used.
  /// </summary>
  /// <param name="format">A standard or custom numeric format string that defines how the value is formatted. If null, the default format is
  ///   used.</param>
  /// <param name="formatProvider">An object that supplies culture-specific formatting information. If null, the current culture is used.</param>
  /// <param name="unit">The unit of length to use when formatting the value.</param>
  /// <returns>A string representation of the current length value, formatted according to the specified unit, format, and format
  /// provider.</returns>
  public string ToString(string? format, IFormatProvider? formatProvider, LengthUnit unit)
      => $"{ConvertTo(unit).ToString(format, formatProvider ?? CultureInfo.InvariantCulture)} {LengthUnitSuffixes[(int)unit]}";

  /// <summary>
  /// Converts the current length value to its string representation using the specified unit and format string.
  /// The output should include the numeric value followed by the appropriate unit symbol (e.g., "10 mm", "2.5 in").
  /// </summary>
  /// <param name="format">A standard or custom numeric format string that defines how the value is formatted. If null, the default format is used.</param>
  /// <param name="unit">The unit of length to use when formatting the value.</param>
  /// <returns>A string representation of the current length value, formatted according to the specified unit and format string.</returns>
  public string ToString(string? format, LengthUnit unit)
        => $"{ConvertTo(unit).ToString(format, CultureInfo.InvariantCulture)} {LengthUnitSuffixes[(int)unit]}";

  /// <summary>
  /// Suffixes for length units that can be used in string representations of length measures.
  /// The order of the suffixes corresponds to the order of the LengthUnit enum values.
  /// </summary>
  public static string[] LengthUnitSuffixes { get; } = ["tw", "pt", "mm", "cm", "in"];

  #endregion

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a string to a <see cref="HPS"/> value.
  /// </summary>
  /// <param name="value">The string to convert.</param>
  /// <returns>A <see cref="HPS"/> value parsed from the string.</returns>
  public static implicit operator HPS(string value)
  {
    return new HPS(value);
  }

  /// <summary>
  /// Implicitly converts a <see cref="HPS"/> value to a string.
  /// </summary>
  /// <param name="value">The <see cref="HPS"/> value to convert.</param>
  /// <returns>A string representation of the half-points value.</returns>
  public static implicit operator string(HPS value)
  {
    return value.value.ToString(CultureInfo.InvariantCulture);
  }

  /// <summary>
  /// Implicitly converts a HPS instance to a 32-bit signed integer (Int32).
  /// </summary>
  /// <remarks>This conversion allows for seamless integration of HPS values in contexts where an Int32 is
  /// expected. Ensure that the HPS value is within the range of Int32 to avoid overflow.</remarks>
  /// <param name="value">The HPS instance to convert.</param>
  public static implicit operator Int32(HPS value)
  {
    return (Int32)value.value;
  }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer to a <see cref="HPS"/> value.
  /// </summary>
  /// <param name="value">The 32-bit signed integer to convert.</param>
  /// <returns>A <see cref="HPS"/> value representing the integer.</returns>
  public static implicit operator HPS(Int32 value)
  {
    return new HPS(value);
  }

  /// <summary>
  /// Implicitly converts a 64-bit signed integer to a <see cref="HPS"/> value.
  /// </summary>
  /// <param name="value">The 64-bit signed integer to convert.</param>
  /// <returns>A <see cref="HPS"/> value representing the integer.</returns>
  public static implicit operator HPS(Int64 value)
  {
    return new HPS(value);
  }

  /// <summary>
  /// Implicitly converts a <see cref="HPS"/> value to a 64-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="HPS"/> value to convert.</param>
  /// <returns>A 64-bit signed integer representation of the half-points value.</returns>
  public static implicit operator Int64(HPS value)
  {
    return (Int64)value.value;
  }
  
  /// <summary>
  /// Implicitly converts a double-precision floating-point number to a <see cref="HPS"/> value.
  /// </summary>
  /// <param name="value">The double-precision floating-point number to convert.</param>
  /// <returns>A <see cref="HPS"/> value representing the double-precision floating-point number.</returns>
  public static implicit operator HPS(Double value) { return new HPS(value); }

  #endregion

  #region IComparable and IEquatable Implementations

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
  /// Compares this instance to a specified object and returns a value that indicates whether they are equal.
  /// </summary>
  /// <param name="obj">The object to compare with the current HPS instance. This parameter can be null.</param>
  /// <returns><c>true</c> if the specified object is equal to the current HPS instance; otherwise, <c>false</c>.</returns>
  public override bool Equals(object? obj)
  {
    if (obj is HPS otherHPS)
      return Equals(otherHPS);
    if (obj is ILengthMeasure otherMeasure)
    {
      try
      {
        var thisPoints = ConvertTo(LengthUnit.Points);
        var otherPointsConvertTo = otherMeasure.ConvertTo(LengthUnit.Points);
        return System.Math.Abs(thisPoints - otherPointsConvertTo) < 1e-10;
      }
      catch
      {
        return false;
      }
    }
    if (obj is IConvertible convertible)
    {
      try
      {
        var otherValue = convertible.ToDouble(CultureInfo.InvariantCulture);
        return System.Math.Abs(value - otherValue) < 1e-10;
      }
      catch
      {
        return false;
      }
    }
    return false;
  }

  #endregion
}