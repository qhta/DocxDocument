
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies sort order for files in a FileSearch object's FoundFiles collection.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosortby?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoSortBy")]
public enum SortBy
{
  /// <summary>
  /// File name.
  /// </summary>
  [OfficeInteropEnumValue("msoSortByFileName")]
  FileName = 1,
  /// <summary>
  /// File size.
  /// </summary>
  [OfficeInteropEnumValue("msoSortBySize")]
  Size,
  /// <summary>
  /// File type.
  /// </summary>
  [OfficeInteropEnumValue("msoSortByFileType")]
  FileType,
  /// <summary>
  /// Last modified date.
  /// </summary>
  [OfficeInteropEnumValue("msoSortByLastModified")]
  LastModified,
  /// <summary>
  /// No sort.
  /// </summary>
  [OfficeInteropEnumValue("msoSortByNone")]
  None
}
