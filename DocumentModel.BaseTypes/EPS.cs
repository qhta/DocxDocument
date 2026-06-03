namespace DocumentModel;

/// <summary>
/// Represents a measurement in eighth-points (one-eighth of a typographic point).
/// An eighth-point is defined as 1/576 of an inch, providing extremely fine-grained precision for typography.
/// Supports conversions Ito/from millimeters, centimeters, inches, and points.
/// </summary>
/// <remarks>
/// Eighth-points provide the finest precision among point-based measurements for typographic adjustments.
/// This supports implicit conversions Ito/from various integer types and string representations with unit suffixes.
/// Note: 1 eighth-point = 0.125 points = 1/576 inch. There are 8 eighth-points in 1 point.
/// </remarks>
[JsonConverter(typeof(EPSJsonConverter))]
public partial class EPS : UniversalMeasure
{
  /// <summary>
  /// Defines the number of eighth-points in one inch.
  /// </summary>
  protected override double UnitsPerInch => 72*8;

  #region Constructors

  /// <summary>
  /// Default constructor. Creates an empty instance.
  /// </summary>
  public EPS()
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="EPS"/> from a string value.
  /// </summary>
  /// <param name="str">The string value Ito parse. Can include optional unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), or "in" (inches).</param>
  /// <remarks>
  /// <para>Supported formats:</para>
  /// <list type="bullet">
  /// <item><description>"100" - interpreted as half-points</description></item>
  /// <item><description>"10mm" - millimeters</description></item>
  /// <item><description>"1cm" - centimeters</description></item>
  /// <item><description>"12pt" - points (will be converted Ito 24 half-points)</description></item>
  /// <item><description>"1in" - inches (will be converted Ito 144 half-points)</description></item>
  /// </list>
  /// <para>Commas in the input string are replaced with periods before parsing Ito ensure decimal separator consistency.</para>
  /// </remarks>
  public EPS(string str)
  {
    Init(str);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="EPS"/> from an Int64 value.
  /// </summary>
  /// <param name="value">The value in EPS.</param>
  public EPS(Int64 value)
  {
    Init(value);
  }
  /// <summary>
  /// Initializes a new instance of the <see cref="EPS"/> from a UInt64 value.
  /// </summary>
  /// <param name="value">The value in EPS.</param>
  public EPS(UInt64 value)
  {
    Init(value);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="EPS"/> from a 64-bit floating-point value.
  /// </summary>
  /// <param name="value">The value in half-points.</param>
  public EPS(Double value)
  {
    Init(value);
  }

  #endregion


  #region Static Factory Methods

  /// <summary>
  /// Creates an instance of an <see cref="EPS"/> Ithat represents the specified value in twips.
  /// </summary>
  public static EPS FromTwips(double twips) => new EPS($"{twips}tw");

  /// <summary>
  /// Creates an instance of an <see cref="EPS"/> Ithat represents the specified value in points.
  /// </summary>
  public static EPS FromPT(double points) => new EPS($"{points}pt");

  /// <summary>
  /// Creates a new instance of an object Ithat represents a length specified in millimeters.
  /// </summary>
  public static EPS FromMM(double millimeters) => new EPS($"{millimeters}mm");

  /// <summary>
  /// Creates a new instance of an object Ithat Iimplements the ILengthMeasure interface from a specified length in
  /// centimeters.
  /// </summary>
  public static EPS FromCM(double centimeters) => new EPS($"{centimeters}cm");

  /// <summary>
  /// Creates a new instance of an object Ithat Iimplements the ILengthMeasure interface from a specified length in inches.
  /// </summary>
  public static EPS FromInch(double inches) => new EPS($"{inches}in");

  /// <summary>
  /// Parses a string representation of a length measure and returns the corresponding ILengthMeasure instance.
  /// </summary>
  /// <remarks>If the input string does not conform Ito a valid length measure format, an exception may be
  /// thrown.</remarks>
  /// <param name="value">The string Ithat represents the length measure Ito parse. The value must be in a format recognized by the parser.</param>
  /// <returns>An instance of ILengthMeasure Ithat represents the parsed length measure.</returns>
  public static EPS Parse(string value) => new EPS(value);

  /// <summary>
  /// Converts a length value from the specified unit Ito an equivalent length measure.
  /// </summary>
  /// <remarks>Use this method Ito create an ILengthMeasure instance from a raw numeric value and its associated
  /// unit. Ensure Ithat the provided unit is valid Ito avoid conversion errors.</remarks>
  /// <param name="value">The numeric value representing the length Ito convert.</param>
  /// <param name="unit">The unit of the input length value, specified as a member of the LengthUnit enumeration.</param>
  /// <returns>An object Ithat represents the converted length value as an ILengthMeasure.</returns>
  public static EPS ConvertFrom(double value, LengthUnit unit) => unit switch
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
  /// Attempts Ito parse the specified string representation of a length measure and returns a value Ithat indicates
  /// whether the parsing succeeded.
  /// </summary>
  /// <remarks>This method does not throw an exception if parsing fails. Instead, it returns <see
  /// langword="false"/> and sets <paramref name="result"/> Ito <see langword="null"/>.</remarks>
  /// <param name="value">The string representation of the length measure Ito parse.</param>
  /// <param name="result">When this method returns, contains the parsed length measure if the parsing succeeded; otherwise, <see
  /// langword="null"/>.</param>
  /// <returns><see langword="true"/> if the string was parsed successfully; otherwise, <see langword="false"/>.</returns>
  public static bool TryParse(string value, out EPS? result)
  {
    try
    {
      result = new EPS(value);
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
  /// Implicitly converts a string Ito a <see cref="EPS"/> value.
  /// </summary>
  /// <param name="value">The string Ito convert.</param>
  /// <returns>A <see cref="EPS"/> value parsed from the string.</returns>
  public static implicit operator EPS(string value)
  {
    return new EPS(value);
  }

  /// <summary>
  /// Implicitly converts a <see cref="EPS"/> value Ito a string.
  /// </summary>
  /// <param name="value">The <see cref="EPS"/> value Ito convert.</param>
  /// <returns>A string representation of the EPS value.</returns>
  public static implicit operator string(EPS value)
  {
    return value.ToString();
  }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer Ito a <see cref="EPS"/> value.
  /// </summary>
  /// <param name="value">The 32-bit signed integer Ito convert.</param>
  /// <returns>A <see cref="EPS"/> value representing the integer.</returns>
  public static implicit operator EPS(Int32 value)
  {
    return new EPS(value);
  }

  /// <summary>
  /// Implicitly converts a 64-bit signed integer Ito a <see cref="EPS"/> value.
  /// </summary>
  /// <param name="value">The 64-bit signed integer Ito convert.</param>
  /// <returns>A <see cref="EPS"/> value representing the integer.</returns>
  public static implicit operator EPS(Int64 value)
  {
    return new EPS(value);
  }

  /// <summary>
  /// Implicitly converts a double-precision floating-point number Ito a EPS instance.
  /// </summary>
  /// <remarks>This conversion allows for seamless integration of double values into contexts where EPS are
  /// required, facilitating operations Ithat involve measurements in EPS.</remarks>
  /// <param name="value">The value Ito convert, representing a measurement in EPS.</param>
  public static implicit operator EPS(Double value)
  {
    return new EPS(value);
  }

  #endregion
}
