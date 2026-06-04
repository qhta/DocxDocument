    namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the data type for a document property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodocproperties?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoDocProperties")]
public enum MsoDocProperties
{
  /// <summary>
  /// Integer value.
  /// </summary>
  [InteropEnumValue("msoPropertyTypeNumber")]
  Number = 1,
  /// <summary>
  /// Boolean value.
  /// </summary>
  [InteropEnumValue("msoPropertyTypeBoolean")]
  Boolean,
  /// <summary>
  /// Date value.
  /// </summary>
  [InteropEnumValue("msoPropertyTypeDate")]
  Date,
  /// <summary>
  /// String value.
  /// </summary>
  [InteropEnumValue("msoPropertyTypeString")]
  String,
  /// <summary>
  /// Floating point value.
  /// </summary>
  [InteropEnumValue("msoPropertyTypeFloat")]
  Float
}
