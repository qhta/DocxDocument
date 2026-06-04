    namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the data type for a document property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodocproperties?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoDocProperties")]
public enum MsoDocProperties
{
  /// <summary>
  /// Integer value.
  /// </summary>
  [OfficeInteropEnumValue("msoPropertyTypeNumber")]
  Number = 1,
  /// <summary>
  /// Boolean value.
  /// </summary>
  [OfficeInteropEnumValue("msoPropertyTypeBoolean")]
  Boolean,
  /// <summary>
  /// Date value.
  /// </summary>
  [OfficeInteropEnumValue("msoPropertyTypeDate")]
  Date,
  /// <summary>
  /// String value.
  /// </summary>
  [OfficeInteropEnumValue("msoPropertyTypeString")]
  String,
  /// <summary>
  /// Floating point value.
  /// </summary>
  [OfficeInteropEnumValue("msoPropertyTypeFloat")]
  Float
}
