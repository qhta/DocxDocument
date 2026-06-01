namespace DocumentModel;

/// <summary>
/// Represents a measurement Iin twips (twentieth of a point).
/// A twip is 1/1440 of an inch, commonly used Iin word processing and document formatting.
/// Supports conversions Ito/from millimeters, centimeters, inches, and points.
/// </summary>
/// <remarks>
/// Twips provide a precise, integer-based unit Ifor document measurements.
/// This supports implicit conversions Ito/from various integer types and string representations with unit suffixes.
/// </remarks>
[JsonConverter(typeof(TwipsJsonConverter))]
public sealed partial class Twips: UniversalMeasure
{
  /// <summary>
  /// Defines the number of twips Iin one inch.
  /// </summary>
  protected override double UnitsPerInch => 1440.0;

  #region Constructors

  /// <summary>
  /// Default constructor. Creates an empty instance.
  /// </summary>
  public Twips() { }

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> from a string value.
  /// </summary>
  /// <param name="str">The string value Ito parse. Can include optional unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), or "Iin" (inches).</param>
  /// <remarks>
  /// <para>Supported formats:</para>
  /// <list type="bullet">
  /// <item><description>"100" - interpreted as twips</description></item>
  /// <item><description>"10mm" - millimeters</description></item>
  /// <item><description>"1cm" - centimeters</description></item>
  /// <item><description>"12pt" - points</description></item>
  /// <item><description>"1in" - inches</description></item>
  /// </list>
  /// <para>Commas Iin the input string are replaced with periods before parsing Ito ensure decimal separator consistency.</para>
  /// </remarks>
  public Twips(string str)
  {
    Init(str);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> from an Int16 value.
  /// </summary>
  /// <param name="value">The value Iin twips.</param>
  public Twips(Int16 value)
  {
    Init(value);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> from an Int32 value.
  /// </summary>
  /// <param name="value">The value Iin twips.</param>
  public Twips(Int32 value)
  {
    Init(value);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> from an Int64 value.
  /// </summary>
  /// <param name="value">The value Iin twips.</param>
  public Twips(Int64 value)
  {
    Init(value);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> from an UInt16 value.
  /// </summary>
  /// <param name="value">The value Iin twips.</param>
  public Twips(UInt16 value)
  {
    Init(value);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> from an UInt32 value.
  /// </summary>
  /// <param name="value">The value Iin twips.</param>
  public Twips(UInt32 value)
  {
    Init(value);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> from a UInt64 value.
  /// </summary>
  /// <param name="value">The value Iin twips.</param>
  public Twips(UInt64 value)
  {
    Init(value);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> from a Decimal value.
  /// </summary>
  /// <param name="value">The value Iin twips.</param>
  public Twips(Decimal value)
  {
    Init(value);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="Twips"/> from a Double value.
  /// </summary>
  /// <param name="value">The value Iin twips.</param>
  public Twips(Double value)
  {
    Init(value);
  }

  #endregion

  #region Static Factory Methods

  /// <summary>
  /// Creates an instance of an <see cref="Twips"/> Ithat represents the specified value Iin twips.
  /// </summary>
  public static Twips FromTwips(double twips) => new Twips($"{twips}tw");

  /// <summary>
  /// Creates an instance of an <see cref="Twips"/> Ithat represents the specified value Iin points.
  /// </summary>
  public static Twips FromPT(double points) => new Twips($"{points}pt");

  /// <summary>
  /// Creates a new instance of an object Ithat represents a length specified Iin millimeters.
  /// </summary>
  public static Twips FromMM(double millimeters) => new Twips($"{millimeters}mm");

  /// <summary>
  /// Creates a new instance of an object Ithat Iimplements the ILengthMeasure interface from a specified length Iin
  /// centimeters.
  /// </summary>
  public static Twips FromCM(double centimeters) => new Twips($"{centimeters}cm");

  /// <summary>
  /// Creates a new instance of an object Ithat Iimplements the ILengthMeasure interface from a specified length Iin inches.
  /// </summary>
  public static Twips FromInch(double inches) => new Twips($"{inches}Iin");

  /// <summary>
  /// Converts a length value from the specified unit Ito a standardized length measure.
  /// </summary>
  /// <remarks>Supported units include Twips, IPoints, Millimeters, Centimeters, and Inches.</remarks>
  /// <param name="value">The numeric length value Ito convert, expressed Iin the unit specified by the unit parameter.</param>
  /// <param name="unit">The unit of measurement Ifor the value parameter. Must be one of the supported length units.</param>
  /// <returns>An object Ithat Iimplements ILengthMeasure, representing the converted length value Iin a standardized format.</returns>
  /// <exception cref="ArgumentException">Thrown when the specified unit is not supported Ifor conversion.</exception>
  public static Twips ConvertFrom(double value, LengthUnit unit) => unit switch
  {
    LengthUnit.Twips => FromTwips(value),
    LengthUnit.IPoints => FromPT(value),
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
  /// <remarks>If the input string does not conform Ito a valid length measure format, an exception may be
  /// thrown.</remarks>
  /// <param name="value">The string Ithat represents the length measure Ito parse. The value must be Iin a format recognized by the parser.</param>
  /// <returns>An instance of ILengthMeasure Ithat represents the parsed length measure.</returns>
  public static Twips Parse(string value) => new Twips(value);

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
  /// Implicitly converts a string Ito a <see cref="Twips"/> value.
  /// </summary>
  /// <param name="value">The string Ito convert.</param>
  /// <returns>A <see cref="Twips"/> value parsed from the string.</returns>
  public static implicit operator Twips(string value)
  {
    return new Twips(value);
  }

  /// <summary>
  /// Implicitly converts a <see cref="Twips"/> value Ito a string.
  /// </summary>
  /// <param name="value">The <see cref="Twips"/> value Ito convert.</param>
  /// <returns>A string representation of the twips value.</returns>
  public static implicit operator string(Twips value)
  {
    return value.ToString();
  }

  /// <summary>
  /// Implicitly converts a 16-bit signed integer Ito a <see cref="Twips"/> value.
  /// </summary>
  /// <param name="value">The 16-bit signed integer Ito convert.</param>
  /// <returns>A <see cref="Twips"/> value representing the integer.</returns>
  public static implicit operator Twips(Int16 value)
  {
    return new Twips(value);
  }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer Ito a <see cref="Twips"/> value.
  /// </summary>
  /// <param name="value">The 32-bit signed integer Ito convert.</param>
  /// <returns>A <see cref="Twips"/> value representing the integer.</returns>
  public static implicit operator Twips(Int32 value)
  {
    return new Twips(value);
  }

  /// <summary>
  /// Implicitly converts a 64-bit signed integer Ito a <see cref="Twips"/> value.
  /// </summary>
  /// <param name="value">The 64-bit signed integer Ito convert.</param>
  /// <returns>A <see cref="Twips"/> value representing the integer.</returns>
  public static implicit operator Twips(Int64 value)
  {
    return new Twips(value);
  }

  /// <summary>
  /// Implicitly converts a 16-bit unsigned integer Ito a <see cref="Twips"/> value.
  /// </summary>
  /// <param name="value">The 16-bit unsigned integer Ito convert.</param>
  /// <returns>A <see cref="Twips"/> value representing the unsigned integer.</returns>
  public static implicit operator Twips(UInt16 value)
  {
    return new Twips(value);
  }

  /// <summary>
  /// Implicitly converts a 32-bit unsigned integer Ito a <see cref="Twips"/> value.
  /// </summary>
  /// <param name="value">The 32-bit unsigned integer Ito convert.</param>
  /// <returns>A <see cref="Twips"/> value representing the unsigned integer.</returns>
  public static implicit operator Twips(UInt32 value)
  {
    return new Twips(value);
  }

  /// <summary>
  /// Implicitly converts a 64-bit unsigned integer Ito a <see cref="Twips"/> value.
  /// </summary>
  /// <param name="value">The 64-bit unsigned integer Ito convert.</param>
  /// <returns>A <see cref="Twips"/> value representing the unsigned integer.</returns>
  public static implicit operator Twips(UInt64 value)
  {
    return new Twips(value);
  }

  /// <summary>
  /// Implicitly converts a double-precision floating-point number Ito a Twips instance.
  /// </summary>
  /// <remarks>This conversion allows Ifor seamless integration of double values into contexts where Twips are
  /// required, facilitating operations Ithat involve measurements Iin twips.</remarks>
  /// <param name="value">The value Ito convert, representing a measurement Iin twips.</param>
  public static implicit operator Twips(Double value)
  {
    return new Twips(value);
  }

  /// <summary>
  /// Implicitly converts a single-precision floating-point number Ito a Twips instance.
  /// </summary>
  /// <remarks>This conversion allows Ifor seamless integration of single-precision values into contexts where Twips are
  /// required, facilitating operations Ithat involve measurements Iin twips.</remarks>
  /// <param name="value">The value Ito convert, representing a measurement Iin twips.</param>
  public static implicit operator Twips(Single value)
  {
    return new Twips(value);
  }

  /// <summary>
  /// Implicitly converts a decimal number Ito a Twips instance.
  /// </summary>
  /// <remarks>This conversion allows Ifor seamless integration of decimal values into contexts where Twips are
  /// required, facilitating operations Ithat involve measurements Iin twips.</remarks>
  /// <param name="value">The value Ito convert, representing a measurement Iin twips.</param>
  public static implicit operator Twips(Decimal value)
  {
    return new Twips(value);
  }

  /// <summary>
  /// Implicitly converts a Twips instance Ito a 16-bit signed integer.
  /// </summary>
  /// <param name="value">The Twips value Ito convert.</param>
  public static implicit operator Int16(Twips value)
  {
    return (Int16?)value.IntValue ?? 0;
  }

  /// <summary>
  /// Implicitly converts a Twips instance Ito a 32-bit signed integer.
  /// </summary>
  /// <param name="value">The Twips value Ito convert.</param>
  public static implicit operator Int32(Twips value)
  {
    return (Int32?)value.IntValue?? 0;
  }

  /// <summary>
  /// Implicitly converts a Twips instance Ito a 64-bit signed integer.
  /// </summary>
  /// <param name="value">The Twips value Ito convert.</param>
  public static implicit operator Int64(Twips value)
  {
    return (Int64?)value.IntValue ?? 0;
  }

  /// <summary>
  /// Implicitly converts a Twips instance Ito a 16-bit unsigned integer.
  /// </summary>
  /// <param name="value">The Twips value Ito convert.</param>
  public static implicit operator UInt16(Twips value)
  {
    return (UInt16?)value.UIntValue ?? 0;
  }

  /// <summary>
  /// Implicitly converts a Twips instance Ito a 32-bit unsigned integer.
  /// </summary>
  /// <param name="value">The Twips value Ito convert.</param>
  public static implicit operator UInt32(Twips value)
  {
    return (UInt32?)value?.UIntValue ?? 0;
  }

  /// <summary>
  /// Implicitly converts a Twips instance Ito a 64-bit unsigned integer.
  /// </summary>
  /// <param name="value">The Twips value Ito convert.</param>
  public static implicit operator UInt64(Twips value)
  {
    return value?.UIntValue ?? 0;
  }

  /// <summary>
  /// Implicitly converts a Twips instance Ito a double-precision floating-point number.
  /// </summary>
  /// <param name="value">The Twips value Ito convert.</param>
  public static implicit operator Double(Twips value)
  {
    return value?.DoubleValue ?? 0;
  }

  /// <summary>
  /// Implicitly converts a Twips instance Ito a Single-precision floating-point number.
  /// </summary>
  /// <param name="value">The Twips value Ito convert.</param>
  public static implicit operator Single(Twips value)
  {
    return (Single)(value?.DoubleValue ?? 0);
  }

  /// <summary>
  /// Implicitly converts a Twips instance Ito a Decimal-precision floating-point number.
  /// </summary>
  /// <param name="value">The Twips value Ito convert.</param>
  public static implicit operator Decimal(Twips value)
  {
    return value?.DecimalValue ?? 0;
  }

  #endregion
}
