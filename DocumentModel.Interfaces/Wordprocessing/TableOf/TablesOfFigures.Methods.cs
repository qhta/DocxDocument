namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesoffigures?view=word-pia"/>
public partial interface ITablesOfFigures: IModelObject
{
  /// <summary>
  /// Adds a table of figures to the document using legacy options.
  /// </summary>
  /// <param name="Range">The range where the table of figures is added.</param>
  /// <param name="Caption">The caption label to include in the table.</param>
  /// <param name="IncludeLabel">true to include the label; otherwise, false.</param>
  /// <param name="UseHeadingStyles">true to use heading styles; otherwise, false.</param>
  /// <param name="UpperHeadingLevel">The highest heading level to include.</param>
  /// <param name="LowerHeadingLevel">The lowest heading level to include.</param>
  /// <param name="UseFields">true to use TC fields; otherwise, false.</param>
  /// <param name="TableID">The identifier for the table of figures.</param>
  /// <param name="RightAlignPageNumbers">true to right-align page numbers; otherwise, false.</param>
  /// <param name="IncludePageNumbers">true to include page numbers; otherwise, false.</param>
  /// <param name="AddedStyles">Additional styles to include in the table of figures.</param>
  /// <returns>The created <see cref="ITableOfFigures"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesoffigures.addold?view=word-pia"/>
  public ITableOfFigures AddOld(IRange Range, string Caption, bool IncludeLabel, bool UseHeadingStyles, 
    int UpperHeadingLevel, int LowerHeadingLevel, bool UseFields, string TableID, 
    bool RightAlignPageNumbers, bool IncludePageNumbers, string AddedStyles);
}
