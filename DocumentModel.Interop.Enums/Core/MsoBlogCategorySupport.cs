namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoblogcategorysupport?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoBlogCategorySupport))]
public enum BlogCategorySupport
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBlogCategorySupport.msoBlogNoCategories))]
  NoCategories,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBlogCategorySupport.msoBlogOneCategory))]
  OneCategory,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBlogCategorySupport.msoBlogMultipleCategories))]
  MultipleCategories
}
