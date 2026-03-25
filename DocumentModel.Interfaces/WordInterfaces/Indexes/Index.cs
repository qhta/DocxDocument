namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single index.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index?view=word-pia"/>
public partial interface Index : InteropObject
{
  /// <summary>
  /// Returns or sets the character that separates topic headings and page numbers in an index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.headingseparator?view=word-pia"/>
  public WdHeadingSeparator HeadingSeparator { get; set; }

  /// <summary>
  /// Returns or sets whether page numbers are right-aligned in the index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.rightalignpagenumbers?view=word-pia"/>
  public bool RightAlignPageNumbers { get; set; }

  /// <summary>
  /// Returns or sets the type of index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.type?view=word-pia"/>
  public WdIndexType Type { get; set; }

  /// <summary>
  /// Returns or sets the number of columns in the index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.numberofcolumns?view=word-pia"/>
  public int NumberOfColumns { get; set; }

  /// <summary>
  /// Returns a range object that represents the portion of the document included in the index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns or sets the tab leader character between entries and page numbers in the index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.tableader?view=word-pia"/>
  public WdTabLeader TabLeader { get; set; }

  /// <summary>
  /// Returns or sets whether accented letters are treated separately in index sorting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.accentedletters?view=word-pia"/>
  public bool AccentedLetters { get; set; }

  /// <summary>
  /// Returns or sets how index entries are sorted.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.sortby?view=word-pia"/>
  public WdIndexSortBy SortBy { get; set; }

  /// <summary>
  /// Returns or sets the type of index filter to apply.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.filter?view=word-pia"/>
  public WdIndexFilter Filter { get; set; }

  /// <summary>
  /// Returns or sets the language used for sorting the index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.indexlanguage?view=word-pia"/>
  public WdLanguageID IndexLanguage { get; set; }
}
