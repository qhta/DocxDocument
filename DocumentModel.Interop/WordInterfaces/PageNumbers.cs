namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of PageNumber objects that represent the page numbers in a single header or footer.
/// </summary>
public partial interface PageNumbers : InteropObject, InteropCollection<PageNumber>
{
  /// <summary>
  /// The number style.
  /// </summary>
  public WdPageNumberStyle NumberStyle { get; set; }

  /// <summary>
  /// The include chapter number.
  /// </summary>
  public bool IncludeChapterNumber { get; set; }

  /// <summary>
  /// The heading level for chapter.
  /// </summary>
  public int HeadingLevelForChapter { get; set; }

  /// <summary>
  /// The chapter page separator.
  /// </summary>
  public WdSeparatorType ChapterPageSeparator { get; set; }

  /// <summary>
  /// The restart numbering at section.
  /// </summary>
  public bool RestartNumberingAtSection { get; set; }

  /// <summary>
  /// The starting number.
  /// </summary>
  public int StartingNumber { get; set; }

  /// <summary>
  /// The show first page number.
  /// </summary>
  public bool ShowFirstPageNumber { get; set; }

  /// <summary>
  /// The double quote.
  /// </summary>
  public bool DoubleQuote { get; set; }
}
