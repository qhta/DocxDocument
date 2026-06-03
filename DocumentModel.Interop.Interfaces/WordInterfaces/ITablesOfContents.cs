namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of TableOfContents objects that represent the tables of contents in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesofcontents?view=word-pia"/>
public interface ITablesOfContents : IInteropObject, IInteropCollection<ITableOfContents>
{
  /// <summary>
  /// Returns or sets the formatting for the tables of contents in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesofcontents.format?view=word-pia"/>
  public TocFormat Format { get; set; }


  #region methods

/// <summary>
  /// Adds a table of contents to the document using legacy options.
  /// </summary>
  /// <param name="range">The range where the table of contents is added.</param>
  /// <param name="useHeadingStyles">true to use heading styles; otherwise, false.</param>
  /// <param name="upperHeadingLevel">The highest heading level to include.</param>
  /// <param name="lowerHeadingLevel">The lowest heading level to include.</param>
  /// <param name="useFields">true to use TC fields; otherwise, false.</param>
  /// <param name="tableID">The identifier for the table of contents.</param>
  /// <param name="rightAlignPageNumbers">true to right-align page numbers; otherwise, false.</param>
  /// <param name="includePageNumbers">true to include page numbers; otherwise, false.</param>
  /// <param name="addedStyles">Additional styles to include in the table of contents.</param>
  /// <returns>The created <see cref="ITableOfContents"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesofcontents.addold?view=word-pia"/>
  public ITableOfContents AddOld(IRange range, bool useHeadingStyles, int upperHeadingLevel, int lowerHeadingLevel, 
    bool useFields, string tableID, bool rightAlignPageNumbers, bool includePageNumbers, string addedStyles);

  #endregion methods
}
