namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SpacingBetweenLines Class.
/// </summary>
public class SpacingBetweenLines: ModelElement
{
  /// <summary>
  ///   Spacing Above Paragraph
  /// </summary>
  public string? Before { get; set; }
  /// <summary>
  ///   Spacing Above Paragraph IN Line Units
  /// </summary>
  public Int32? BeforeLines { get; set; }
  /// <summary>
  ///   Automatically Determine Spacing Above Paragraph
  /// </summary>
  public bool? BeforeAutoSpacing { get; set; }
  /// <summary>
  ///   Spacing Below Paragraph
  /// </summary>
  public string? After { get; set; }
  /// <summary>
  ///   Spacing Below Paragraph in Line Units
  /// </summary>
  public Int32? AfterLines { get; set; }
  /// <summary>
  ///   Automatically Determine Spacing Below Paragraph
  /// </summary>
  public bool? AfterAutoSpacing { get; set; }
  /// <summary>
  ///   Spacing Between Lines in Paragraph
  /// </summary>
  public string? Line { get; set; }
  /// <summary>
  ///   Type of Spacing Between Lines
  /// </summary>
  public LineSpacingRuleKind? LineRule { get; set; }
}