namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single index.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index?view=word-pia"/>
public partial interface Index : InteropObject
{
  /// <summary>
  /// The heading separator.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.headingseparator?view=word-pia"/>
  public WdHeadingSeparator HeadingSeparator { get; set; }

  /// <summary>
  /// The right align page numbers.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.rightalignpagenumbers?view=word-pia"/>
  public bool RightAlignPageNumbers { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.type?view=word-pia"/>
  public WdIndexType Type { get; set; }

  /// <summary>
  /// The number of columns.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.numberofcolumns?view=word-pia"/>
  public int NumberOfColumns { get; set; }

  /// <summary>
  /// The range.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The tab leader.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.tableader?view=word-pia"/>
  public WdTabLeader TabLeader { get; set; }

  /// <summary>
  /// The accented letters.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.accentedletters?view=word-pia"/>
  public bool AccentedLetters { get; set; }

  /// <summary>
  /// The sort by.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.sortby?view=word-pia"/>
  public WdIndexSortBy SortBy { get; set; }

  /// <summary>
  /// The filter.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.filter?view=word-pia"/>
  public WdIndexFilter Filter { get; set; }

  /// <summary>
  /// The index language.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.indexlanguage?view=word-pia"/>
  public WdLanguageID IndexLanguage { get; set; }
}
