namespace DocumentModel;

/// <summary>
///   Represents an English Metric Unit (EMU), used for precise measurements in drawings.
///   There are 914400 EMUs per inch.
/// </summary>
[JsonConverter(typeof(EMUJsonConverter))]
public readonly partial struct EMU : ILengthValue, IComparable<EMU>, IEquatable<EMU>, IEquatable<object>
{

  private readonly Double value;

  /// <summary>
  /// Gets the current value represented by this instance.
  /// </summary>
  public Double Value => value;

  #region Constant Factors

  /// <summary>
  /// How many EMU are in one millimeter.
  /// There is a small difference between real and nominal factors.
  /// </summary>
  /// <remarks>
  /// The value is approximately 36000 EMU per millimeter, calculated as 914400 / 25.4.
  /// </remarks>
  public const double EMUinMM = 914400 / 25.4;

  /// <summary>
  /// How many EMU are in one centimeter.
  /// There is a small difference between real and nominal factors.
  /// </summary>
  /// <remarks>
  /// The value is approximately 360000 EMU per centimeter, calculated as EMUinMM * 10.0.
  /// </remarks>
  public const double EMUinCM = EMUinMM * 10.0;

  /// <summary>
  /// How many EMU are in one inch.
  /// </summary>
  /// <remarks>
  /// By definition, there are exactly 914400 EMU in one inch.
  /// </remarks>
  public const double EMUinInch = 914400;

  /// <summary>
  /// How many EMU are in one point.
  /// </summary>
  /// <remarks>
  /// By definition, there are proximately 12694 EMU in one point (1/72 of an inch).
  /// </remarks>
  public const double EMUinPT = EMUinInch / 72.0;

  /// <summary>
  /// How many EMU are in one twips.
  /// </summary>
  /// <remarks>
  /// By definition, there are exactly 635 EMU in one twip (1/1440 of an inch, or 1/20 of a point).
  /// </remarks>
  public const double EMUinTwips = EMUinPT / 20.0;

  #endregion

  #region Constructors

  /// <summary>
  /// Initializes a new instance of the <see cref="EMU"/> struct from a string value.
  /// </summary>
  /// <param name="str">The string value to parse. Can include optional unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), or "in" (inches).</param>
  /// <remarks>
  /// <para>Supported formats:</para>
  /// <list type="bullet">
  /// <item><description>"100" - interpreted as EMU</description></item>
  /// <item><description>"10mm" - millimeters</description></item>
  /// <item><description>"1cm" - centimeters</description></item>
  /// <item><description>"12pt" - points</description></item>
  /// <item><description>"1in" - inches</description></item>
  /// </list>
  /// <para>Commas in the input string are replaced with periods before parsing to ensure decimal separator consistency.</para>
  /// </remarks>
  public EMU(string str)
  {
    str = str.Replace(",", ".").Trim();
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      value = Double.Parse(str, CultureInfo.InvariantCulture) * EMUinMM;
      return;
    }
    if (str.EndsWith("cm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      value = Double.Parse(str, CultureInfo.InvariantCulture) * EMUinCM;
      return;
    }
    if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      value = Double.Parse(str, CultureInfo.InvariantCulture) * EMUinInch;
      return;
    }
    if (str.EndsWith("pt"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      value = Double.Parse(str, CultureInfo.InvariantCulture) * EMUinPT;
      return;
    }
    if (str.EndsWith("tw"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      value = Double.Parse(str, CultureInfo.InvariantCulture) * EMUinTwips;
      return;
    }
    value = Double.Parse(str, CultureInfo.InvariantCulture);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="EMU"/> struct from a 64-bit signed integer value.
  /// </summary>
  /// <param name="value">The value in EMU.</param>
  public EMU(Int64 value)
  {
    this.value = value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="EMU"/> struct from a 64-bit floating-point value.
  /// </summary>
  /// <param name="value">The value in EMU.</param>
  public EMU(Double value)
  {
    this.value = value;
  }

  #endregion

  #region Conversion Methods
  /// <summary>
  /// Converts the EMU value to millimeters.
  /// </summary>
  /// <returns>The measurement in millimeters as a double-precision floating-point number.</returns>
  public double ToMM()
    => value / EMUinMM;

  /// <summary>
  /// Converts the EMU value to centimeters.
  /// </summary>
  /// <returns>The measurement in centimeters as a double-precision floating-point number.</returns>
  public double ToCM()
    => value / EMUinCM;

  /// <summary>
  /// Converts the EMU value to inches.
  /// </summary>
  /// <returns>The measurement in inches as a double-precision floating-point number.</returns>
  public double ToInch()
    => value / EMUinInch;

  /// <summary>
  /// Converts the EMU value to points.
  /// </summary>
  /// <returns>The measurement in points as a double-precision floating-point number.</returns>
  /// <remarks>
  /// A point is defined as 1/72 of an inch.
  /// </remarks>
  public double ToPT()
    => value / EMUinPT;
  
  /// <summary>
  /// Converts the EMU value to twips.
  /// </summary>
  /// <returns>The measurement in twips as a double-precision floating-point number.</returns>
  public double ToTwips()
    => value / EMUinTwips;

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
  /// Creates an instance of an <see cref="ILengthValue"/> that represents the specified value in twips.
  /// </summary>
  public static ILengthValue FromTwips(double twips) => new EMU((Int64)(twips * EMUinTwips));

  /// <summary>
  /// Creates an instance of an <see cref="ILengthValue"/> that represents the specified value in points.
  /// </summary>
  public static ILengthValue FromPT(double points) => new EMU((Int64)(points * EMUinPT));

  /// <summary>
  /// Creates a new instance of an object that represents a length specified in millimeters.
  /// </summary>
  public static ILengthValue FromMM(double millimeters) => new EMU((Int64)(millimeters * EMUinMM));

  /// <summary>
  /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in
  /// centimeters.
  /// </summary>
  public static ILengthValue FromCM(double centimeters) => new EMU((Int64)(centimeters * EMUinCM));

  /// <summary>
  /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in inches.
  /// </summary>
  public static ILengthValue FromInch(double inches) => new EMU((Int64)(inches * EMUinInch));


  /// <summary>
  /// Converts a length value from the specified unit to an equivalent length measure.
  /// </summary>
  /// <remarks>Use this method to create an ILengthMeasure instance from a raw numeric value and its associated
  /// unit. Ensure that the provided unit is valid to avoid conversion errors.</remarks>
  /// <param name="value">The numeric value representing the length to convert.</param>
  /// <param name="unit">The unit of the input length value, specified as a member of the LengthUnit enumeration.</param>
  /// <returns>An object that represents the converted length value as an ILengthMeasure.</returns>
  public static ILengthValue ConvertFrom(double value, LengthUnit unit)
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

  #region Parsing Methods

  /// <summary>
  /// Parses a string representation of a length measure and returns the corresponding ILengthMeasure instance.
  /// </summary>
  /// <remarks>If the input string does not conform to a valid length measure format, an exception may be
  /// thrown.</remarks>
  /// <param name="value">The string that represents the length measure to parse. The value must be in a format recognized by the parser.</param>
  /// <returns>An instance of ILengthMeasure that represents the parsed length measure.</returns>
  public static ILengthValue Parse(string value) => new EMU(value);

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
  public static bool TryParse(string value, out ILengthValue? result)
  {
    try
    {
      result = new EMU(value);
      return true;
    }
    catch
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
  /// Implicitly converts a string to a <see cref="EMU"/> value.
  /// </summary>
  /// <param name="value">The string to convert.</param>
  /// <returns>A <see cref="EMU"/> value parsed from the string.</returns>
  public static implicit operator EMU(string value) { return new EMU(value); }

  /// <summary>
  /// Implicitly converts a <see cref="EMU"/> value to a string.
  /// </summary>
  /// <param name="value">The <see cref="EMU"/> value to convert.</param>
  /// <returns>A string representation of the EMU value.</returns>
  public static implicit operator string(EMU value) { return value.value.ToString(CultureInfo.InvariantCulture); }

  /// <summary>
  /// Implicitly converts a 64-bit signed integer to a <see cref="EMU"/> value.
  /// </summary>
  /// <param name="value">The 64-bit signed integer to convert.</param>
  /// <returns>A <see cref="EMU"/> value representing the integer.</returns>
  public static implicit operator EMU(Int64 value) { return new EMU(value); }

  /// <summary>
  /// Implicitly converts a <see cref="EMU"/> value to a 64-bit signed integer.
  /// </summary>
  /// <param name="value">The <see cref="EMU"/> value to convert.</param>
  /// <returns>A 64-bit signed integer representation of the EMU value.</returns>
  public static implicit operator Int64(EMU value) { return (Int64)value.value; }
  
  /// <summary>
  /// Implicitly converts a double-precision floating-point number to a <see cref="EMU"/> value.
  /// </summary>
  /// <param name="value">The double-precision floating-point number to convert.</param>
  /// <returns>A <see cref="EMU"/> value representing the double-precision floating-point number.</returns>
  public static implicit operator EMU(Double value) { return new EMU(value); }

  #endregion

  #region IComparable and IEquatable Implementations

  /// <summary>
  /// Compares this instance to a specified <see cref="EMU"/> object and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">A <see cref="EMU"/> object to compare.</param>
  /// <returns>
  /// A signed number indicating the relative values of this instance and <paramref name="other"/>.
  /// Less than zero if this instance is less than <paramref name="other"/>;
  /// zero if this instance equals <paramref name="other"/>;
  /// greater than zero if this instance is greater than <paramref name="other"/>.
  /// </returns>
  public int CompareTo(EMU other)
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
  /// Indicates whether the current object is equal to another object of the same type.
  /// </summary>
  /// <param name="other">An object to compare with this object.</param>
  /// <returns><see langword="true"/> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
  public bool Equals(EMU other)
  {
    return value.Equals(other.value);
  }

  /// <summary>
  /// Compares this instance to a specified object and returns a value that indicates whether they are equal.
  /// </summary>
  /// <param name="obj">The object to compare with the current EMU instance. This parameter can be null.</param>
  /// <returns><c>true</c> if the specified object is equal to the current EMU instance; otherwise, <c>false</c>.</returns>
  public override bool Equals(object? obj)
  {
    if (obj is EMU otherEMU)
      return Equals(otherEMU);
    if (obj is ILengthValue otherMeasure)
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
