namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of PageNumber objects that represent the page numbers in a single header or footer.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers?view=word-pia"/>
public partial interface PageNumbers : InteropObject, InteropCollection<PageNumber>
{
  /// <summary>
  /// The number style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.numberstyle?view=word-pia"/>
  public WdPageNumberStyle NumberStyle { get; set; }

  /// <summary>
  /// The include chapter number.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.includechapternumber?view=word-pia"/>
  public bool IncludeChapterNumber { get; set; }

  /// <summary>
  /// The heading level for chapter.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.headinglevelforchapter?view=word-pia"/>
  public int HeadingLevelForChapter { get; set; }

  /// <summary>
  /// The chapter page separator.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.chapterpageseparator?view=word-pia"/>
  public WdSeparatorType ChapterPageSeparator { get; set; }

  /// <summary>
  /// The restart numbering at section.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.restartnumberingatsection?view=word-pia"/>
  public bool RestartNumberingAtSection { get; set; }

  /// <summary>
  /// The starting number.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.startingnumber?view=word-pia"/>
  public int StartingNumber { get; set; }

  /// <summary>
  /// The show first page number.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.showfirstpagenumber?view=word-pia"/>
  public bool ShowFirstPageNumber { get; set; }

  /// <summary>
  /// The double quote.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.doublequote?view=word-pia"/>
  public bool DoubleQuote { get; set; }
}
