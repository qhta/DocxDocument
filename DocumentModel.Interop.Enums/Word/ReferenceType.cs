namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item to be cross referenced.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdreferencetype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdReferenceType")]
public enum ReferenceType
{
  /// <summary>
  /// Numbered item.
  /// </summary>
  [WordInteropEnumValue("wdRefTypeNumberedItem")]
  NumberedItem = 0,
  /// <summary>
  /// Heading.
  /// </summary>
  [WordInteropEnumValue("wdRefTypeHeading")]
  Heading = 1,
  /// <summary>
  /// Bookmark.
  /// </summary>
  [WordInteropEnumValue("wdRefTypeBookmark")]
  Bookmark = 2,
  /// <summary>
  /// Footnote.
  /// </summary>
  [WordInteropEnumValue("wdRefTypeFootnote")]
  Footnote = 3,
  /// <summary>
  /// Endnote.
  /// </summary>
  [WordInteropEnumValue("wdRefTypeEndnote")]
  Endnote = 4
}
