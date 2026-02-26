namespace DocumentModel;

/// <summary>
/// Represents a measurement in twips (twentieth of a point).
/// A twip is 1/1440 of an inch, commonly used in word processing and document formatting.
/// Supports conversions to/from millimeters, centimeters, inches, and points.
/// </summary>
/// <remarks>
/// Twips provide a precise, integer-based unit for document measurements.
/// This supports implicit conversions to/from various integer types and string representations with unit suffixes.
/// </remarks>
[JsonConverter(typeof(TwipsJsonConverter))]
public partial class Twips: UniversalMeasure
{
  /// <summary>
  /// Defines the number of twips in one inch.
  /// </summary>
  protected override double UnitsPerInch => 1440.0;

  #region Constructors

  /// <summary>
  /// Default constructor. Creates an empty instance.
  /// </summary>
  public Twips()
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> from a string value.
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
    Init(str);
  }
  
  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> from an Int64 value.
  /// </summary>
  /// <param name="value">The value in twips.</param>
  public Twips(Int64 value)
  {
    Init(value);
  }
  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> from a UInt64 value.
  /// </summary>
  /// <param name="value">The value in twips.</param>
  public Twips(UInt64 value)
  {
    Init(value);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> from a Decimal value.
  /// </summary>
  /// <param name="value">The value in twips.</param>
  public Twips(Decimal value)
  {
    Init(value);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> from a Double value.
  /// </summary>
  /// <param name="value">The value in twips.</param>
  public Twips(Double value)
  {
    Init(value);
  }

  #endregion

  #region Static Factory Methods

  /// <summary>
  /// Creates an instance of an <see cref="Twips"/> that represents the specified value in twips.
  /// </summary>
  public static Twips FromTwips(double twips) => new Twips($"{twips}tw");
  /// <summary>
  /// Creates an instance of an <see cref="Twips"/> that represents the specified value in points.
  /// </summary>
  public static Twips FromPT(double points) => new Twips($"{points}pt");

  /// <summary>
  /// Creates a new instance of an object that represents a length specified in millimeters.
  /// </summary>
  public static Twips FromMM(double millimeters) => new Twips($"{millimeters}mm");

  /// <summary>
  /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in
  /// centimeters.
  /// </summary>
  public static Twips FromCM(double centimeters) => new Twips($"{centimeters}cm");

  /// <summary>
  /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in inches.
  /// </summary>
  public static Twips FromInch(double inches) => new Twips($"{inches}in");

  /// <summary>
  /// Converts a length value from the specified unit to a standardized length measure.
  /// </summary>
  /// <remarks>Supported units include Twips, Points, Millimeters, Centimeters, and Inches.</remarks>
  /// <param name="value">The numeric length value to convert, expressed in the unit specified by the unit parameter.</param>
  /// <param name="unit">The unit of measurement for the value parameter. Must be one of the supported length units.</param>
  /// <returns>An object that implements ILengthMeasure, representing the converted length value in a standardized format.</returns>
  /// <exception cref="ArgumentException">Thrown when the specified unit is not supported for conversion.</exception>
  public static Twips ConvertFrom(double value, LengthUnit unit) => unit switch
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
  public static Twips Parse(string value) => new Twips(value);

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
  public static bool TryParse(string value, out Twips? result)
  {
    try
    {
      result = new Twips(value);
      return true;
    } catch
    {
      result = null;
      return false;
    }
  }

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
    return value.ToString();
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
}