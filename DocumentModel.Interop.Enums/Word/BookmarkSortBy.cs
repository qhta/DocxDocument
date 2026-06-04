namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the sorting option for bookmark names displayed in the Bookmark dialog box.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbookmarksortby?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdBookmarkSortBy))]
public enum BookmarkSortBy
{
  /// <summary>
  /// Sorted by bookmark name.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBookmarkSortBy.wdSortByName))]
  Name = 0,
  /// <summary>
  /// Sorted by location in document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBookmarkSortBy.wdSortByLocation))]
  Location = 1
}
