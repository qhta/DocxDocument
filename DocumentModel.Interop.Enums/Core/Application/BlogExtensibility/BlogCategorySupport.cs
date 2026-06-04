namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoblogcategorysupport?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoBlogCategorySupport")]
public enum BlogCategorySupport
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBlogNoCategories")]
  NoCategories,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBlogOneCategory")]
  OneCategory,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBlogMultipleCategories")]
  MultipleCategories
}
