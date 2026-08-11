// ReSharper disable SpecifyACultureInStringConversionExplicitly
using DocumentModel.BaseTypes.Interfaces;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines the HeightMeasureType class. Its Value can be Exact (in HeightMeasure) or relative (in fiftieth of percent), or "auto" or "nil".
/// The type of the Value is determined with the Type property.
/// This class is used in multiple measures according to table horizontal dimension.
/// </summary>
[JsonConverter(typeof(HeightMeasureJsonConverter))]
[DataContract]
[XmlRoot("HeightMeasure", Namespace = "DocumentModel.Wordprocessing")]
public sealed partial class HeightMeasure : UniversalMeasure, IComparable<HeightMeasure>, IEquatable<HeightMeasure>
{
 static HeightMeasure()
 {
  HeightMeasureOpenXmlConverter.RegisterOpenXmlConversion();
 }

 /// <summary>
 /// Defines the number of HeightMeasure in one inch.
 /// </summary>
 protected override decimal UnitsPerInch => 1440.0m;

 /// <summary>
 /// Gets or sets the value represented as a nullable 64-bit signed integer.
 /// </summary>
 /// <remarks>This property allows for the storage of a 64-bit signed integer value, which can be null. It is
 /// useful in scenarios where the absence of a value is significant.</remarks>
 [XmlIgnore]
 [JsonIgnore]
 [NotMapped]
 public Int64? Value { get => (Int64? )value; set => base.value = value; }

 /// <summary>
 /// Represents the type of the HeightMeasure value, which can be Exact (in HeightMeasure), relative (in fiftieth of percent),
 /// or special values like "auto" or "nil".
 /// </summary>
 [XmlIgnore]
 [JsonIgnore]
 [NotMapped]
 public HeightMeasureType Type { get => _type; set => _type = value; }
 private HeightMeasureType _type;
#region Constructors
 /// <summary>
 /// Default constructor. Creates an empty instance.
 /// </summary>
 public HeightMeasure()
 {
 }

 /// <summary>
 /// Initializes a new instance of the <see cref = "HeightMeasure"/> from a string value.
 /// </summary>
 /// <param name = "str">The string value to parse.
 ///  Can include optional unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), or "in" (inches).
 /// Can include optional prefixes like "atLeast" or "exact" to indicate the type of height measurement.
 /// if prefix is not specified, the type is determined as exact value.
 /// </param>
 /// <remarks>
 /// <para>Supported formats:</para>
 /// <list type="bullet">
 /// <item><description>"100" - interpreted as twips</description></item>
 /// <item><description>"10mm" - millimeters</description></item>
 /// <item><description>"1cm" - centimeters</description></item>
 /// <item><description>"12pt" - points</description></item>
 /// <item><description>"1in" - inches</description></item>
 /// <item><description>"auto" - automatic height</description></item>
 /// </list>
 /// <para>Commas in the input string are replaced with periods before parsing to ensure decimal separator consistency.</para>
 /// </remarks>
 public HeightMeasure(string str)
 {
  Init(str);
 }

 /// <summary>
 /// Initializes a new instance of the <see cref = "HeightMeasure"/> from a 64-bit signed integer value and a specified type.
 /// </summary>
 /// <param name = "value">The value in HeightMeasure.</param>
 /// <param name = "type">The type of the HeightMeasure value.</param>
 public HeightMeasure(Int64 value, HeightMeasureType type)
 {
  Init(value);
  _type = type;
 }

 /// <summary>
 /// Initializes a new instance of the <see cref = "HeightMeasure"/> from an Int64 value.
 /// </summary>
 /// <param name = "value">The value in HeightMeasure.</param>
 public HeightMeasure(Int64 value)
 {
  Init(value);
  _type = HeightMeasureType.Exact;
 }

 /// <summary>
 /// Initializes a new instance of the <see cref = "HeightMeasure"/> from a UInt64 value.
 /// </summary>
 /// <param name = "value">The value in HeightMeasure.</param>
 public HeightMeasure(UInt64 value)
 {
  Init(value);
  _type = HeightMeasureType.Exact;
 }

 /// <summary>
 /// Initializes a new instance of the <see cref = "HeightMeasure"/> from a Decimal value.
 /// </summary>
 /// <param name = "value">The value in HeightMeasure.</param>
 public HeightMeasure(Decimal value)
 {
  Init(value);
  _type = HeightMeasureType.Exact;
 }

 /// <summary>
 /// Initializes a new instance of the <see cref = "HeightMeasure"/> from a Double value.
 /// </summary>
 /// <param name = "value">The value in HeightMeasure.</param>
 public HeightMeasure(Double value)
 {
  Init(value);
  _type = HeightMeasureType.Exact;
 }

#endregion
#region string conversion
 /// <summary>
 /// Initializes the table width unit based on the specified string representation.
 /// </summary>
 /// <remarks>If the input string represents a percentage, it is converted to fiftieths of a percent. The
 /// method sets the Type property to indicate the unit of measurement and adjusts the internal value
 /// accordingly.</remarks>
 /// <param name = "str">The string that specifies the table width. Supported values include "auto", "atLeast "+value,
 /// or "exact "+value.</param>
 private new void Init(string str)
 {
  if (str == "auto")
  {
   _type = HeightMeasureType.Auto;
   value = 0;
  }
  else if (str.StartsWith("atLeast "))
  {
   base.Init(str.Substring("atLeast ".Length)); // Parse as Exact value
   _type = HeightMeasureType.AtLeast;
  }
  else if (str.StartsWith("exact "))
  {
   base.Init(str.Substring("exact ".Length)); // Parse as Exact value
   _type = HeightMeasureType.Exact;
  }
  else
  {
   base.Init(str); // Parse as Exact value
   _type = HeightMeasureType.Exact;
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
  if (Type == HeightMeasureType.Auto)
   return "auto";
  var result = base.ToString() + "tw";
  if (Type == HeightMeasureType.AtLeast)
   return "atLeast " + result;
  if (Type == HeightMeasureType.Exact)
   return "exact " + result;
  return result;
 }

 /// <summary>
 /// Converts the current length measure to its string representation using the specified format provider.
 /// This allows for culture-specific formatting of the output string, such as using different decimal separators
 /// based on the culture settings provided by the formatProvider.
 /// If the formatProvider is null, the method should use invariant culture's formatting conventions.
 /// </summary>
 /// <param name = "formatProvider">An object that supplies culture-specific formatting information. If null, invariant culture's formatting conventions are used.</param>
 /// <returns>A string representation of the current length measure, formatted according to the specified format provider.</returns>
 public override string ToString(IFormatProvider? formatProvider)
 {
  if (Type == HeightMeasureType.Auto)
   return "auto";
  var result = base.ToString(formatProvider) + "tw";
  if (Type == HeightMeasureType.AtLeast)
   return "atLeast " + result;
  if (Type == HeightMeasureType.Exact)
   return "exact " + result;
  return result;
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
 public override string ToString(string? format, IFormatProvider? formatProvider)
 {
  if (Type == HeightMeasureType.Auto)
   return "auto";
  var result = base.ToString(format, formatProvider) + "tw";
  if (Type == HeightMeasureType.AtLeast)
   return "atLeast " + result;
  if (Type == HeightMeasureType.Exact)
   return "exact " + result;
  return result;
 }

 /// <summary>
 /// Converts the current instance to its string representation using the specified format string.
 /// </summary>
 /// <remarks>If the format string is not recognized or is invalid, a FormatException may be thrown. Supported
 /// format strings may include both standard and custom formats, depending on the implementation.</remarks>
 /// <param name = "format">A format string that defines how the value should be represented.
 /// If null, a default format is used.</param>
 /// <returns>A string representation of the current instance, formatted according to the specified format string.</returns>
 public override string ToString(string? format)
 {
  if (Type == HeightMeasureType.Auto)
   return "auto";
  var result = base.ToString(format) + "tw";
  if (Type == HeightMeasureType.AtLeast)
   return "atLeast " + result;
  if (Type == HeightMeasureType.Exact)
   return "exact " + result;
  return result;
 }

#endregion
#region Static Factory Methods
 /// <summary>
 /// Creates an instance of an <see cref = "HeightMeasure"/> that represents the specified value in Twips.
 /// </summary>
 public static HeightMeasure FromTwips(double twips) => new HeightMeasure($"{twips}tw");
 /// <summary>
 /// Creates an instance of an <see cref = "HeightMeasure"/> that represents the specified value in points.
 /// </summary>
 public static HeightMeasure FromPT(double points) => new HeightMeasure($"{points}pt");
 /// <summary>
 /// Creates a new instance of an object that represents a length specified in millimeters.
 /// </summary>
 public static HeightMeasure FromMM(double millimeters) => new HeightMeasure($"{millimeters}mm");
 /// <summary>
 /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in
 /// centimeters.
 /// </summary>
 public static HeightMeasure FromCM(double centimeters) => new HeightMeasure($"{centimeters}cm");
 /// <summary>
 /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in inches.
 /// </summary>
 public static HeightMeasure FromInch(double inches) => new HeightMeasure($"{inches}in");
 /// <summary>
 /// Converts a length value from the specified unit to a standardized length measure.
 /// </summary>
 /// <remarks>Supported units include HeightMeasure, Points, Millimeters, Centimeters, and Inches.</remarks>
 /// <param name = "value">The numeric length value to convert, expressed in the unit specified by the unit parameter.</param>
 /// <param name = "unit">The unit of measurement for the value parameter. Must be one of the supported length units.</param>
 /// <returns>An object that implements ILengthMeasure, representing the converted length value in a standardized format.</returns>
 /// <exception cref = "ArgumentException">Thrown when the specified unit is not supported for conversion.</exception>
 public static HeightMeasure ConvertFrom(double value, LengthUnit unit) => unit switch
 {
  LengthUnit.Twips => FromTwips(value),
  LengthUnit.Points => FromPT(value),
  LengthUnit.Millimeters => FromMM(value),
  LengthUnit.Centimeters => FromCM(value),
  LengthUnit.Inches => FromInch(value),
  _ => throw new ArgumentException($"Unsupported length unit: {unit}", nameof(unit))};
#endregion
#region Parsing Methods
 /// <summary>
 /// Parses a string representation of a length measure and returns the corresponding ILengthMeasure instance.
 /// </summary>
 /// <remarks>If the input string does not conform to a valid length measure format, an exception may be
 /// thrown.</remarks>
 /// <param name = "value">The string that represents the length measure to parse. The value must be in a format recognized by the parser.</param>
 /// <returns>An instance of ILengthMeasure that represents the parsed length measure.</returns>
 public static HeightMeasure Parse(string value) => new HeightMeasure(value);
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
 public static bool TryParse(string value, out HeightMeasure? result)
 {
  try
  {
   result = new HeightMeasure(value);
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
 /// Implicitly converts a string to a <see cref = "HeightMeasure"/> value.
 /// </summary>
 /// <param name = "value">The string to convert.</param>
 /// <returns>A <see cref = "HeightMeasure"/> value parsed from the string.</returns>
 public static implicit operator HeightMeasure(string value)
 {
  return new HeightMeasure(value);
 }

 /// <summary>
 /// Implicitly converts a <see cref = "HeightMeasure"/> value to a string.
 /// </summary>
 /// <param name = "value">The <see cref = "HeightMeasure"/> value to convert.</param>
 /// <returns>A string representation of the HeightMeasure value.</returns>
 public static implicit operator string (HeightMeasure value)
 {
  return value.ToString();
 }

 /// <summary>
 /// Implicitly converts a 32-bit signed integer to a <see cref = "HeightMeasure"/> value.
 /// </summary>
 /// <param name = "value">The 32-bit signed integer to convert.</param>
 /// <returns>A <see cref = "HeightMeasure"/> value representing the integer.</returns>
 public static implicit operator HeightMeasure(Int32 value)
 {
  return new HeightMeasure(value);
 }

 /// <summary>
 /// Implicitly converts a 64-bit signed integer to a <see cref = "HeightMeasure"/> value.
 /// </summary>
 /// <param name = "value">The 64-bit signed integer to convert.</param>
 /// <returns>A <see cref = "HeightMeasure"/> value representing the integer.</returns>
 public static implicit operator HeightMeasure(Int64 value)
 {
  return new HeightMeasure(value);
 }

 /// <summary>
 /// Implicitly converts a double-precision floating-point number to a HeightMeasure instance.
 /// </summary>
 /// <remarks>This conversion allows for seamless integration of double values into contexts where HeightMeasure are
 /// required, facilitating operations that involve measurements in HeightMeasure.</remarks>
 /// <param name = "value">The value to convert, representing a measurement in HeightMeasure.</param>
 public static implicit operator HeightMeasure(Double value)
 {
  return new HeightMeasure(value);
 }

#endregion
#region IComparable and IEquatable Implementations
 /// <summary>
 /// Compares this instance to a specified <see cref = "HeightMeasure"/> object and returns an indication of their relative values.
 /// </summary>
 /// <param name = "other">A <see cref = "HeightMeasure"/> object to compare.</param>
 /// <returns>
 /// A signed number indicating the relative values of this instance and <paramref name = "other"/>.
 /// Less than zero if this instance is less than <paramref name = "other"/>;
 /// zero if this instance equals <paramref name = "other"/>;
 /// greater than zero if this instance is greater than <paramref name = "other"/>.
 /// </returns>
 public int CompareTo(HeightMeasure? other)
 {
  if (other == null)
   throw new ArgumentNullException(nameof(other), "Cannot compare to null.");
  if (other.Type != Type)
   throw new ArgumentException($"Cannot compare HeightMeasure of type {Type} to HeightMeasure of type {other.Type}.");
  if (Type == HeightMeasureType.Auto)
   return 0; // Consider "auto" as equal for comparison purposes 
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
 /// <param name = "other">An object to compare with this object.</param>
 /// <returns><see langword="true"/> if the current object is equal to the <paramref name = "other"/> parameter; otherwise, <see langword="false"/>.</returns>
 public bool Equals(HeightMeasure? other)
 {
  if (other == null)
   return IsEmpty;
  if (other.Type != Type)
   throw new ArgumentException($"Cannot compare HeightMeasure of type {Type} to HeightMeasure of type {other.Type}.");
  if (Type == HeightMeasureType.Auto)
   return true; // Consider "auto" as equal for comparison purposes 
  return System.Math.Abs(ToInch() - other.ToInch()) < 1e-10m;
 }

 /// <summary>
 /// Determines whether the specified object is equal to the current HeightMeasure instance.
 /// </summary>
 /// <remarks>This method supports value comparison for HeightMeasure instances. It returns false if the provided
 /// object is not a HeightMeasure instance.</remarks>
 /// <param name = "obj">The object to compare with the current instance. This parameter can be null.</param>
 /// <returns>true if the specified object is a HeightMeasure instance equal to the current instance; otherwise, false.</returns>
 public override bool Equals(object? obj)
 {
  if (obj is HeightMeasure HeightMeasure)
   return Equals(HeightMeasure);
  if (obj is IConvertible convertible)
  {
   var doubleValue = Convert.ToDouble(convertible);
   return System.Math.Abs(DoubleValue - doubleValue) < 1e-10;
  }

  return false;
 }

#endregion
#region OpenXml conversion methods
 /// <summary>
 /// Creates a new HeightMeasure instance from an OpenXML height value and an optional height rule type.
 /// </summary>
 /// <remarks>Use this method to convert OpenXML height specifications into a HeightMeasure object for use
 /// within the application. If the heightType parameter is not provided, the resulting HeightMeasure will use
 /// HeightMeasureType.Auto.</remarks>
 /// <param name = "val">The height value as a UInt32Value, representing the height in OpenXML units.</param>
 /// <param name = "heightType">An optional height rule type that determines how the height value is interpreted. If null, the height type
 /// defaults to Auto.</param>
 /// <returns>A HeightMeasure instance that encapsulates the specified height value and its corresponding height type.</returns>
 public static HeightMeasure FromOpenXml(DX.UInt32Value? val, DX.EnumValue<DXW.HeightRuleValues>? heightType)
 {
  HeightMeasureType? type = HeightMeasureType.Auto;
  if (heightType != null)
   type = OpenXml.EnumTypeConverter.ConvertFrom<HeightMeasureType, DXW.HeightRuleValues>(heightType!);
  UInt32 nonNullVal = val?.Value ?? 0;
  return new HeightMeasure(nonNullVal, type!.Value);
 }

 /// <summary>
 /// Converts the current height measure instance to its OpenXML representation.
 /// </summary>
 /// <remarks>Use this method to obtain the OpenXML-compatible values for table or row height settings when
 /// working with the OpenXML SDK. The returned values can be used directly with OpenXML elements that require height
 /// specifications.</remarks>
 /// <returns>A tuple containing the OpenXML value as a UInt32Value and an optional height type as an EnumValue of
 /// HeightRuleValues. The height type may be null if not applicable.</returns>
 public (DX.UInt32Value val, DX.EnumValue<DXW.HeightRuleValues>? heightType) ToOpenXml()
 {
  var val = (UInt32)UIntValue;
  DXW.HeightRuleValues heightType = OpenXml.EnumTypeConverter.ConvertTo<DXW.HeightRuleValues, HeightMeasureType>(Type);
  return (val, heightType);
 }
#endregion
}