
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies sort order for files in a FileSearch object's FoundFiles collection.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosortby?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoSortBy")]
public enum SortBy
{
  /// <summary>
  /// File name.
  /// </summary>
  [InteropEnumValue("msoSortByFileName")]
  FileName = 1,
  /// <summary>
  /// File size.
  /// </summary>
  [InteropEnumValue("msoSortBySize")]
  Size,
  /// <summary>
  /// File type.
  /// </summary>
  [InteropEnumValue("msoSortByFileType")]
  FileType,
  /// <summary>
  /// Last modified date.
  /// </summary>
  [InteropEnumValue("msoSortByLastModified")]
  LastModified,
  /// <summary>
  /// No sort.
  /// </summary>
  [InteropEnumValue("msoSortByNone")]
  None
}
