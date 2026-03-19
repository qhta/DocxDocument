namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single table of authorities in a document (a TOA field).
/// </summary>
public partial interface TableOfAuthorities : InteropObject
{
  /// <summary>
  /// The passim.
  /// </summary>
  public bool Passim { get; set; }

  /// <summary>
  /// The keep entry formatting.
  /// </summary>
  public bool KeepEntryFormatting { get; set; }

  /// <summary>
  /// The category.
  /// </summary>
  public int Category { get; set; }

  /// <summary>
  /// The bookmark.
  /// </summary>
  public string Bookmark { get; set; }

  /// <summary>
  /// The separator.
  /// </summary>
  public string Separator { get; set; }

  /// <summary>
  /// The include sequence name.
  /// </summary>
  public string IncludeSequenceName { get; set; }

  /// <summary>
  /// The entry separator.
  /// </summary>
  public string EntrySeparator { get; set; }

  /// <summary>
  /// The page range separator.
  /// </summary>
  public string PageRangeSeparator { get; set; }

  /// <summary>
  /// The include category header.
  /// </summary>
  public bool IncludeCategoryHeader { get; set; }

  /// <summary>
  /// The page number separator.
  /// </summary>
  public string PageNumberSeparator { get; set; }

  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The tab leader.
  /// </summary>
  public WdTabLeader TabLeader { get; set; }
}
