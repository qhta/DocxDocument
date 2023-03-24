namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Suggested Filtering for List of Document Styles.
/// </summary>
public class StylePaneFormatFilter: ModelElement
{
  /// <summary>
  ///   val
  /// </summary>
  public HexChar? Val { get; set; }

  /// <summary>
  ///   allStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? AllStyles { get; set; }

  /// <summary>
  ///   customStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? CustomStyles { get; set; }

  /// <summary>
  ///   latentStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? LatentStyles { get; set; }

  /// <summary>
  ///   stylesInUse, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? StylesInUse { get; set; }

  /// <summary>
  ///   headingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? HeadingStyles { get; set; }

  /// <summary>
  ///   numberingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NumberingStyles { get; set; }

  /// <summary>
  ///   tableStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? TableStyles { get; set; }

  /// <summary>
  ///   directFormattingOnRuns, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? DirectFormattingOnRuns { get; set; }

  /// <summary>
  ///   directFormattingOnParagraphs, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? DirectFormattingOnParagraphs { get; set; }

  /// <summary>
  ///   directFormattingOnNumbering, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? DirectFormattingOnNumbering { get; set; }

  /// <summary>
  ///   directFormattingOnTables, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? DirectFormattingOnTables { get; set; }

  /// <summary>
  ///   clearFormatting, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ClearFormatting { get; set; }

  /// <summary>
  ///   top3HeadingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Top3HeadingStyles { get; set; }

  /// <summary>
  ///   visibleStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? VisibleStyles { get; set; }

  /// <summary>
  ///   alternateStyleNames, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? AlternateStyleNames { get; set; }
}