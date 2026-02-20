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
public readonly partial struct Twips: ILengthMeasure, IComparable<Twips>, IEquatable<Twips>
{
  private readonly Double value;

  /// <summary>
  /// Gets the current value represented by this instance.
  /// </summary>
  public Double Value => value;

  #region Constant factors for unit conversions

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
  /// The value is approximately 566.9 twips per centimeter, calculated as TwipsInMM * 10.0.
  /// </remarks>
  public const double TwipsInCM = TwipsInMM * 10.0;

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
  public const double TwipsInPT = 20;

  #endregion

  #region Constructors

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
    str = str.Replace(",", ".").Trim();
    if (str.EndsWith("mm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      value = Double.Parse(str, CultureInfo.InvariantCulture) * TwipsInMM;
      return;
    }
    if (str.EndsWith("cm"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      value = Double.Parse(str, CultureInfo.InvariantCulture) * TwipsInCM;
      return;
    }
    if (str.EndsWith("in"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      value = Double.Parse(str, CultureInfo.InvariantCulture) * TwipsInInch;
      return;
    }
    if (str.EndsWith("pt"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      value = Double.Parse(str, CultureInfo.InvariantCulture) * TwipsInPT;
      return;
    }
    if (str.EndsWith("tw"))
    {
      str = str.Substring(0, str.Length - 2).Trim();
      value = Double.Parse(str, CultureInfo.InvariantCulture);
      return;
    }
    value = Double.Parse(str, CultureInfo.InvariantCulture);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> struct from a 64-bit integer value.
  /// </summary>
  /// <param name="value">The value in twips.</param>
  public Twips(Int64 value)
  {
    this.value = (Double)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> struct from a 64-bit signed integer value.
  /// </summary>
  /// <param name="value">The value in twips.</param>
  public Twips(Double value)
  {
    this.value = value;
  }

  #endregion

  #region Conversion Methods

  /// <summary>
  /// Converts the twips value to millimeters.
  /// </summary>
  /// <returns>The measurement in millimeters as a double-precision floating-point number.</returns>
  public double ToMM() => value / TwipsInMM;

  /// <summary>
  /// Converts the twips value to centimeters.
  /// </summary>
  /// <returns>The measurement in centimeters as a double-precision floating-point number.</returns>
  public double ToCM() => value / TwipsInCM;

  /// <summary>
  /// Converts the twips value to inches.
  /// </summary>
  /// <returns>The measurement in inches as a double-precision floating-point number.</returns>
  public double ToInch() => value / TwipsInInch;

  /// <summary>
  /// Converts the twips value to points.
  /// </summary>
  /// <returns>The measurement in points as a double-precision floating-point number.</returns>
  /// <remarks>
  /// A point is defined as 1/72 of an inch.
  /// </remarks>
  public double ToPT() => value / TwipsInPT;

  /// <summary>
  /// Converts the twips value to twips.
  /// </summary>
  /// <returns>The measurement in twips as a double-precision floating-point number.</returns>
  /// <remarks>
  /// This method is provided for consistency with other conversion methods and returns the internal value as a double.
  /// </remarks>
  public double ToTwips() => value;


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
  public static ILengthMeasure FromTwips(double twips) => new Twips((Double)twips);

  /// <summary>
  /// Creates an instance of an <see cref="ILengthMeasure"/> that represents the specified value in points.
  /// </summary>
  public static ILengthMeasure FromPT(double points) => new Twips((Double)(points * TwipsInPT));

  /// <summary>
  /// Creates a new instance of an object that represents a length specified in millimeters.
  /// </summary>
  public static ILengthMeasure FromMM(double millimeters) => new Twips((Double)(millimeters * TwipsInMM));

  /// <summary>
  /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in
  /// centimeters.
  /// </summary>
  public static ILengthMeasure FromCM(double centimeters) => new Twips((Double)(centimeters * TwipsInCM));

  /// <summary>
  /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in inches.
  /// </summary>
  public static ILengthMeasure FromInch(double inches) => new Twips((Double)(inches * TwipsInInch));

  /// <summary>
  /// Converts a length value from the specified unit to a standardized length measure.
  /// </summary>
  /// <remarks>Supported units include Twips, Points, Millimeters, Centimeters, and Inches.</remarks>
  /// <param name="value">The numeric length value to convert, expressed in the unit specified by the unit parameter.</param>
  /// <param name="unit">The unit of measurement for the value parameter. Must be one of the supported length units.</param>
  /// <returns>An object that implements ILengthMeasure, representing the converted length value in a standardized format.</returns>
  /// <exception cref="ArgumentException">Thrown when the specified unit is not supported for conversion.</exception>
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
  /// Parses a string representation of a length measure and returns the corresponding ILengthMeasure instance.
  /// </summary>
  /// <remarks>If the input string does not conform to a valid length measure format, an exception may be
  /// thrown.</remarks>
  /// <param name="value">The string that represents the length measure to parse. The value must be in a format recognized by the parser.</param>
  /// <returns>An instance of ILengthMeasure that represents the parsed length measure.</returns>
  public static ILengthMeasure Parse(string value) => new Twips(value);

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
      result = new Twips(value);
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
  /// Implicitly converts a string to a <see cref="Twips"/> value.
  /// </summary>
  /// <param name="value">The string to convert.</param>
  /// <returns>A <see cref="Twips"/> value parsed from the string.</returns>
  public static implicit operator Twips(string value)
  {
    return new Twips(value);
  }

  /// <summary>
  /// Implicitly converts a <see cref="Twips"/> value to a string.
  /// </summary>
  /// <param name="value">The <see cref="Twips"/> value to convert.</param>
  /// <returns>A string representation of the twips value.</returns>
  public static implicit operator string(Twips value)
  {
    return value.value.ToString(CultureInfo.InvariantCulture);
  }
  
  /// <summary>
  /// Implicitly converts a Twips instance to a 32-bit signed integer (Int32).
  /// </summary>
  /// <remarks>This conversion allows for seamless integration of Twips values in contexts where an Int32 is
  /// expected. Ensure that the Twips value is within the range of Int32 to avoid overflow.</remarks>
  /// <param name="value">The Twips instance to convert.</param>
  public static implicit operator Int32(Twips value)
  {
    return (Int32)value.value;
  }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer to a <see cref="Twips"/> value.
  /// </summary>
  /// <param name="value">The 32-bit signed integer to convert.</param>
  /// <returns>A <see cref="Twips"/> value representing the integer.</returns>
  public static implicit operator Twips(Int32 value)
  {
    return new Twips(value);
  }

  /// <summary>
  /// Implicitly converts a Twips instance to a 64-bit signed integer (Int64).
  /// </summary>
  /// <remarks>This conversion allows for seamless integration of Twips values in contexts where an Int64 is
  /// expected. Ensure that the Twips value is within the range of Int64 to avoid overflow.</remarks>
  /// <param name="value">The Twips instance to convert.</param>
  public static implicit operator Int64(Twips value)
  {
    return (Int64)value.value;
  }

  /// <summary>
  /// Implicitly converts a 64-bit signed integer to a <see cref="Twips"/> value.
  /// </summary>
  /// <param name="value">The 64-bit signed integer to convert.</param>
  /// <returns>A <see cref="Twips"/> value representing the integer.</returns>
  public static implicit operator Twips(Int64 value)
  {
    return new Twips(value);
  }

  /// <summary>
  /// Implicitly converts a double-precision floating-point number to a Twips instance.
  /// </summary>
  /// <remarks>This conversion allows for seamless integration of double values into contexts where Twips are
  /// required, facilitating operations that involve measurements in twips.</remarks>
  /// <param name="value">The value to convert, representing a measurement in twips.</param>
  public static implicit operator Twips(Double value)
  {
    return new Twips(value);
  }

  #endregion

  #region IComparable and IEquatable Implementations

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
  public bool Equals(Twips other)
  {
    return value.Equals(other.value);
  }

  /// <summary>
  /// Determines whether the specified object is equal to the current Twips instance.
  /// </summary>
  /// <remarks>This method supports value comparison for Twips instances. It returns false if the provided
  /// object is not a Twips instance.</remarks>
  /// <param name="obj">The object to compare with the current instance. This parameter can be null.</param>
  /// <returns>true if the specified object is a Twips instance equal to the current instance; otherwise, false.</returns>
  public override bool Equals(object? obj)
  {
    if (obj is Twips otherTwips)
      return Equals(otherTwips);
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