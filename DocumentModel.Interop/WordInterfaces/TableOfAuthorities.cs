namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single table of authorities in a document (a TOA field).
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities?view=word-pia"/>
public partial interface TableOfAuthorities : InteropObject
{
  /// <summary>
  /// Returns or sets whether passim.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.passim?view=word-pia"/>
  public bool Passim { get; set; }

  /// <summary>
  /// Returns or sets whether keep entry formatting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.keepentryformatting?view=word-pia"/>
  public bool KeepEntryFormatting { get; set; }

  /// <summary>
  /// Returns or sets the category.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.category?view=word-pia"/>
  public int Category { get; set; }

  /// <summary>
  /// Returns or sets the bookmark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.bookmark?view=word-pia"/>
  public string Bookmark { get; set; }

  /// <summary>
  /// Returns or sets the separator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.separator?view=word-pia"/>
  public string Separator { get; set; }

  /// <summary>
  /// Returns or sets the include sequence name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.includesequencename?view=word-pia"/>
  public string IncludeSequenceName { get; set; }

  /// <summary>
  /// Returns or sets the entry separator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.entryseparator?view=word-pia"/>
  public string EntrySeparator { get; set; }

  /// <summary>
  /// Returns or sets the page range separator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.pagerangeseparator?view=word-pia"/>
  public string PageRangeSeparator { get; set; }

  /// <summary>
  /// Returns or sets whether include category header.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.includecategoryheader?view=word-pia"/>
  public bool IncludeCategoryHeader { get; set; }

  /// <summary>
  /// Returns or sets the page number separator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.pagenumberseparator?view=word-pia"/>
  public string PageNumberSeparator { get; set; }

  /// <summary>
  /// Returns the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns or sets the tab leader.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.tableader?view=word-pia"/>
  public WdTabLeader TabLeader { get; set; }
}
