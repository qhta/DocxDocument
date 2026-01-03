namespace DocumentModel.Wordprocessing;

/// <summary>
///   Suggested Filtering for List of Document Styles.
/// </summary>
public interface StylePaneFormatFilter: IModelElement
{
  /// <summary>
  ///   val
  /// </summary>
  public IHexChar? Val { get; set; }
  /// <summary>
  ///   allStyles
  /// </summary>
  public bool? AllStyles { get; set; }
  /// <summary>
  ///   customStyles
  /// </summary>
  public bool? CustomStyles { get; set; }
  /// <summary>
  ///   latentStyles
  /// </summary>
  public bool? LatentStyles { get; set; }
  /// <summary>
  ///   stylesInUse
  /// </summary>
  public bool? StylesInUse { get; set; }
  /// <summary>
  ///   headingStyles
  /// </summary>
  public bool? HeadingStyles { get; set; }
  /// <summary>
  ///   numberingStyles
  /// </summary>
  public bool? NumberingStyles { get; set; }
  /// <summary>
  ///   tableStyles
  /// </summary>
  public bool? TableStyles { get; set; }
  /// <summary>
  ///   directFormattingOnRuns
  /// </summary>
  public bool? DirectFormattingOnRuns { get; set; }
  /// <summary>
  ///   directFormattingOnParagraphs
  /// </summary>
  public bool? DirectFormattingOnParagraphs { get; set; }
  /// <summary>
  ///   directFormattingOnNumbering
  /// </summary>
  public bool? DirectFormattingOnNumbering { get; set; }
  /// <summary>
  ///   directFormattingOnTables
  /// </summary>
  public bool? DirectFormattingOnTables { get; set; }
  /// <summary>
  ///   clearFormatting
  /// </summary>
  public bool? ClearFormatting { get; set; }
  /// <summary>
  ///   top3HeadingStyles
  /// </summary>
  public bool? Top3HeadingStyles { get; set; }
  /// <summary>
  ///   visibleStyles
  /// </summary>
  public bool? VisibleStyles { get; set; }
  /// <summary>
  ///   alternateStyleNames
  /// </summary>
  public bool? AlternateStyleNames { get; set; }
}