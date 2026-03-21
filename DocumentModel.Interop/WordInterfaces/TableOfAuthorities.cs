namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single table of authorities in a document (a TOA field).
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities?view=word-pia"/>
public partial interface TableOfAuthorities : InteropObject
{
  /// <summary>
  /// The passim.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.passim?view=word-pia"/>
  public bool Passim { get; set; }

  /// <summary>
  /// The keep entry formatting.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.keepentryformatting?view=word-pia"/>
  public bool KeepEntryFormatting { get; set; }

  /// <summary>
  /// The category.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.category?view=word-pia"/>
  public int Category { get; set; }

  /// <summary>
  /// The bookmark.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.bookmark?view=word-pia"/>
  public string Bookmark { get; set; }

  /// <summary>
  /// The separator.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.separator?view=word-pia"/>
  public string Separator { get; set; }

  /// <summary>
  /// The include sequence name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.includesequencename?view=word-pia"/>
  public string IncludeSequenceName { get; set; }

  /// <summary>
  /// The entry separator.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.entryseparator?view=word-pia"/>
  public string EntrySeparator { get; set; }

  /// <summary>
  /// The page range separator.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.pagerangeseparator?view=word-pia"/>
  public string PageRangeSeparator { get; set; }

  /// <summary>
  /// The include category header.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.includecategoryheader?view=word-pia"/>
  public bool IncludeCategoryHeader { get; set; }

  /// <summary>
  /// The page number separator.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.pagenumberseparator?view=word-pia"/>
  public string PageNumberSeparator { get; set; }

  /// <summary>
  /// The range.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The tab leader.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.tableader?view=word-pia"/>
  public WdTabLeader TabLeader { get; set; }
}
