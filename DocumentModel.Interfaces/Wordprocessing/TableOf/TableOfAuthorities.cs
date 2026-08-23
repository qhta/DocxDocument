namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single table of authorities in a document (a TOA field).
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities?view=word-pia"/>
public partial interface ITableOfAuthorities : IModelObject
{
  /// <summary>
  /// True if five or more page references to the same authority are replaced with "Passim."
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.passim?view=word-pia"/>
  public bool Passim { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if formatting from table of authorities entries is applied to the entries in the specified table of
  /// authorities.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.keepentryformatting?view=word-pia"/>
  public bool KeepEntryFormatting { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the category of entries to be included in a table of authorities.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.category?view=word-pia"/>
  public int Category { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the name of the bookmark from which to collect table of authorities entries.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.bookmark?view=word-pia"/>
  public string Bookmark { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the characters (up to five) between the sequence number and the page number.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.separator?view=word-pia"/>
  public string Separator { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the Sequence (SEQ) field identifier for a table of authorities.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.includesequencename?view=word-pia"/>
  public string IncludeSequenceName { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the characters (up to five) that separate a table of authorities entry and its page number.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.entryseparator?view=word-pia"/>
  public string EntrySeparator { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the characters (up to five) that separate a range of pages in a table of authorities.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.pagerangeseparator?view=word-pia"/>
  public string PageRangeSeparator { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if the category name for a group of entries appears in the table of authorities.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.includecategoryheader?view=word-pia"/>
  public bool IncludeCategoryHeader { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns of sets the characters (up to five) that separate individual page references in a table of
  /// authorities.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.pagenumberseparator?view=word-pia"/>
  public string PageNumberSeparator { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a Range object that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.range?view=word-pia"/>
  public IRange Range { get; }

  /// <summary>
  /// Returns or sets the character between entries and their page numbers in a table of authorities.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthorities.tableader?view=word-pia"/>
  public TabLeader TabLeader { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
