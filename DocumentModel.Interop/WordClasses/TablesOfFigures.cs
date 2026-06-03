namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of TableOfFigures objects that represent the tables of figures in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesoffigures?view=word-pia"/>
public partial class TablesOfFigures : InteropCollection<TableOfFigures>
{
  /// <summary>
  /// Returns or sets the formatting for the tables of figures in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesoffigures.format?view=word-pia"/>
  public TofFormat Format { get; set; }


  #region methods

/// <summary>
  /// Adds a table of figures to the document using legacy options.
  /// </summary>
  /// <param name="range">The range where the table of figures is added.</param>
  /// <param name="caption">The caption label to include in the table.</param>
  /// <param name="includeLabel">true to include the label; otherwise, false.</param>
  /// <param name="useHeadingStyles">true to use heading styles; otherwise, false.</param>
  /// <param name="upperHeadingLevel">The highest heading level to include.</param>
  /// <param name="lowerHeadingLevel">The lowest heading level to include.</param>
  /// <param name="useFields">true to use TC fields; otherwise, false.</param>
  /// <param name="tableID">The identifier for the table of figures.</param>
  /// <param name="rightAlignPageNumbers">true to right-align page numbers; otherwise, false.</param>
  /// <param name="includePageNumbers">true to include page numbers; otherwise, false.</param>
  /// <param name="addedStyles">Additional styles to include in the table of figures.</param>
  /// <returns>The created <see cref="TableOfFigures"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesoffigures.addold?view=word-pia"/>
  public TableOfFigures AddOld(Range range, string caption, bool includeLabel, bool useHeadingStyles, 
    int upperHeadingLevel, int lowerHeadingLevel, bool useFields, string tableID, 
    bool rightAlignPageNumbers, bool includePageNumbers, string addedStyles)
  {
    throw new NotImplementedException();
  }

  #endregion methods
}
