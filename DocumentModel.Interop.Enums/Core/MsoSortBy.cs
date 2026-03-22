
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies sort order for files in a FileSearch object's FoundFiles collection.
/// </summary>
public enum MsoSortBy
{
  /// <summary>
  /// File name.
  /// </summary>
  msoSortByFileName = 1,
  /// <summary>
  /// File size.
  /// </summary>
  msoSortBySize,
  /// <summary>
  /// File type.
  /// </summary>
  msoSortByFileType,
  /// <summary>
  /// Last modified date.
  /// </summary>
  msoSortByLastModified,
  /// <summary>
  /// No sort.
  /// </summary>
  msoSortByNone
}
