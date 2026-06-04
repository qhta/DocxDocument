namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the data type for a document property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopropertytype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoMetaPropertyType")]
public enum MsoPropertyType
{
  /// <summary>
  /// Integer value. The property value is a whole number.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeBoolean")]
  Number = 1,
  /// <summary>
  /// Boolean value. The property value is either true or false.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeChoice")]
  Boolean = 2,
  /// <summary>
  /// Date value. The property value is a date and time.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeCalculated")]
  Date = 3,
  /// <summary>
  /// String value. The property value is a sequence of characters (text).
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeComputed")]
  String = 4,
  /// <summary>
  /// Floating-point value.
  /// The property value is a number that can contain a fractional part, allowing for more precise representation of numerical data.
  /// </summary>
  [InteropEnumValue("msoMetaPropertyTypeCurrency")]
  Float = 5,
}
