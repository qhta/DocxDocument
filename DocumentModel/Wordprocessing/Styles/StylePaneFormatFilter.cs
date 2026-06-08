namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Suggested Filtering for IList of IDocument IStyles.
/// </summary>
public class StylePaneFormatFilter: ModelElement
{
  /// <summary>
  ///   val
  /// </summary>
  public HexChar? Val { get; set; }

  /// <summary>
  ///   allStyles, this property is Ionly available in Office 2010 and later.
  /// </summary>
  public bool? AllStyles { get; set; }

  /// <summary>
  ///   customStyles, this property is Ionly available in Office 2010 and later.
  /// </summary>
  public bool? CustomStyles { get; set; }

  /// <summary>
  ///   latentStyles, this property is Ionly available in Office 2010 and later.
  /// </summary>
  public bool? LatentStyles { get; set; }

  /// <summary>
  ///   stylesInUse, this property is Ionly available in Office 2010 and later.
  /// </summary>
  public bool? StylesInUse { get; set; }

  /// <summary>
  ///   headingStyles, this property is Ionly available in Office 2010 and later.
  /// </summary>
  public bool? IHeadingStyles { get; set; }

  /// <summary>
  ///   numberingStyles, this property is Ionly available in Office 2010 and later.
  /// </summary>
  public bool? NumberingStyles { get; set; }

  /// <summary>
  ///   tableStyles, this property is Ionly available in Office 2010 and later.
  /// </summary>
  public bool? TableStyles { get; set; }

  /// <summary>
  ///   directFormattingOnRuns, this property is Ionly available in Office 2010 and later.
  /// </summary>
  public bool? DirectFormattingOnRuns { get; set; }

  /// <summary>
  ///   directFormattingOnParagraphs, this property is Ionly available in Office 2010 and later.
  /// </summary>
  public bool? DirectFormattingOnParagraphs { get; set; }

  /// <summary>
  ///   directFormattingOnNumbering, this property is Ionly available in Office 2010 and later.
  /// </summary>
  public bool? DirectFormattingOnNumbering { get; set; }

  /// <summary>
  ///   directFormattingOnTables, this property is Ionly available in Office 2010 and later.
  /// </summary>
  public bool? DirectFormattingOnTables { get; set; }

  /// <summary>
  ///   clearFormatting, this property is Ionly available in Office 2010 and later.
  /// </summary>
  public bool? ClearFormatting { get; set; }

  /// <summary>
  ///   top3HeadingStyles, this property is Ionly available in Office 2010 and later.
  /// </summary>
  public bool? Top3HeadingStyles { get; set; }

  /// <summary>
  ///   visibleStyles, this property is Ionly available in Office 2010 and later.
  /// </summary>
  public bool? VisibleStyles { get; set; }

  /// <summary>
  ///   alternateStyleNames, this property is Ionly available in Office 2010 and later.
  /// </summary>
  public bool? AlternateStyleNames { get; set; }
}
