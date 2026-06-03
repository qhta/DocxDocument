namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of TableOfAuthorities objects (TOA fields) that represents the tables of authorities in a
/// document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesofauthorities?view=word-pia"/>
public interface ITablesOfAuthorities : IInteropObject, IInteropCollection<ITableOfAuthorities>
{
  /// <summary>
  /// Returns or sets the formatting for the tables of authorities in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesofauthorities.format?view=word-pia"/>
  public ToaFormat Format { get; set; }


  #region methods

/// <summary>
  /// Adds a new table of authorities to the document.
  /// </summary>
  /// <param name="range">The range where the table is added.</param>
  /// <param name="category">The category of authorities to include.</param>
  /// <param name="bookmark">The bookmark to use for the table.</param>
  /// <param name="passim">true to use "passim" for multiple references; otherwise, false.</param>
  /// <param name="keepEntryFormatting">true to keep entry formatting; otherwise, false.</param>
  /// <param name="separator">The separator to use between entries.</param>
  /// <param name="includeSequenceName">The sequence name to include.</param>
  /// <param name="entrySeparator">The separator to use between entries.</param>
  /// <param name="pageRangeSeparator">The separator to use for page ranges.</param>
  /// <param name="includeCategoryHeader">true to include the category header; otherwise, false.</param>
  /// <param name="pageNumberSeparator">The separator to use for page numbers.</param>
  /// <returns>The created <see cref="ITableOfAuthorities"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesofauthorities.add?view=word-pia"/>
  public ITableOfAuthorities Add(IRange range, object category, object bookmark, bool passim, bool keepEntryFormatting, 
    string separator, bool includeSequenceName, string entrySeparator, string pageRangeSeparator, 
    bool includeCategoryHeader, string pageNumberSeparator);

  #endregion methods
}
