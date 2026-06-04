namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoblogcategorysupport?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoBlogCategorySupport")]
public enum BlogCategorySupport
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBlogNoCategories")]
  NoCategories,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBlogOneCategory")]
  OneCategory,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBlogMultipleCategories")]
  MultipleCategories
}
