namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item to be cross referenced.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdreferencetype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdReferenceType")]
public enum ReferenceType
{
  /// <summary>
  /// Numbered item.
  /// </summary>
  [InteropEnumValue("wdRefTypeNumberedItem")]
  NumberedItem = 0,
  /// <summary>
  /// Heading.
  /// </summary>
  [InteropEnumValue("wdRefTypeHeading")]
  Heading = 1,
  /// <summary>
  /// Bookmark.
  /// </summary>
  [InteropEnumValue("wdRefTypeBookmark")]
  Bookmark = 2,
  /// <summary>
  /// Footnote.
  /// </summary>
  [InteropEnumValue("wdRefTypeFootnote")]
  Footnote = 3,
  /// <summary>
  /// Endnote.
  /// </summary>
  [InteropEnumValue("wdRefTypeEndnote")]
  Endnote = 4
}
