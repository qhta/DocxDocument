
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies sort order for files in a FileSearch object's FoundFiles collection.
/// </summary>
public enum MsoSortBy
{
  /// <summary>
  /// File name.
  /// </summary>
  FileName = 1,
  /// <summary>
  /// File size.
  /// </summary>
  Size,
  /// <summary>
  /// File type.
  /// </summary>
  FileType,
  /// <summary>
  /// Last modified date.
  /// </summary>
  LastModified,
  /// <summary>
  /// No sort.
  /// </summary>
  None
}
