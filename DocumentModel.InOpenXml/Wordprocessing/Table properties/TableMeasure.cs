// ReSharper disable SpecifyACultureInStringConversionExplicitly
using DocumentModel.BaseTypes.Interfaces;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines the TableMeasureType class. Its Value can be absolute (in TableMeasure) or relative (in fiftieth of percent), or "auto" or "nil".
/// The type of the Value is determined with the Type property.
/// This class is used in multiple measures according to table horizontal dimension.
/// </summary>
[JsonConverter(typeof(TableMeasureJsonConverter))]
[DataContract]
[XmlRoot("TableMeasure", Namespace = "DocumentModel.Wordprocessing")]
public sealed partial class TableMeasure : UniversalMeasure, IComparable<TableMeasure>, IEquatable<TableMeasure>
{
 static TableMeasure()
 {
  TableMeasureOpenXmlConverter.RegisterOpenXmlConversion();
 }

 /// <summary>
 /// Defines the number of TableMeasure in one inch.
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
 /// Represents the type of the TableMeasure value, which can be absolute (in TableMeasure), relative (in fiftieth of percent),
 /// or special values like "auto" or "nil".
 /// </summary>
 [XmlIgnore]
 [JsonIgnore]
 [NotMapped]
 public TableMeasureType Type { get => _type; set => _type = value; }
 private TableMeasureType _type;
#region Constructors
 /// <summary>
 /// Default constructor. Creates an empty instance.
 /// </summary>
 public TableMeasure()
 {
 }

 /// <summary>
 /// Initializes a new instance of the <see cref = "TableMeasure"/> from a string value.
 /// </summary>
 /// <param name = "str">The string value to parse. Can include optional unit suffixes: "mm" (millimeters), "cm" (centimeters), "pt" (points), or "in" (inches).</param>
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
 public TableMeasure(string str)
 {
  Init(str);
 }

 /// <summary>
 /// Initializes a new instance of the <see cref = "TableMeasure"/> from an Int64 value and a specified type.
 /// </summary>
 /// <param name = "value">The value in TableMeasure.</param>
 /// <param name = "type">The type of the TableMeasure value.</param>
 public TableMeasure(Int64 value, TableMeasureType type)
 {
  Init(value);
  _type = type;
 }

 /// <summary>
 /// Initializes a new instance of the <see cref = "TableMeasure"/> from an Int64 value.
 /// </summary>
 /// <param name = "value">The value in TableMeasure.</param>
 public TableMeasure(Int64 value)
 {
  Init(value);
  _type = TableMeasureType.Absolute;
 }

 /// <summary>
 /// Initializes a new instance of the <see cref = "TableMeasure"/> from a UInt64 value.
 /// </summary>
 /// <param name = "value">The value in TableMeasure.</param>
 public TableMeasure(UInt64 value)
 {
  Init(value);
  _type = TableMeasureType.Absolute;
 }

 /// <summary>
 /// Initializes a new instance of the <see cref = "TableMeasure"/> from a Decimal value.
 /// </summary>
 /// <param name = "value">The value in TableMeasure.</param>
 public TableMeasure(Decimal value)
 {
  Init(value);
  _type = TableMeasureType.Absolute;
 }

 /// <summary>
 /// Initializes a new instance of the <see cref = "TableMeasure"/> from a Double value.
 /// </summary>
 /// <param name = "value">The value in TableMeasure.</param>
 public TableMeasure(Double value)
 {
  Init(value);
  _type = TableMeasureType.Absolute;
 }

#endregion
#region string conversion
 /// <summary>
 /// Initializes the table width unit based on the specified string representation.
 /// </summary>
 /// <remarks>If the input string represents a percentage, it is converted to fiftieths of a percent. The
 /// method sets the Type property to indicate the unit of measurement and adjusts the internal value
 /// accordingly.</remarks>
 /// <param name = "str">The string that specifies the table width. Supported values include "nil", "auto", a percentage (e.g., "50%"), or
 /// an absolute value.</param>
 private new void Init(string str)
 {
  if (str == "nil")
  {
   _type = TableMeasureType.Nil;
   value = 0;
  }
  else if (str == "auto")
  {
   _type = TableMeasureType.Auto;
   value = 0;
  }
  else if (str.EndsWith("%"))
  {
   _type = TableMeasureType.Relative;
   value = Decimal.Parse(str.TrimEnd('%').Replace(',', '.'), CultureInfo.InvariantCulture) * 50; // Convert percentage to fiftieths of percent
  }
  else
  {
   base.Init(str); // Parse as absolute value
   _type = TableMeasureType.Absolute;
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
  if (Type == TableMeasureType.Auto)
   return "auto";
  if (Type == TableMeasureType.Nil)
   return "nil";
  if (Type == TableMeasureType.Relative)
   return (DecimalValue / 50).ToString(CultureInfo.InvariantCulture) + "%";
  return base.ToString();
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
  if (Type == TableMeasureType.Auto)
   return "auto";
  if (Type == TableMeasureType.Nil)
   return "nil";
  if (Type == TableMeasureType.Relative)
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
 /// <param name = "format">A standard or custom numeric format string. If null or empty, a default numeric format is used.</param>
 /// <param name = "formatProvider">An object that supplies culture-specific formatting information.
 /// If null, invariant culture's formatting conventions are used.</param>
 /// <returns>A string representation of the current length measure,
 /// formatted according to the specified format string and format provider.</returns>
 public override string ToString(string? format, IFormatProvider? formatProvider)
 {
  if (Type == TableMeasureType.Auto)
   return "auto";
  if (Type == TableMeasureType.Nil)
   return "nil";
  if (Type == TableMeasureType.Relative)
   return (DecimalValue / 50).ToString(format, formatProvider) + "%";
  return base.ToString();
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
  if (Type == TableMeasureType.Auto)
   return "auto";
  if (Type == TableMeasureType.Nil)
   return "nil";
  if (Type == TableMeasureType.Relative)
   return (DecimalValue / 50).ToString(format, CultureInfo.InvariantCulture) + "%";
  return base.ToString();
 }

#endregion
#region Static Factory Methods
 /// <summary>
 /// Creates an instance of an <see cref = "TableMeasure"/> that represents the specified value in Twips.
 /// </summary>
 public static TableMeasure FromTwips(double Twips) => new TableMeasure($"{Twips}tw");
 /// <summary>
 /// Creates an instance of an <see cref = "TableMeasure"/> that represents the specified value in points.
 /// </summary>
 public static TableMeasure FromPT(double points) => new TableMeasure($"{points}pt");
 /// <summary>
 /// Creates a new instance of an object that represents a length specified in millimeters.
 /// </summary>
 public static TableMeasure FromMM(double millimeters) => new TableMeasure($"{millimeters}mm");
 /// <summary>
 /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in
 /// centimeters.
 /// </summary>
 public static TableMeasure FromCM(double centimeters) => new TableMeasure($"{centimeters}cm");
 /// <summary>
 /// Creates a new instance of an object that implements the ILengthMeasure interface from a specified length in inches.
 /// </summary>
 public static TableMeasure FromInch(double inches) => new TableMeasure($"{inches}in");
 /// <summary>
 /// Converts a length value from the specified unit to a standardized length measure.
 /// </summary>
 /// <remarks>Supported units include TableMeasure, Points, Millimeters, Centimeters, and Inches.</remarks>
 /// <param name = "value">The numeric length value to convert, expressed in the unit specified by the unit parameter.</param>
 /// <param name = "unit">The unit of measurement for the value parameter. Must be one of the supported length units.</param>
 /// <returns>An object that implements ILengthMeasure, representing the converted length value in a standardized format.</returns>
 /// <exception cref = "ArgumentException">Thrown when the specified unit is not supported for conversion.</exception>
 public static TableMeasure ConvertFrom(double value, LengthUnit unit) => unit switch
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
 public static TableMeasure Parse(string value) => new TableMeasure(value);
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
 public static bool TryParse(string value, out TableMeasure? result)
 {
  try
  {
   result = new TableMeasure(value);
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
 /// Implicitly converts a string to a <see cref = "TableMeasure"/> value.
 /// </summary>
 /// <param name = "value">The string to convert.</param>
 /// <returns>A <see cref = "TableMeasure"/> value parsed from the string.</returns>
 public static implicit operator TableMeasure(string value)
 {
  return new TableMeasure(value);
 }

 /// <summary>
 /// Implicitly converts a <see cref = "TableMeasure"/> value to a string.
 /// </summary>
 /// <param name = "value">The <see cref = "TableMeasure"/> value to convert.</param>
 /// <returns>A string representation of the TableMeasure value.</returns>
 public static implicit operator string (TableMeasure value)
 {
  return value.ToString();
 }

 /// <summary>
 /// Implicitly converts a 32-bit signed integer to a <see cref = "TableMeasure"/> value.
 /// </summary>
 /// <param name = "value">The 32-bit signed integer to convert.</param>
 /// <returns>A <see cref = "TableMeasure"/> value representing the integer.</returns>
 public static implicit operator TableMeasure(Int32 value)
 {
  return new TableMeasure(value);
 }

 /// <summary>
 /// Implicitly converts a 64-bit signed integer to a <see cref = "TableMeasure"/> value.
 /// </summary>
 /// <param name = "value">The 64-bit signed integer to convert.</param>
 /// <returns>A <see cref = "TableMeasure"/> value representing the integer.</returns>
 public static implicit operator TableMeasure(Int64 value)
 {
  return new TableMeasure(value);
 }

 /// <summary>
 /// Implicitly converts a double-precision floating-point number to a TableMeasure instance.
 /// </summary>
 /// <remarks>This conversion allows for seamless integration of double values into contexts where TableMeasure are
 /// required, facilitating operations that involve measurements in TableMeasure.</remarks>
 /// <param name = "value">The value to convert, representing a measurement in TableMeasure.</param>
 public static implicit operator TableMeasure(Double value)
 {
  return new TableMeasure(value);
 }

#endregion
#region IComparable and IEquatable Implementations
 /// <summary>
 /// Compares this instance to a specified <see cref = "TableMeasure"/> object and returns an indication of their relative values.
 /// </summary>
 /// <param name = "other">A <see cref = "TableMeasure"/> object to compare.</param>
 /// <returns>
 /// A signed number indicating the relative values of this instance and <paramref name = "other"/>.
 /// Less than zero if this instance is less than <paramref name = "other"/>;
 /// zero if this instance equals <paramref name = "other"/>;
 /// greater than zero if this instance is greater than <paramref name = "other"/>.
 /// </returns>
 public int CompareTo(TableMeasure? other)
 {
  if (other == null)
   throw new ArgumentNullException(nameof(other), "Cannot compare to null.");
  if (other.Type != Type)
   throw new ArgumentException($"Cannot compare TableMeasure of type {Type} to TableMeasure of type {other.Type}.");
  if (Type == TableMeasureType.Auto || Type == TableMeasureType.Nil)
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
 /// <param name = "other">An object to compare with this object.</param>
 /// <returns><see langword="true"/> if the current object is equal to the <paramref name = "other"/> parameter; otherwise, <see langword="false"/>.</returns>
 public bool Equals(TableMeasure? other)
 {
  if (other == null)
   return IsEmpty;
  if (other.Type != Type)
   throw new ArgumentException($"Cannot compare TableMeasure of type {Type} to TableMeasure of type {other.Type}.");
  if (Type == TableMeasureType.Auto || Type == TableMeasureType.Nil)
   return true; // Consider "auto" and "nil" as equal for comparison purposes 
  return System.Math.Abs(ToInch() - other.ToInch()) < 1e-10m;
 }

 /// <summary>
 /// Determines whether the specified object is equal to the current TableMeasure instance.
 /// </summary>
 /// <remarks>This method supports value comparison for TableMeasure instances. It returns false if the provided
 /// object is not a TableMeasure instance.</remarks>
 /// <param name = "obj">The object to compare with the current instance. This parameter can be null.</param>
 /// <returns>true if the specified object is a TableMeasure instance equal to the current instance; otherwise, false.</returns>
 public override bool Equals(object? obj)
 {
  if (obj is TableMeasure TableMeasure)
   return Equals(TableMeasure);
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
 /// Converts an OpenXML table width value and its unit type to a corresponding TableMeasure object.
 /// </summary>
 /// <remarks>If the width type is Nil, the method returns a TableMeasure with the value "nil". If the width
 /// type is Auto, it returns a TableMeasure with the value "auto". For percentage widths, the value is suffixed with
 /// "%". For Dxa units, the value is used as-is.</remarks>
 /// <param name = "val">The string value representing the table width, which may be expressed in different units depending on the
 /// specified width type.</param>
 /// <param name = "widthType">The unit type that determines how the width value is interpreted. Supported types include Nil, Auto, Pct
 /// (percentage), and Dxa (twentieths of a point).</param>
 /// <returns>A TableMeasure object representing the converted width, or null if the width type is null or not recognized.</returns>
 public static TableMeasure? FromOpenXml(DX.StringValue? val, DX.EnumValue<DXW.TableWidthUnitValues>? widthType)
 {
  if (widthType == null)
   return null;
  if (widthType == DXW.TableWidthUnitValues.Nil)
   return new TableMeasure("nil");
  if (widthType == DXW.TableWidthUnitValues.Auto)
   return new TableMeasure("auto");
  var intVal = val?.Value != null ? Int64.Parse(val.Value) : 0;
  if (widthType == DXW.TableWidthUnitValues.Pct)
   return new TableMeasure(intVal, TableMeasureType.Relative);
  if (widthType == DXW.TableWidthUnitValues.Dxa)
   return new TableMeasure(intVal, TableMeasureType.Absolute);
  return null;
 }

 /// <summary>
 /// Converts the current table measurement to its OpenXML representation.
 /// </summary>
 /// <remarks>The width type is determined by converting the current measurement type to the corresponding
 /// OpenXML width unit value. If the conversion is not possible, the width type will be null.</remarks>
 /// <returns>A tuple containing the string value of the measurement and an optional width type as an OpenXML table width unit
 /// value.</returns>
 public (DX.StringValue val, DX.EnumValue<DXW.TableWidthUnitValues>? widthType) ToOpenXml()
 {
  var val = IntValue.ToString();
  DXW.TableWidthUnitValues widthType = EnumTypeConverter.ConvertTo<DXW.TableWidthUnitValues, TableMeasureType>(Type);
  return (val, widthType);
 }
#endregion
}