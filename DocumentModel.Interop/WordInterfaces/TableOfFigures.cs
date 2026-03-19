namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single table of figures in a document.
/// </summary>
public partial interface TableOfFigures : InteropObject
{
  /// <summary>
  /// The caption.
  /// </summary>
  public string Caption { get; set; }

  /// <summary>
  /// The include label.
  /// </summary>
  public bool IncludeLabel { get; set; }

  /// <summary>
  /// The right align page numbers.
  /// </summary>
  public bool RightAlignPageNumbers { get; set; }

  /// <summary>
  /// The use heading styles.
  /// </summary>
  public bool UseHeadingStyles { get; set; }

  /// <summary>
  /// The lower heading level.
  /// </summary>
  public int LowerHeadingLevel { get; set; }

  /// <summary>
  /// The upper heading level.
  /// </summary>
  public int UpperHeadingLevel { get; set; }

  /// <summary>
  /// The include page numbers.
  /// </summary>
  public bool IncludePageNumbers { get; set; }

  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The use fields.
  /// </summary>
  public bool UseFields { get; set; }

  /// <summary>
  /// The table id.
  /// </summary>
  public string TableID { get; set; }

  /// <summary>
  /// The heading styles.
  /// </summary>
  public HeadingStyles HeadingStyles { get; }

  /// <summary>
  /// The tab leader.
  /// </summary>
  public WdTabLeader TabLeader { get; set; }

  /// <summary>
  /// The use hyperlinks.
  /// </summary>
  public bool UseHyperlinks { get; set; }

  /// <summary>
  /// The hide page numbers in web.
  /// </summary>
  public bool HidePageNumbersInWeb { get; set; }
}
