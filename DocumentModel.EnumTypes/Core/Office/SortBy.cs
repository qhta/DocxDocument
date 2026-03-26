
namespace DocumentMode.Office;

/// <summary>
/// Specifies sort order for files in a FileSearch object's FoundFiles collection.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosortby?view=office-pia` for Office interop details.
/// </remarks>
public enum SortBy
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
