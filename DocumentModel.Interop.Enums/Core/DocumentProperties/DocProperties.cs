
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.docproperties?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.DocProperties")]
public enum DocProperties
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("offPropertyTypeNumber")]
  Number = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("offPropertyTypeBoolean")]
  Boolean,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("offPropertyTypeDate")]
  Date,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("offPropertyTypeString")]
  String,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("offPropertyTypeFloat")]
  Float
}
