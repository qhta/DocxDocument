namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of PageNumber objects that represent the page numbers in a single header or footer.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers?view=word-pia"/>
public partial interface PageNumbers : InteropObject, InteropCollection<PageNumber>
{
  /// <summary>
  /// Returns or sets the number style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.numberstyle?view=word-pia"/>
  public WdPageNumberStyle NumberStyle { get; set; }

  /// <summary>
  /// Returns or sets whether include chapter number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.includechapternumber?view=word-pia"/>
  public bool IncludeChapterNumber { get; set; }

  /// <summary>
  /// Returns or sets the heading level for chapter.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.headinglevelforchapter?view=word-pia"/>
  public int HeadingLevelForChapter { get; set; }

  /// <summary>
  /// Returns or sets the chapter page separator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.chapterpageseparator?view=word-pia"/>
  public WdSeparatorType ChapterPageSeparator { get; set; }

  /// <summary>
  /// Returns or sets whether restart numbering at section.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.restartnumberingatsection?view=word-pia"/>
  public bool RestartNumberingAtSection { get; set; }

  /// <summary>
  /// Returns or sets the starting number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.startingnumber?view=word-pia"/>
  public int StartingNumber { get; set; }

  /// <summary>
  /// Returns or sets whether show first page number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.showfirstpagenumber?view=word-pia"/>
  public bool ShowFirstPageNumber { get; set; }

  /// <summary>
  /// Returns or sets whether double quote.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.doublequote?view=word-pia"/>
  public bool DoubleQuote { get; set; }
}
