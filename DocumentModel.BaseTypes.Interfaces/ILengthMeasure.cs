using System.Globalization;

namespace DocumentModel.BaseTypes.Interfaces;

/// <summary>
/// Represents a length measurement that can be converted to various units (twips, points, millimeters, centimeters, inches).
/// </summary>
public interface ILengthMeasure //: IComparable<ILength>
{
  /// <summary>
  /// Raw value. The unit of this value is implementation-specific,
  /// but it is expected to be in a consistent base unit (e.g., twips) for internal calculations and conversions.
  /// </summary>
  public Int64 Value { get; }

  #region Conversion methods
  /// <summary>
  /// Value of the length in twips (1/20 of a point). This is the base unit for internal calculations.
  /// </summary>
  public double ToTwips();

  /// <summary>
  /// Value of the length in points (1/72 of an inch).
  /// </summary>
  public double ToPT();

  /// <summary>
  /// Converts the current measurement to millimeters.
  /// </summary>
  public double ToMM();

  /// <summary>
  /// Converts the current measurement to centimeters.
  /// </summary>
  public double ToCM();

  /// <summary>
  /// Converts the current measurement to inches.
  /// </summary>  
  public double ToInch();

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

  #region Static factory methods

  /// <summary>
  /// Creates an instance of an <see cref="ILengthMeasure"/> that represents the specified value in twips.
  /// </summary>
  public static abstract ILengthMeasure FromTwips(double twips);

  /// <summary>
  /// Creates an instance of an <see cref="ILengthMeasure"/> that represents the specified value in points.
  /// </summary>
  public static abstract ILengthMeasure FromPT(double points);

  /// <summary>
  /// Creates a new instance of an object that represents a length specified in millimeters.
  /// </summary>
  public static abstract ILengthMeasure FromMM(double millimeters);

  /// <summary>
  /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in
  /// centimeters.
  /// </summary>
  public static abstract ILengthMeasure FromCM(double centimeters);

  /// <summary>
  /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in inches.
  /// </summary>
  public static abstract ILengthMeasure FromInch(double inches);

  /// <summary>
  /// Converts a length value from the specified unit to an equivalent length measure.
  /// </summary>
  /// <remarks>Use this method to create an ILengthMeasure instance from a raw numeric value and its associated
  /// unit. Ensure that the provided unit is valid to avoid conversion errors.</remarks>
  /// <param name="value">The numeric value representing the length to convert.</param>
  /// <param name="unit">The unit of the input length value, specified as a member of the LengthUnit enumeration.</param>
  /// <returns>An object that represents the converted length value as an ILengthMeasure.</returns>
  public static abstract ILengthMeasure ConvertFrom(double value, LengthUnit unit);
  
  #endregion

  #region Parsing methods

  /// <summary>
  /// Parses a string representation of a length measure and returns the corresponding ILengthMeasure instance.
  /// </summary>
  /// <remarks>Use this method to convert user input or configuration values into a strongly typed length
  /// measure. The accepted string formats depend on the specific implementation of ILengthMeasure. If the input string
  /// is not in a valid format, an exception may be thrown.</remarks>
  /// <param name="value">The string that contains the length measure to parse. The format must be recognized by the implementation.</param>
  /// <returns>An ILengthMeasure instance that represents the parsed length measure.</returns>
  public static abstract ILengthMeasure Parse(string value);

  /// <summary>
  /// Attempts to convert the specified string representation of a length measure to its equivalent object, returning a
  /// value that indicates whether the conversion succeeded.  
  /// </summary>
  /// <remarks>Use this method to safely parse user input or external data into a length measure without
  /// throwing an exception for invalid formats.</remarks>
  /// <param name="value">The string representation of the length measure to parse. This parameter cannot be null or empty.</param>
  /// <param name="result">When this method returns, contains the parsed length measure if the conversion succeeded; otherwise, contains the
  /// default value for the type.</param>
  /// <returns>true if the value was converted successfully; otherwise, false.</returns>
  public static abstract bool TryParse(string value, out ILengthMeasure? result);

  #endregion

  #region ToString conversions

  /// <summary>
  /// Converts the current length measure to its string representation. Raw number formats are expected in InvariantCulture.
  /// </summary>
  public string ToString() => Value.ToString(CultureInfo.InvariantCulture);

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
}