namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of PageNumber objects that represent the page numbers in a single header or footer.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers?view=word-pia"/>
public interface IPageNumbers : IInteropObject, IInteropCollection<IPageNumber>
{
  /// <summary>
  /// Returns or sets the number style for the PageNumbers object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.numberstyle?view=word-pia"/>
  public PageNumberStyle NumberStyle { get; set; }

  /// <summary>
  /// True if a chapter number is included with page numbers or a caption label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.includechapternumber?view=word-pia"/>
  public bool IncludeChapterNumber { get; set; }

  /// <summary>
  /// Returns or sets the heading level style that's applied to the chapter titles in the document. Can be a number
  /// from 0 (zero) through 8, corresponding to heading levels 1 through 9.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.headinglevelforchapter?view=word-pia"/>
  public int HeadingLevelForChapter { get; set; }

  /// <summary>
  /// Returns or sets the separator character used between the chapter number and the page number. Can be one of the
  /// SeparatorType constants.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.chapterpageseparator?view=word-pia"/>
  public SeparatorType ChapterPageSeparator { get; set; }

  /// <summary>
  /// True if page numbering starts at 1 again at the beginning of the specified section.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.restartnumberingatsection?view=word-pia"/>
  public bool RestartNumberingAtSection { get; set; }

  /// <summary>
  /// Returns or sets the starting note number, line number, or page number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.startingnumber?view=word-pia"/>
  public int StartingNumber { get; set; }

  /// <summary>
  /// True if the page number appears on the first page in the section.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.showfirstpagenumber?view=word-pia"/>
  public bool ShowFirstPageNumber { get; set; }

  /// <summary>
  /// True if Microsoft Word encloses the specified PageNumbers object in double quotation marks (").
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.doublequote?view=word-pia"/>
  public bool DoubleQuote { get; set; }


  #region methods

/// <summary>
  /// Adds a page number to the document with the specified alignment and starting page option.
  /// </summary>
  /// <param name="PageNumberAlignment">Specifies the alignment of the page number. The value determines how the page number is positioned on the page.</param>
  /// <param name="FirstPage">Indicates whether the page number should be added to the first page. Set to <see langword="true"/> to include the
  /// page number on the first page; otherwise, <see langword="false"/>.</param>
  /// <returns>A <see cref="IPageNumber"/> object representing the added page number.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pagenumbers.add?view=word-pia"/>
  public IPageNumber Add(PageNumberAlignment PageNumberAlignment, bool FirstPage);

  #endregion methods
}
