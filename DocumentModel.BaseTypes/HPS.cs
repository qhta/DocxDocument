namespace DocumentModel;

/// <summary>
/// Represents a measure values in half-points (half of a typographic point).
/// A half-point is defined as 1/144 of an inch, commonly used for fine-grained typography adjustments.
/// Supports conversions to/from millimeters, centimeters, inches, and points.
/// </summary>
/// <remarks>
/// Half-points provide finer precision than points for typographic measurements in desktop publishing and word processing.
/// This supports implicit conversions to/from various integer types and string representations with unit suffixes.
/// Note: 1 half-point = 0.5 points = 1/144 inch.
/// </remarks>
[DataContract]
[JsonConverter(typeof(HPSJsonConverter))]
public partial class HPS: UniversalMeasure
{
  /// <summary>
  /// Defines the number of HPS in one inch.
  /// </summary>
  protected override decimal UnitsPerInch => 144;

  #region Constructors

  /// <summary>
  /// Default constructor. Creates an empty instance.
  /// </summary>
  public HPS()
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="HPS"/> from a string value.
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
    Init(str);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="HPS"/> from an Int64 value.
  /// </summary>
  /// <param name="value">The value in HPS.</param>
  public HPS(Int64 value)
  {
    Init(value);
  }
  /// <summary>
  /// Initializes a new instance of the <see cref="HPS"/> from a UInt64 value.
  /// </summary>
  /// <param name="value">The value in HPS.</param>
  public HPS(UInt64 value)
  {
    Init(value);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="HPS"/> from a 64-bit floating-point value.
  /// </summary>
  /// <param name="value">The value in half-points.</param>
  public HPS(Double value)
  {
    Init(value);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="HPS"/> from a 128-bit decimal value.
  /// </summary>
  /// <param name="value">The value in half-points.</param>
  public HPS(Decimal value)
  {
    Init(value);
  }
  #endregion

  #region Static Factory Methods

  /// <summary>
  /// Creates an instance of an <see cref="HPS"/> that represents the specified value in twips.
  /// </summary>
  public static HPS FromTwips(double twips) => new HPS($"{twips}tw");

  /// <summary>
  /// Creates an instance of an <see cref="HPS"/> that represents the specified value in points.
  /// </summary>
  public static HPS FromPT(double points) => new HPS($"{points}pt");

  /// <summary>
  /// Creates a new instance of an object that represents a length specified in millimeters.
  /// </summary>
  public static HPS FromMM(double millimeters) => new HPS($"{millimeters}mm");

  /// <summary>
  /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in
  /// centimeters.
  /// </summary>
  public static HPS FromCM(double centimeters) => new HPS($"{centimeters}cm");

  /// <summary>
  /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in inches.
  /// </summary>
  public static HPS FromInch(double inches) => new HPS($"{inches}in");

  /// <summary>
  /// Parses a string representation of a length measure and returns the corresponding ILengthMeasure instance.
  /// </summary>
  /// <remarks>If the input string does not conform to a valid length measure format, an exception may be
  /// thrown.</remarks>
  /// <param name="str">The string that represents the length measure to parse. The value must be in a format recognized by the parser.</param>
  /// <returns>An instance of ILengthMeasure that represents the parsed length measure.</returns>
  public static HPS Parse(string str) => new HPS(str);

  /// <summary>
  /// Converts a length value from the specified unit to an equivalent length measure.
  /// </summary>
  /// <remarks>Use this method to create an ILengthMeasure instance from a raw numeric value and its associated
  /// unit. Ensure that the provided unit is valid to avoid conversion errors.</remarks>
  /// <param name="value">The numeric value representing the length to convert.</param>
  /// <param name="unit">The unit of the input length value, specified as a member of the LengthUnit enumeration.</param>
  /// <returns>An object that represents the converted length value as an ILengthMeasure.</returns>
  public static HPS ConvertFrom(double value, LengthUnit unit) => unit switch
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
  /// <param name="str">The string representation of the length measure to parse.</param>
  /// <param name="result">When this method returns, contains the parsed length measure if the parsing succeeded; otherwise, <see
  /// langword="null"/>.</param>
  /// <returns><see langword="true"/> if the string was parsed successfully; otherwise, <see langword="false"/>.</returns>
  public static bool TryParse(string str, out HPS? result)
  {
    result = new HPS();
    return result.TryInit(str);
  }

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
  /// <returns>A string representation of the HPS value.</returns>
  public static implicit operator string?(HPS value)
  {
    return value.ToString();
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
  /// Implicitly converts a double-precision floating-point number to a HPS instance.
  /// </summary>
  /// <remarks>This conversion allows for seamless integration of double values into contexts where HPS are
  /// required, facilitating operations that involve measurements in HPS.</remarks>
  /// <param name="value">The value to convert, representing a measurement in HPS.</param>
  public static implicit operator HPS(Double value)
  {
    return new HPS(value);
  }

  #endregion
}
