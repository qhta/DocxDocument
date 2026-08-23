namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of PageNumber objects that represent the page numbers in a single header or footer.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers?view=word-pia"/>
public partial interface IPageNumbers : IModelCollection<IPageNumber>
{
  /// <summary>
  /// Returns or sets the number style for the PageNumbers object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.numberstyle?view=word-pia"/>
  public PageNumberStyle NumberStyle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if a chapter number is included with page numbers or a caption label.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.includechapternumber?view=word-pia"/>
  public bool IncludeChapterNumber { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the heading level style that's applied to the chapter titles in the document. Can be a number
  /// from 0 (zero) through 8, corresponding to heading levels 1 through 9.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.headinglevelforchapter?view=word-pia"/>
  public int HeadingLevelForChapter { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the separator character used between the chapter number and the page number. Can be one of the
  /// SeparatorType constants.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.chapterpageseparator?view=word-pia"/>
  public SeparatorType ChapterPageSeparator { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if page numbering starts at 1 again at the beginning of the specified section.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.restartnumberingatsection?view=word-pia"/>
  public bool RestartNumberingAtSection { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the starting note number, line number, or page number.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.startingnumber?view=word-pia"/>
  public int StartingNumber { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if the page number appears on the first page in the section.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.showfirstpagenumber?view=word-pia"/>
  public bool ShowFirstPageNumber { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if Microsoft Word encloses the specified PageNumbers object in double quotation marks (").
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.doublequote?view=word-pia"/>
  public bool DoubleQuote { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
