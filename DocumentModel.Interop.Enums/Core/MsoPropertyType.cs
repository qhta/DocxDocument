namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the data type for a document property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopropertytype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoMetaPropertyType))]
public enum MsoPropertyType
{
  /// <summary>
  /// Integer value. The property value is a whole number.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeBoolean))]
  Number = 1,
  /// <summary>
  /// Boolean value. The property value is either true or false.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeChoice))]
  Boolean = 2,
  /// <summary>
  /// Date value. The property value is a date and time.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeCalculated))]
  Date = 3,
  /// <summary>
  /// String value. The property value is a sequence of characters (text).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeComputed))]
  String = 4,
  /// <summary>
  /// Floating-point value.
  /// The property value is a number that can contain a fractional part, allowing for more precise representation of numerical data.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoMetaPropertyType.msoMetaPropertyTypeCurrency))]
  Float = 5,
}
