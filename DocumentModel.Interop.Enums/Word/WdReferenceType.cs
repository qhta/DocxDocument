namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item to be cross referenced.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdreferencetype?view=office-pia` for Office interop details.
/// </remarks>
public enum ReferenceType
{
  /// <summary>
  /// Numbered item.
  /// </summary>
  NumberedItem = 0,
  /// <summary>
  /// Heading.
  /// </summary>
  Heading = 1,
  /// <summary>
  /// Bookmark.
  /// </summary>
  Bookmark = 2,
  /// <summary>
  /// Footnote.
  /// </summary>
  Footnote = 3,
  /// <summary>
  /// Endnote.
  /// </summary>
  Endnote = 4
}
