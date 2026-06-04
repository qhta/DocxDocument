
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.docproperties?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("DocProperties")]
public enum DocProperties
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("offPropertyTypeNumber")]
  Number = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("offPropertyTypeBoolean")]
  Boolean,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("offPropertyTypeDate")]
  Date,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("offPropertyTypeString")]
  String,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("offPropertyTypeFloat")]
  Float
}
