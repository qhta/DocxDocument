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
[JsonConverter(typeof(EPSJsonConverter))]
public readonly partial struct EPS: ILengthMeasure, IComparable<EPS>, IEquatable<EPS>
{
  /// <summary>
  /// The internal value storing the measurement in eighth-points.
  /// </summary>
  private readonly Int64 value;

  /// <summary>
  /// Gets the measurement value in eighth-points.
  /// </summary>
  public Int64 Value => value;

  #region Constant factors for unit conversions

  /// <summary>
  /// How many eighth-points are in one millimeter.
  /// There is a small difference between real and nominal factors.
  /// </summary>
  /// <remarks>
  /// The value is approximately 22.68 eighth-points per millimeter, calculated as 576 / 25.4.
  /// </remarks>
  public const double EPSinMM = 576 / 25.4; //22.677795275590551181102362204724;

  /// <summary>
  /// How many eighth-points are in one centimeter.
  /// </summary>
  /// <remarks>
  /// The value is approximately 226.8 eighth-points per centimeter, calculated as EPSinMM * 10.0.
  /// </remarks>
  public const double EPSinCM = EPSinMM * 10.0;

  /// <summary>
  /// How many eighth-points are in one inch.
  /// </summary>
  /// <remarks>
  /// By definition, there are exactly 576 eighth-points in one inch.
  /// </remarks>
  public const double EPSinInch = 576;

  /// <summary>
  /// How many eighth-points are in one point.
  /// </summary>
  /// <remarks>
  /// By definition, there are exactly 8 eighth-points in one point.
  /// </remarks>
  public const double EPSinPT = 8;

  /// <summary>
  /// How many eighth-points are in one twips.
  /// </summary>
  /// <remarks>
  /// By definition, there are exactly 2.5 twips in one eight-point.
  /// </remarks>
  public const double EPSinTwips = 1.0 / 20.0 * 8;

  #endregion

  #region Constructors

  /// <summary>
  /// Initializes a new instance of the <see cref="EPS"/> struct from a string value.
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
  public EPS(string str)
  {
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * EPSinMM;
      value = (Int64)val;
    }
    if (str.EndsWith("cm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * EPSinCM;
      value = (Int64)val;
    }
    else if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * EPSinInch;
      value = (int)val;
    }
    else if (str.EndsWith("pt"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      var val = Double.Parse(str.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) * EPSinPT;
      value = (Int64)val;
    }
    else value = Int32.Parse(str);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="EPS"/> struct from a 32-bit unsigned integer value.
  /// </summary>
  /// <param name="value">The value in eighth-points.</param>
  public EPS(UInt32 value)
  {
    this.value = value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="EPS"/> struct from a 32-bit signed integer value.
  /// </summary>
  /// <param name="value">The value in eighth-points.</param>
  public EPS(Int32 value)
  {
    this.value = value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="EPS"/> struct from a 64-bit unsigned integer value.
  /// </summary>
  /// <param name="value">The value in eighth-points.</param>
  public EPS(UInt64 value)
  {
    this.value = (Int64)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="EPS"/> struct from a 64-bit signed integer value.
  /// </summary>
  /// <param name="value">The value in eighth-points.</param>
  public EPS(Int64 value)
  {
    this.value = value;
  }

  #endregion

  #region Conversion Methods

  /// <summary>
  /// Converts the eighth-points value to millimeters.
  /// </summary>
  /// <returns>The measurement in millimeters as a double-precision floating-point number.</returns>
  public double ToMM() => value / EPSinMM;

  /// <summary>
  /// Converts the eighth-points value to centimeters.
  /// </summary>
  /// <returns>The measurement in centimeters as a double-precision floating-point number.</returns>
  public double ToCM() => value / EPSinCM;

  /// <summary>
  /// Converts the eighth-points value to inches.
  /// </summary>
  /// <returns>The measurement in inches as a double-precision floating-point number.</returns>
  public double ToInch() => value / EPSinInch;

  /// <summary>
  /// Converts the eighth-points value to points.
  /// </summary>
  /// <returns>The measurement in points as a double-precision floating-point number.</returns>
  /// <remarks>
  /// Since there are 8 eighth-points per point, this method divides the internal value by 8.
  /// </remarks>
  public double ToPT() => value / EPSinPT;

  /// <summary>
  /// Converts the eighth-points value to twips.
  /// </summary>
  /// <returns>The measurement in twips as a double-precision floating-point number.</returns>
  public double ToTwips() => value / EPSinTwips;

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
  public static ILengthMeasure FromTwips(double twips) => new EPS((Int64)(twips * EPSinTwips));

  /// <summary>
  /// Creates an instance of an <see cref="ILengthMeasure"/> that represents the specified value in points.
  /// </summary>
  public static ILengthMeasure FromPT(double points) => new EPS((Int64)(points * EPSinPT));

  /// <summary>
  /// Creates a new instance of an object that represents a length specified in millimeters.
  /// </summary>
  public static ILengthMeasure FromMM(double millimeters) => new EPS((Int64)(millimeters * EPSinMM));

  /// <summary>
  /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in
  /// centimeters.
  /// </summary>
  public static ILengthMeasure FromCM(double centimeters) => new EPS((Int64)(centimeters * EPSinCM));

  /// <summary>
  /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in inches.
  /// </summary>
  public static ILengthMeasure FromInch(double inches) => new EPS((Int64)(inches * EPSinInch));

  /// <summary>
  /// Converts a length value from the specified unit to an ILengthMeasure representation.
  /// </summary>
  /// <remarks>Supported units include Twips, Points, Millimeters, Centimeters, and Inches. Ensure that the unit
  /// parameter is set to a valid LengthUnit value to avoid exceptions.</remarks>
  /// <param name="value">The numeric length value to convert, expressed in the unit specified by the unit parameter.</param>
  /// <param name="unit">The unit of measurement for the value parameter. Must be one of the supported LengthUnit values.</param>
  /// <returns>An ILengthMeasure instance representing the converted length value in a standard format.</returns>
  /// <exception cref="ArgumentException">Thrown if the specified unit is not supported for conversion.</exception>
  public static ILengthMeasure ConvertFrom(double value, LengthUnit unit)
  {
    return unit switch
    {
      LengthUnit.Twips => FromTwips(value),
      LengthUnit.Points => FromPT(value),
      LengthUnit.Millimeters => FromMM(value),
      LengthUnit.Centimeters => FromCM(value),
      LengthUnit.Inches => FromInch(value),
      _ => throw new ArgumentException($"Unsupported length unit: {unit}", nameof(unit))
    };
  }

  #endregion

  #region ILengthMeasure parsing implementation

  /// <summary>
  /// Parses a string representation of a length measure and returns the corresponding ILengthMeasure instance.
  /// </summary>
  /// <remarks>If the input string does not conform to a valid length measure format, an exception may be
  /// thrown.</remarks>
  /// <param name="value">The string that represents the length measure to parse. The value must be in a format recognized by the parser.</param>
  /// <returns>An instance of ILengthMeasure that represents the parsed length measure.</returns>
  public static ILengthMeasure Parse(string value) => new EPS(value);

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
      result = new EPS(value);
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
  public static string[] LengthUnitSuffixes { get; } = ["twips", "pt", "mm", "cm", "in"];

  #endregion

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a string to an <see cref="EPS"/> value.
  /// </summary>
  /// <param name="value">The string to convert.</param>
  /// <returns>An <see cref="EPS"/> value parsed from the string.</returns>
  public static implicit operator EPS(string value)
  {
    return new EPS(value);
  }

  /// <summary>
  /// Implicitly converts an <see cref="EPS"/> value to a string.
  /// </summary>
  /// <param name="value">The <see cref="EPS"/> value to convert.</param>
  /// <returns>A string representation of the eighth-points value.</returns>
  public static implicit operator string(EPS value)
  {
    return value.value.ToString();
  }

  /// <summary>
  /// Implicitly converts a 16-bit signed integer to an <see cref="EPS"/> value.
  /// </summary>
  /// <param name="value">The 16-bit signed integer to convert.</param>
  /// <returns>An <see cref="EPS"/> value representing the integer.</returns>
  public static implicit operator EPS(Int16 value)
  {
    return new EPS(value);
  }

  /// <summary>
  /// Implicitly converts an <see cref="EPS"/> value to a 16-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="EPS"/> value to convert.</param>
  /// <returns>A 16-bit signed integer representation of the eighth-points value.</returns>
  public static implicit operator Int16(EPS value)
  {
    return (Int16)value.value;
  }

  /// <summary>
  /// Implicitly converts a 16-bit unsigned integer to an <see cref="EPS"/> value.
  /// </summary>
  /// <param name="value">The 16-bit unsigned integer to convert.</param>
  /// <returns>An <see cref="EPS"/> value representing the integer.</returns>
  public static implicit operator EPS(UInt16 value)
  {
    return new EPS(value);
  }

  /// <summary>
  /// Implicitly converts an <see cref="EPS"/> value to a 16-bit unsigned integer.
  /// </summary>
  /// <param name="value">The <see cref="EPS"/> value to convert.</param>
  /// <returns>A 16-bit unsigned integer representation of the eighth-points value.</returns>
  public static implicit operator UInt16(EPS value)
  {
    return (UInt16)value.value;
  }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer to an <see cref="EPS"/> value.
  /// </summary>
  /// <param name="value">The 32-bit signed integer to convert.</param>
  /// <returns>An <see cref="EPS"/> value representing the integer.</returns>
  public static implicit operator EPS(Int32 value)
  {
    return new EPS(value);
  }

  /// <summary>
  /// Implicitly converts an <see cref="EPS"/> value to a 32-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="EPS"/> value to convert.</param>
  /// <returns>A 32-bit signed integer representation of the eighth-points value.</returns>
  public static implicit operator Int32(EPS value)
  {
    return (Int32)value.value;
  }

  /// <summary>
  /// Implicitly converts a 32-bit unsigned integer to an <see cref="EPS"/> value.
  /// </summary>
  /// <param name="value">The 32-bit unsigned integer to convert.</param>
  /// <returns>An <see cref="EPS"/> value representing the integer.</returns>
  public static implicit operator EPS(UInt32 value)
  {
    return new EPS(value);
  }

  /// <summary>
  /// Implicitly converts an <see cref="EPS"/> value to a 32-bit unsigned integer.
  /// </summary>
  /// <param name="value">The <see cref="EPS"/> value to convert.</param>
  /// <returns>A 32-bit unsigned integer representation of the eighth-points value.</returns>
  public static implicit operator UInt32(EPS value)
  {
    return (UInt32)value.value;
  }

  /// <summary>
  /// Implicitly converts a 64-bit signed integer to an <see cref="EPS"/> value.
  /// </summary>
  /// <param name="value">The 64-bit signed integer to convert.</param>
  /// <returns>An <see cref="EPS"/> value representing the integer.</returns>
  public static implicit operator EPS(Int64 value)
  {
    return new EPS(value);
  }

  /// <summary>
  /// Implicitly converts an <see cref="EPS"/> value to a 64-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="EPS"/> value to convert.</param>
  /// <returns>A 64-bit signed integer representation of the eighth-points value.</returns>
  public static implicit operator Int64(EPS value)
  {
    return (Int64)value.value;
  }

  /// <summary>
  /// Implicitly converts a 64-bit unsigned integer to an <see cref="EPS"/> value.
  /// </summary>
  /// <param name="value">The 64-bit unsigned integer to convert.</param>
  /// <returns>An <see cref="EPS"/> value representing the integer.</returns>
  public static implicit operator EPS(UInt64 value)
  {
    return new EPS(value);
  }

  /// <summary>
  /// Implicitly converts an <see cref="EPS"/> value to a 64-bit unsigned integer.
  /// </summary>
  /// <param name="value">The <see cref="EPS"/> value to convert.</param>
  /// <returns>A 64-bit unsigned integer representation of the eighth-points value.</returns>
  public static implicit operator UInt64(EPS value)
  {
    return (UInt64)value.value;
  }

  #endregion

  #region IComparable and IEquatable implementations

  /// <summary>
  /// Compares this instance to a specified <see cref="EPS"/> object and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">An <see cref="EPS"/> object to compare.</param>
  /// <returns>
  /// A signed number indicating the relative values of this instance and <paramref name="other"/>.
  /// Less than zero if this instance is less than <paramref name="other"/>;
  /// zero if this instance equals <paramref name="other"/>;
  /// greater than zero if this instance is greater than <paramref name="other"/>.
  /// </returns>
  public int CompareTo(EPS other)
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
  /// Compares this instance to another <see cref="EPS"/> object for equality.
  /// </summary>
  /// <param name="other">An <see cref="EPS"/> object to compare.</param>
  /// <returns><c>true</c> if the objects are equal; otherwise, <c>false</c>.</returns>
  public bool Equals(EPS other)
  {
    return value == other.value;
  }

  /// <summary>
  /// Determines whether the specified object is equal to the current instance of EPS.
  /// </summary>
  /// <remarks>This method overrides Object.Equals to provide value equality comparison specific to EPS
  /// instances.</remarks>
  /// <param name="obj">The object to compare with the current EPS instance. This parameter can be null.</param>
  /// <returns>true if the specified object is an instance of EPS and is equal to the current instance; otherwise,
  /// false.</returns>
  public override bool Equals(object? obj)
  {
    return obj is EPS other && Equals(other);
  }

  #endregion
}