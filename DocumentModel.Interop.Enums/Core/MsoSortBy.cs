
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies sort order for files in a FileSearch object's FoundFiles collection.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosortby?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoSortBy))]
public enum SortBy
{
  /// <summary>
  /// File name.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSortBy.msoSortByFileName))]
  FileName = 1,
  /// <summary>
  /// File size.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSortBy.msoSortBySize))]
  Size,
  /// <summary>
  /// File type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSortBy.msoSortByFileType))]
  FileType,
  /// <summary>
  /// Last modified date.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSortBy.msoSortByLastModified))]
  LastModified,
  /// <summary>
  /// No sort.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSortBy.msoSortByNone))]
  None
}
