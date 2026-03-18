namespace DocumentModel.Interop;

/// <summary>
/// Represents a single index.
/// </summary>
public partial interface Index : InteropObject
{
  /// <summary>
  /// The heading separator.
  /// </summary>
  public WdHeadingSeparator HeadingSeparator { get; set; }

  /// <summary>
  /// The right align page numbers.
  /// </summary>
  public bool RightAlignPageNumbers { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  public WdIndexType Type { get; set; }

  /// <summary>
  /// The number of columns.
  /// </summary>
  public int NumberOfColumns { get; set; }

  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The tab leader.
  /// </summary>
  public WdTabLeader TabLeader { get; set; }

  /// <summary>
  /// The accented letters.
  /// </summary>
  public bool AccentedLetters { get; set; }

  /// <summary>
  /// The sort by.
  /// </summary>
  public WdIndexSortBy SortBy { get; set; }

  /// <summary>
  /// The filter.
  /// </summary>
  public WdIndexFilter Filter { get; set; }

  /// <summary>
  /// The index language.
  /// </summary>
  public WdLanguageID IndexLanguage { get; set; }
}
