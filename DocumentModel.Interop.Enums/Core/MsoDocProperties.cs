    namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the data type for a document property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodocproperties?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoDocProperties))]
public enum MsoDocProperties
{
  /// <summary>
  /// Integer value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeNumber))]
  Number = 1,
  /// <summary>
  /// Boolean value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeBoolean))]
  Boolean,
  /// <summary>
  /// Date value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeDate))]
  Date,
  /// <summary>
  /// String value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeString))]
  String,
  /// <summary>
  /// Floating point value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeFloat))]
  Float
}
