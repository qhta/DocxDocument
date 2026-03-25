namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesofauthorities?view=word-pia"/>
public partial interface TablesOfAuthorities: InteropObject
{
  /// <summary>
  /// Adds a new table of authorities to the document.
  /// </summary>
  /// <param name="Range">The range where the table is added.</param>
  /// <param name="Category">The category of authorities to include.</param>
  /// <param name="Bookmark">The bookmark to use for the table.</param>
  /// <param name="Passim">true to use "passim" for multiple references; otherwise, false.</param>
  /// <param name="KeepEntryFormatting">true to keep entry formatting; otherwise, false.</param>
  /// <param name="Separator">The separator to use between entries.</param>
  /// <param name="IncludeSequenceName">The sequence name to include.</param>
  /// <param name="EntrySeparator">The separator to use between entries.</param>
  /// <param name="PageRangeSeparator">The separator to use for page ranges.</param>
  /// <param name="IncludeCategoryHeader">true to include the category header; otherwise, false.</param>
  /// <param name="PageNumberSeparator">The separator to use for page numbers.</param>
  /// <returns>The created <see cref="TableOfAuthorities"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablesofauthorities.add?view=word-pia"/>
  public TableOfAuthorities Add(Range Range, object Category, object Bookmark, bool Passim, bool KeepEntryFormatting, 
    string Separator, bool IncludeSequenceName, string EntrySeparator, string PageRangeSeparator, 
    bool IncludeCategoryHeader, string PageNumberSeparator);
}
