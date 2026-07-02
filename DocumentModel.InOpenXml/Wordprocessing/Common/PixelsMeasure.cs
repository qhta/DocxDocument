// ReSharper disable SpecifyACultureInStringConversionExplicitly
using DocumentModel.BaseTypes.Interfaces;

using Math = System.Math;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines the PixelsType class. Its Value can be Exact (in Pixels) or relative (in fiftieth of percent), or "auto" or "nil".
/// The type of the Value is determined with the Type property.
/// This class is used in multiple measures according to table horizontal dimension.
/// </summary>
[JsonConverter(typeof(PixelsMeasureJsonConverter))]
[DataContract]
[XmlRoot("Pixels", Namespace = "DocumentModel.Wordprocessing")]
public partial class PixelsMeasure : IComparable<PixelsMeasure>, IEquatable<PixelsMeasure>
{
  static PixelsMeasure()
  {
    PixelsMeasureOpenXmlConverter.RegisterOpenXmlConversion();
  }


  /// <summary>
  /// Gets or sets the value represented as a 32-bit unsigned integer.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public readonly UInt32 Value;


  #region Constructors
  /// <summary>
  /// Default constructor. Creates an empty instance.
  /// </summary>
  public PixelsMeasure()
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref = "PixelsMeasure"/> from a string value.
  /// </summary>
  /// <param name = "str">The string value to parse.
  /// </param>
  public PixelsMeasure(string str)
  {
    Value = UInt32.Parse(str);
  }

  /// <summary>
  /// Initializes a new instance of the <see cref = "PixelsMeasure"/> from a 64-bit signed integer value.
  /// </summary>
  /// <param name = "value">The value in Pixels.</param>
  public PixelsMeasure(Int64 value)
  {
    Value = (UInt32)System.Math.Max(value, 0); // Ensure non-negative value
  }


  /// <summary>
  /// Initializes a new instance of the <see cref = "PixelsMeasure"/> from a UInt64 value.
  /// </summary>
  /// <param name = "value">The value in Pixels.</param>
  public PixelsMeasure(UInt64 value)
  {
    Value = (UInt32)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref = "PixelsMeasure"/> from a Decimal value.
  /// </summary>
  /// <param name = "value">The value in Pixels.</param>
  public PixelsMeasure(Decimal value)
  {
    Value = (UInt32)value;
  }

  /// <summary>
  /// Initializes a new instance of the <see cref = "PixelsMeasure"/> from a Double value.
  /// </summary>
  /// <param name = "value">The value in Pixels.</param>
  public PixelsMeasure(Double value)
  {
    Value = (UInt32)value;
  }

  #endregion

  #region string conversion

  /// <summary>
  /// Returns a string that represents the current table width unit in a human-readable format.
  /// </summary>
  public override string ToString()
  {
    return Value.ToString();
  }

  /// <summary>
  /// Converts the current length measure to its string representation using the specified format provider.
  /// This allows for culture-specific formatting of the output string, such as using different decimal separators
  /// based on the culture settings provided by the formatProvider.
  /// If the formatProvider is null, the method should use invariant culture's formatting conventions.
  /// </summary>
  /// <param name = "formatProvider">An object that supplies culture-specific formatting information. If null, invariant culture's formatting conventions are used.</param>
  /// <returns>A string representation of the current length measure, formatted according to the specified format provider.</returns>
  public string ToString(IFormatProvider? formatProvider)
  {
    return Value.ToString(formatProvider);
  }

  /// <summary>
  /// Converts the current length measure to its string representation using the specified format string and format provider.
  /// The format string can specify how the numeric value should be formatted (e.g., number of decimal places, unit symbols)
  /// while the format provider allows for culture-specific formatting.
  /// If the format string is null or empty, a default numeric format should be used.
  /// If the format provider is null, invariant culture's formatting conventions should be applied.
  /// </summary>
  /// <param name = "format">A standard or custom numeric format string. If null or empty, a default numeric format is used.</param>
  /// <param name = "formatProvider">An object that supplies culture-specific formatting information.
  /// If null, invariant culture's formatting conventions are used.</param>
  /// <returns>A string representation of the current length measure,
  /// formatted according to the specified format string and format provider.</returns>
  public string ToString(string? format, IFormatProvider? formatProvider)
  {
    return Value.ToString(format, formatProvider);
  }

  /// <summary>
  /// Converts the current instance to its string representation using the specified format string.
  /// </summary>
  /// <remarks>If the format string is not recognized or is invalid, a FormatException may be thrown. Supported
  /// format strings may include both standard and custom formats, depending on the implementation.</remarks>
  /// <param name = "format">A format string that defines how the value should be represented.
  /// If null, a default format is used.</param>
  /// <returns>A string representation of the current instance, formatted according to the specified format string.</returns>
  public string ToString(string? format)
  {
    return Value.ToString(format);
  }

  #endregion

  #region Parsing Methods
  /// <summary>
  /// Parses a string representation of a length measure and returns the corresponding ILengthMeasure instance.
  /// </summary>
  /// <remarks>If the input string does not conform to a valid length measure format, an exception may be
  /// thrown.</remarks>
  /// <param name = "value">The string that represents the length measure to parse. The value must be in a format recognized by the parser.</param>
  /// <returns>An instance of ILengthMeasure that represents the parsed length measure.</returns>
  public static PixelsMeasure Parse(string value) => new PixelsMeasure(value);
  /// <summary>
  /// Attempts to parse the specified string representation of a length measure and returns a value that indicates
  /// whether the parsing succeeded.
  /// </summary>
  /// <remarks>This method does not throw an exception if parsing fails. Instead, it returns <see 
  ///langword="false"/> and sets <paramref name = "result"/> to <see langword="null"/>.</remarks>
  /// <param name = "value">The string representation of the length measure to parse.</param>
  /// <param name = "result">When this method returns, contains the parsed length measure if the parsing succeeded; otherwise, <see 
  ///langword="null"/>.</param>
  /// <returns><see langword="true"/> if the string was parsed successfully; otherwise, <see langword="false"/>.</returns>
  public static bool TryParse(string value, out PixelsMeasure? result)
  {
    if (UInt32.TryParse(value, out var parsedValue))
    {
      result = new PixelsMeasure(parsedValue);
      return true;
    }
    result = null;
    return false;
  }

  #endregion

  #region Implicit Conversions
  /// <summary>
  /// Implicitly converts a string to a <see cref = "PixelsMeasure"/> value.
  /// </summary>
  /// <param name = "value">The string to convert.</param>
  /// <returns>A <see cref = "PixelsMeasure"/> value parsed from the string.</returns>
  public static implicit operator PixelsMeasure(string value)
  {
    return new PixelsMeasure(value);
  }

  /// <summary>
  /// Implicitly converts a <see cref = "PixelsMeasure"/> value to a string.
  /// </summary>
  /// <param name = "value">The <see cref = "PixelsMeasure"/> value to convert.</param>
  /// <returns>A string representation of the Pixels value.</returns>
  public static implicit operator string(PixelsMeasure value)
  {
    return value.ToString();
  }

  /// <summary>
  /// Implicitly converts a 32-bit signed integer to a <see cref = "PixelsMeasure"/> value.
  /// </summary>
  /// <param name = "value">The 32-bit signed integer to convert.</param>
  /// <returns>A <see cref = "PixelsMeasure"/> value representing the integer.</returns>
  public static implicit operator PixelsMeasure(Int32 value)
  {
    return new PixelsMeasure(value);
  }

  /// <summary>
  /// Implicitly converts a 64-bit signed integer to a <see cref = "PixelsMeasure"/> value.
  /// </summary>
  /// <param name = "value">The 64-bit signed integer to convert.</param>
  /// <returns>A <see cref = "PixelsMeasure"/> value representing the integer.</returns>
  public static implicit operator PixelsMeasure(Int64 value)
  {
    return new PixelsMeasure(value);
  }

  /// <summary>
  /// Implicitly converts a double-precision floating-point number to a Pixels instance.
  /// </summary>
  /// <remarks>This conversion allows for seamless integration of double values into contexts where Pixels are
  /// required, facilitating operations that involve measurements in Pixels.</remarks>
  /// <param name = "value">The value to convert, representing a measurement in Pixels.</param>
  public static implicit operator PixelsMeasure(Double value)
  {
    return new PixelsMeasure(value);
  }

  #endregion
  #region IComparable and IEquatable Implementations
  /// <summary>
  /// Compares this instance to a specified <see cref = "PixelsMeasure"/> object and returns an indication of their relative values.
  /// </summary>
  /// <param name = "other">A <see cref = "PixelsMeasure"/> object to compare.</param>
  /// <returns>
  /// A signed number indicating the relative values of this instance and <paramref name = "other"/>.
  /// Less than zero if this instance is less than <paramref name = "other"/>;
  /// zero if this instance equals <paramref name = "other"/>;
  /// greater than zero if this instance is greater than <paramref name = "other"/>.
  /// </returns>
  public int CompareTo(PixelsMeasure? other)
  {
    if (other == null)
      throw new ArgumentNullException(nameof(other), "Cannot compare to null.");
    return Value.CompareTo(other.Value);
  }

  /// <summary>
  /// Returns the hash code for this instance.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code.</returns>
  public override int GetHashCode()
  {
    // ReSharper disable once BaseObjectGetHashCodeCallInGetHashCode
    return Value.GetHashCode();
  }

  /// <summary>
  /// Indicates whether the current object is equal to another object of the same type.
  /// </summary>
  /// <param name = "other">An object to compare with this object.</param>
  /// <returns><see langword="true"/> if the current object is equal to the <paramref name = "other"/> parameter; otherwise, <see langword="false"/>.</returns>
  public bool Equals(PixelsMeasure? other)
  {
    if (other == null)
      return false;
    return Value.Equals(other.Value);
  }

  /// <summary>
  /// Determines whether the specified object is equal to the current Pixels instance.
  /// </summary>
  /// <remarks>This method supports value comparison for Pixels instances. It returns false if the provided
  /// object is not a Pixels instance.</remarks>
  /// <param name = "obj">The object to compare with the current instance. This parameter can be null.</param>
  /// <returns>true if the specified object is a Pixels instance equal to the current instance; otherwise, false.</returns>
  public override bool Equals(object? obj)
  {
    if (obj is PixelsMeasure Pixels)
      return Equals(Pixels);
    return false;
  }

  #endregion

  #region OpenXml conversion methods
  /// <summary>
  /// Creates a new Pixels instance from an OpenXML height value and an optional height rule type.
  /// </summary>
  /// <param name = "val">The height value as a UInt32Value, representing the height in OpenXML units.</param>
  /// <returns>A Pixels instance that encapsulates the specified height value and its corresponding height type.</returns>
  public static PixelsMeasure FromOpenXml(DXW.PixelsMeasureType val)
  {
    return new PixelsMeasure(val.Val!.Value);
  }

  /// <summary>
  /// Converts the current height measure instance to its OpenXML representation.
  /// </summary>
  /// <remarks>Use this method to obtain the OpenXML-compatible values for table or row height settings when
  /// working with the OpenXML SDK. The returned values can be used directly with OpenXML elements that require height
  /// specifications.</remarks>
  /// <returns>A tuple containing the OpenXML value as a UInt32Value and an optional height type as an EnumValue of
  /// HeightRuleValues. The height type may be null if not applicable.</returns>
  public DXW.PixelsMeasureType ToOpenXml(Type openXmlType)
  {
    if (openXmlType.IsAssignableTo(typeof(DXW.PixelsMeasureType)))
    {
      DXW.PixelsMeasureType pixelsMeasureType = (DXW.PixelsMeasureType)Activator.CreateInstance(openXmlType)!;
      pixelsMeasureType.Val = new DX.UInt32Value(Value);
      return pixelsMeasureType;
    }
    throw new InvalidOperationException($"Unsupported OpenXML type: {openXmlType}");
  }

  #endregion
}