namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item to be cross referenced.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdreferencetype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdReferenceType))]
public enum ReferenceType
{
  /// <summary>
  /// Numbered item.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdReferenceType.wdRefTypeNumberedItem))]
  NumberedItem = 0,
  /// <summary>
  /// Heading.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdReferenceType.wdRefTypeHeading))]
  Heading = 1,
  /// <summary>
  /// Bookmark.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdReferenceType.wdRefTypeBookmark))]
  Bookmark = 2,
  /// <summary>
  /// Footnote.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdReferenceType.wdRefTypeFootnote))]
  Footnote = 3,
  /// <summary>
  /// Endnote.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdReferenceType.wdRefTypeEndnote))]
  Endnote = 4
}
