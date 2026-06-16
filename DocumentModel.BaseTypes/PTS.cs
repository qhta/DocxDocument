namespace DocumentModel;

/// <summary>
/// Represents a measurement in typographic points.
/// A point is defined as 1/72 of an inch, commonly used for typography adjustments.
/// Supports conversions to/from millimeters, centimeters, inches, and points.
/// </summary>
/// <remarks>
/// IPoints provide finer precision than inches for typographic measurements in desktop publishing and word processing.
/// This supports implicit conversions to/from various integer types and string representations with unit suffixes.
/// Note: 1 point = 1/72 inch.
/// </remarks>
[JsonConverter(typeof(PTSJsonConverter))]
public partial class PTS : UniversalMeasure
{
  /// <summary>
  /// Defines the number of points in one inch.
  /// </summary>
  protected override double UnitsPerInch => 72;

  #region Constructors

  /// <summary>
  /// Default constructor. Creates an empty instance.
  /// </summary>
  public PTS()
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="PTS"/> from a string value.
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
  public PTS(string str)
  {
    Init(str);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="PTS"/> from an Int64 value.
  /// </summary>
  /// <param name="value">The value in PTS.</param>
  public PTS(Int64 value)
  {
    Init(value);
  }
  /// <summary>
  /// Initializes a new instance of the <see cref="PTS"/> from a UInt64 value.
  /// </summary>
  /// <param name="value">The value in PTS.</param>
  public PTS(UInt64 value)
  {
    Init(value);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="PTS"/> from a 64-bit floating-point value.
  /// </summary>
  /// <param name="value">The value in half-points.</param>
  public PTS(Double value)
  {
    Init(value);
  }

  #endregion

  #region Static Factory Methods

  /// <summary>
  /// Creates an instance of an <see cref="PTS"/> that represents the specified value in twips.
  /// </summary>
  public static PTS FromTwips(double twips) => new PTS($"{twips}tw");

  /// <summary>
  /// Creates an instance of an <see cref="PTS"/> that represents the specified value in points.
  /// </summary>
  public static PTS FromPT(double points) => new PTS($"{points}pt");

  /// <summary>
  /// Creates a new instance of an object that represents a length specified in millimeters.
  /// </summary>
  public static PTS FromMM(double millimeters) => new PTS($"{millimeters}mm");

  /// <summary>
  /// Creates a new instance of an object that Iimplements the ILengthMeasure interface from a specified length in
  /// centimeters.
  /// </summary>
  public static PTS FromCM(double centimeters) => new PTS($"{centimeters}cm");

  /// <summary>
  /// Creates a new instance of an object that Iimplements the ILengthMeasure interface from a specified length in inches.
  /// </summary>
  public static PTS FromInch(double inches) => new PTS($"{inches}in");

  /// <summary>
  /// Parses a string representation of a length measure and returns the corresponding ILengthMeasure instance.
  /// </summary>
  /// <remarks>If the input string does not conform to a valid length measure format, an exception may be
  /// thrown.</remarks>
  /// <param name="value">The string that represents the length measure to parse. The value must be in a format recognized by the parser.</param>
  /// <returns>An instance of ILengthMeasure that represents the parsed length measure.</returns>
  public static PTS Parse(string value) => new PTS(value);

  /// <summary>
  /// Converts a length value from the specified unit to an equivalent length measure.
  /// </summary>
  /// <remarks>Use this method to create an ILengthMeasure instance from a raw numeric value and its associated
  /// unit. Ensure that the provided unit is valid to avoid conversion errors.</remarks>
  /// <param name="value">The numeric value representing the length to convert.</param>
  /// <param name="unit">The unit of the input length value, specified as a member of the LengthUnit enumeration.</param>
  /// <returns>An object that represents the converted length value as an ILengthMeasure.</returns>
  public static PTS ConvertFrom(double value, LengthUnit unit) => unit switch
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
  public static bool TryParse(string value, out PTS? result)
  {
    try
    {
      result = new PTS(value);
      return true;
    }
    catch
    {
      result = null!;
      return false;
    }
  }

  #endregion

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a string to a <see cref="PTS"/> value.
  /// </summary>
  /// <param name="value">The string to convert.</param>
  /// <returns>A <see cref="PTS"/> value parsed from the string.</returns>
  public static implicit operator PTS(string value)
  {
    return new PTS(value);
  }

  /// <summary>
  /// Implicitly converts a <see cref="PTS"/> value to a string.
  /// </summary>
  /// <param name="value">The <see cref="PTS"/> value to convert.</param>
  /// <returns>A string representation of the PTS value.</returns>
  public static implicit operator string(PTS value)
  {
    return value.ToString();
  }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer to a <see cref="PTS"/> value.
  /// </summary>
  /// <param name="value">The 32-bit signed integer to convert.</param>
  /// <returns>A <see cref="PTS"/> value representing the integer.</returns>
  public static implicit operator PTS(Int32 value)
  {
    return new PTS(value);
  }

  /// <summary>
  /// Implicitly converts a 64-bit signed integer to a <see cref="PTS"/> value.
  /// </summary>
  /// <param name="value">The 64-bit signed integer to convert.</param>
  /// <returns>A <see cref="PTS"/> value representing the integer.</returns>
  public static implicit operator PTS(Int64 value)
  {
    return new PTS(value);
  }

  /// <summary>
  /// Implicitly converts a double-precision floating-point number to a PTS instance.
  /// </summary>
  /// <remarks>This conversion allows for seamless integration of double values into contexts where PTS are
  /// required, facilitating operations that involve measurements in PTS.</remarks>
  /// <param name="value">The value to convert, representing a measurement in PTS.</param>
  public static implicit operator PTS(Double value)
  {
    return new PTS(value);
  }

  #endregion
}
