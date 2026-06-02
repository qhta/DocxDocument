namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of TableOfContents objects that represent the tables of contents in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesofcontents?view=word-pia"/>
public partial interface ITablesOfContents : IInteropObject, IInteropCollection<TableOfContents>
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
  /// <param name="Range">The range where the table of contents is added.</param>
  /// <param name="UseHeadingStyles">true to use heading styles; otherwise, false.</param>
  /// <param name="UpperHeadingLevel">The highest heading level to include.</param>
  /// <param name="LowerHeadingLevel">The lowest heading level to include.</param>
  /// <param name="UseFields">true to use TC fields; otherwise, false.</param>
  /// <param name="TableID">The identifier for the table of contents.</param>
  /// <param name="RightAlignPageNumbers">true to right-align page numbers; otherwise, false.</param>
  /// <param name="IncludePageNumbers">true to include page numbers; otherwise, false.</param>
  /// <param name="AddedStyles">Additional styles to include in the table of contents.</param>
  /// <returns>The created <see cref="TableOfContents"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesofcontents.addold?view=word-pia"/>
  public TableOfContents AddOld(Range Range, bool UseHeadingStyles, int UpperHeadingLevel, int LowerHeadingLevel, 
    bool UseFields, string TableID, bool RightAlignPageNumbers, bool IncludePageNumbers, string AddedStyles);

  #endregion methods
}
