// ReSharper disable SpecifyACultureInStringConversionExplicitly

using DocumentModel.BaseTypes.Interfaces;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableWidthType class. Its Value can be absolute (in TableWidth) or relative (in fiftieth of percent), or "auto" or "nil".
/// The type of the Value is determined with the Type property.
/// This class is used in multiple measures according to table horizontal dimension.
/// </summary>
[JsonConverter(typeof(TableWidthJsonConverter))]
public sealed partial class TableWidth : UniversalMeasure, IComparable<TableWidth>, IEquatable<TableWidth>
{
  /// <summary>
  /// Defines the number of TableWidth in one inch.
  /// </summary>
  protected override double UnitsPerInch => 1440.0;

  /// <summary>
  /// Represents the type of the TableWidth value, which can be absolute (in TableWidth), relative (in fiftieth of percent),
  /// or special values like "auto" or "nil".
  /// </summary>
  public TableWidthUnit Type => _type;

  private TableWidthUnit _type;

  #region Constructors

  /// <summary>
  /// Default constructor. Creates an empty instance.
  /// </summary>
  public TableWidth()
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="TableWidth"/> from a string value.
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
  /// <item><description>"50%" - percentage (will be converted to 2500, representing 50% of the table width)</description></item>
  /// <item><description>"auto" - automatic width</description></item>
  /// <item><description>"nil" - no width</description></item>
  /// </list>
  /// <para>Commas in the input string are replaced with periods before parsing to ensure decimal separator consistency.</para>
  /// </remarks>
  public TableWidth(string str)
  {
    Init(str);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="TableWidth"/> from an Int64 value.
  /// </summary>
  /// <param name="value">The value in TableWidth.</param>
  public TableWidth(Int64 value)
  {
    Init(value);
    _type = TableWidthUnit.Absolute;
  }
  /// <summary>
  /// Initializes a new instance of the <see cref="TableWidth"/> from a UInt64 value.
  /// </summary>
  /// <param name="value">The value in TableWidth.</param>
  public TableWidth(UInt64 value)
  {
    Init(value);
    _type = TableWidthUnit.Absolute;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="TableWidth"/> from a Decimal value.
  /// </summary>
  /// <param name="value">The value in TableWidth.</param>
  public TableWidth(Decimal value)
  {
    Init(value);
    _type = TableWidthUnit.Absolute;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="TableWidth"/> from a Double value.
  /// </summary>
  /// <param name="value">The value in TableWidth.</param>
  public TableWidth(Double value)
  {
    Init(value);
    _type = TableWidthUnit.Absolute;
  }
  #endregion

  #region string conversion

  /// <summary>
  /// Initializes the table width unit based on the specified string representation.
  /// </summary>
  /// <remarks>If the input string represents a percentage, it is converted to fiftieths of a percent. The
  /// method sets the Type property to indicate the unit of measurement and adjusts the internal value
  /// accordingly.</remarks>
  /// <param name="str">The string that specifies the table width. Supported values include "nil", "auto", a percentage (e.g., "50%"), or
  /// an absolute value.</param>
  protected override void Init(string str)
  {
    if (str == "nil")
    {
      _type = TableWidthUnit.Nil;
      _value = 0;
    }
    else if (str == "auto")
    {
      _type = TableWidthUnit.Auto;
      _value = 0;
    }
    else if (str.EndsWith("%"))
    {
      _type = TableWidthUnit.Percent;
      _value = double.Parse(str.TrimEnd('%')) * 50; // Convert percentage to fiftieths of percent
    }
    else
    {
      base.Init(str); // Parse as absolute value in TableWidth
      _type = TableWidthUnit.Absolute;
    }
  }

  /// <summary>
  /// Returns a string that represents the current table width unit in a human-readable format.
  /// </summary>
  /// <remarks>Use this method to obtain a textual representation of the table width unit for display,
  /// debugging, or serialization purposes. The output format depends on the value of the Type property.</remarks>
  /// <returns>A string that indicates the table width unit: "auto" for automatic width, "nil" for no width, or a percentage
  /// value based on the DecimalValue property for percentage widths. If the type does not match a predefined value, the
  /// base implementation is used.</returns>
  public override string ToString()
  {
    if (Type == TableWidthUnit.Auto)
      return "auto";
    if (Type == TableWidthUnit.Nil)
      return "nil";
    if (Type == TableWidthUnit.Percent)
      return (DecimalValue / 50).ToString(CultureInfo.InvariantCulture)+"%";
    return base.ToString();
  }


  /// <summary>
  /// Converts the current length measure to its string representation using the specified format provider.
  /// This allows for culture-specific formatting of the output string, such as using different decimal separators
  /// based on the culture settings provided by the formatProvider.
  /// If the formatProvider is null, the method should use invariant culture's formatting conventions.
  /// </summary>
  /// <param name="formatProvider">An object that supplies culture-specific formatting information. If null, invariant culture's formatting conventions are used.</param>
  /// <returns>A string representation of the current length measure, formatted according to the specified format provider.</returns>
  public override string ToString(IFormatProvider? formatProvider)
  {
    if (Type == TableWidthUnit.Auto)
      return "auto";
    if (Type == TableWidthUnit.Nil)
      return "nil";
    if (Type == TableWidthUnit.Percent)
      return (DecimalValue / 50).ToString(formatProvider) + "%";
    return base.ToString();
  }

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
  public override string ToString(string? format, IFormatProvider? formatProvider)
  {
    if (Type == TableWidthUnit.Auto)
      return "auto";
    if (Type == TableWidthUnit.Nil)
      return "nil";
    if (Type == TableWidthUnit.Percent)
      return (DecimalValue / 50).ToString(format, formatProvider) + "%";
    return base.ToString();
  }

  /// <summary>
  /// Converts the current instance to its string representation using the specified format string.
  /// </summary>
  /// <remarks>If the format string is not recognized or is invalid, a FormatException may be thrown. Supported
  /// format strings may include both standard and custom formats, depending on the implementation.</remarks>
  /// <param name="format">A format string that defines how the value should be represented.
  /// If null, a default format is used.</param>
  /// <returns>A string representation of the current instance, formatted according to the specified format string.</returns>
  public override string ToString(string? format)
  {
    if (Type == TableWidthUnit.Auto)
      return "auto";
    if (Type == TableWidthUnit.Nil)
      return "nil";
    if (Type == TableWidthUnit.Percent)
      return (DecimalValue / 50).ToString(format, CultureInfo.InvariantCulture) + "%";
    return base.ToString();
  }

  #endregion

  #region Static Factory Methods

  /// <summary>
  /// Creates an instance of an <see cref="TableWidth"/> that represents the specified value in TableWidth.
  /// </summary>
  public static TableWidth FromTableWidth(double TableWidth) => new TableWidth($"{TableWidth}tw");
  /// <summary>
  /// Creates an instance of an <see cref="TableWidth"/> that represents the specified value in points.
  /// </summary>
  public static TableWidth FromPT(double points) => new TableWidth($"{points}pt");

  /// <summary>
  /// Creates a new instance of an object that represents a length specified in millimeters.
  /// </summary>
  public static TableWidth FromMM(double millimeters) => new TableWidth($"{millimeters}mm");

  /// <summary>
  /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in
  /// centimeters.
  /// </summary>
  public static TableWidth FromCM(double centimeters) => new TableWidth($"{centimeters}cm");

  /// <summary>
  /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in inches.
  /// </summary>
  public static TableWidth FromInch(double inches) => new TableWidth($"{inches}in");

  /// <summary>
  /// Converts a length value from the specified unit to a standardized length measure.
  /// </summary>
  /// <remarks>Supported units include TableWidth, Points, Millimeters, Centimeters, and Inches.</remarks>
  /// <param name="value">The numeric length value to convert, expressed in the unit specified by the unit parameter.</param>
  /// <param name="unit">The unit of measurement for the value parameter. Must be one of the supported length units.</param>
  /// <returns>An object that implements ILengthMeasure, representing the converted length value in a standardized format.</returns>
  /// <exception cref="ArgumentException">Thrown when the specified unit is not supported for conversion.</exception>
  public static TableWidth ConvertFrom(double value, LengthUnit unit) => unit switch
  {
    LengthUnit.Twips => FromTableWidth(value),
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
  public static TableWidth Parse(string value) => new TableWidth(value);

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
  public static bool TryParse(string value, out TableWidth? result)
  {
    try
    {
      result = new TableWidth(value);
      return true;
    }
    catch
    {
      result = null;
      return false;
    }
  }

  #endregion

  #region Implicit Conversions

  /// <summary>
  /// Implicitly converts a string to a <see cref="TableWidth"/> value.
  /// </summary>
  /// <param name="value">The string to convert.</param>
  /// <returns>A <see cref="TableWidth"/> value parsed from the string.</returns>
  public static implicit operator TableWidth(string value)
  {
    return new TableWidth(value);
  }

  /// <summary>
  /// Implicitly converts a <see cref="TableWidth"/> value to a string.
  /// </summary>
  /// <param name="value">The <see cref="TableWidth"/> value to convert.</param>
  /// <returns>A string representation of the TableWidth value.</returns>
  public static implicit operator string(TableWidth value)
  {
    return value.ToString();
  }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer to a <see cref="TableWidth"/> value.
  /// </summary>
  /// <param name="value">The 32-bit signed integer to convert.</param>
  /// <returns>A <see cref="TableWidth"/> value representing the integer.</returns>
  public static implicit operator TableWidth(Int32 value)
  {
    return new TableWidth(value);
  }

  /// <summary>
  /// Implicitly converts a 64-bit signed integer to a <see cref="TableWidth"/> value.
  /// </summary>
  /// <param name="value">The 64-bit signed integer to convert.</param>
  /// <returns>A <see cref="TableWidth"/> value representing the integer.</returns>
  public static implicit operator TableWidth(Int64 value)
  {
    return new TableWidth(value);
  }

  /// <summary>
  /// Implicitly converts a double-precision floating-point number to a TableWidth instance.
  /// </summary>
  /// <remarks>This conversion allows for seamless integration of double values into contexts where TableWidth are
  /// required, facilitating operations that involve measurements in TableWidth.</remarks>
  /// <param name="value">The value to convert, representing a measurement in TableWidth.</param>
  public static implicit operator TableWidth(Double value)
  {
    return new TableWidth(value);
  }

  #endregion


  #region IComparable and IEquatable Implementations

  /// <summary>
  /// Compares this instance to a specified <see cref="TableWidth"/> object and returns an indication of their relative values.
  /// </summary>
  /// <param name="other">A <see cref="TableWidth"/> object to compare.</param>
  /// <returns>
  /// A signed number indicating the relative values of this instance and <paramref name="other"/>.
  /// Less than zero if this instance is less than <paramref name="other"/>;
  /// zero if this instance equals <paramref name="other"/>;
  /// greater than zero if this instance is greater than <paramref name="other"/>.
  /// </returns>
  public int CompareTo(TableWidth? other)
  {
    if (other == null)
      throw new ArgumentNullException(nameof(other), "Cannot compare to null.");
    if (other.Type != Type)
      throw new ArgumentException($"Cannot compare TableWidth of type {Type} to TableWidth of type {other.Type}.");
    if (Type == TableWidthUnit.Auto || Type == TableWidthUnit.Nil)
      return 0; // Consider "auto" and "nil" as equal for comparison purposes 
    return DecimalValue.CompareTo(other.DecimalValue);
  }

  /// <summary>
  /// Returns the hash code for this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  public override int GetHashCode()
  {
    // ReSharper disable once BaseObjectGetHashCodeCallInGetHashCode
    return base.GetHashCode();
  }

  /// <summary>
  /// Indicates whether the current object is equal to another object of the same type.
  /// </summary>
  /// <param name="other">An object to compare with this object.</param>
  /// <returns><see langword="true"/> if the current object is equal to the <paramref name="other"/> parameter; otherwise, <see langword="false"/>.</returns>
  public bool Equals(TableWidth? other)
  {
    if (other == null)
      return IsEmpty;
    if (other.Type != Type)
      throw new ArgumentException($"Cannot compare TableWidth of type {Type} to TableWidth of type {other.Type}.");
    if (Type == TableWidthUnit.Auto || Type == TableWidthUnit.Nil)
      return true; // Consider "auto" and "nil" as equal for comparison purposes 

    return System.Math.Abs(ToInch() - other.ToInch()) < 1e-10;

  }

  /// <summary>
  /// Determines whether the specified object is equal to the current TableWidth instance.
  /// </summary>
  /// <remarks>This method supports value comparison for TableWidth instances. It returns false if the provided
  /// object is not a TableWidth instance.</remarks>
  /// <param name="obj">The object to compare with the current instance. This parameter can be null.</param>
  /// <returns>true if the specified object is a TableWidth instance equal to the current instance; otherwise, false.</returns>
  public override bool Equals(object? obj)
  {
    if (obj is TableWidth tableWidth)
      return Equals(tableWidth);

    if (obj is IConvertible convertible)
    {
      var doubleValue = Convert.ToDouble(convertible);
      return System.Math.Abs(DoubleValue - doubleValue) < 1e-10;
    }
    return false;
  }

  #endregion
}