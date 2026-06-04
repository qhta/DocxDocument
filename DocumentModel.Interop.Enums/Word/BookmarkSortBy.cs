namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the sorting option for bookmark names displayed in the Bookmark dialog box.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbookmarksortby?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdBookmarkSortBy")]
public enum BookmarkSortBy
{
  /// <summary>
  /// Sorted by bookmark name.
  /// </summary>
  [WordInteropEnumValue("wdSortByName")]
  Name = 0,
  /// <summary>
  /// Sorted by location in document.
  /// </summary>
  [WordInteropEnumValue("wdSortByLocation")]
  Location = 1
}
