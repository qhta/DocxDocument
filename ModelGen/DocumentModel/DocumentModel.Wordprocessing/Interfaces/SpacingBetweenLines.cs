namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SpacingBetweenLines Class.
/// </summary>
public interface SpacingBetweenLines // : System.Boolean
{
  /// <summary>
  /// Spacing Above Paragraph
  /// </summary>
  public String? Before { get ; set; }
  
  /// <summary>
  /// Spacing Above Paragraph IN Line Units
  /// </summary>
  public Int32? BeforeLines { get ; set; }
  
  /// <summary>
  /// Automatically Determine Spacing Above Paragraph
  /// </summary>
  public Boolean? BeforeAutoSpacing { get ; set; }
  
  /// <summary>
  /// Spacing Below Paragraph
  /// </summary>
  public String? After { get ; set; }
  
  /// <summary>
  /// Spacing Below Paragraph in Line Units
  /// </summary>
  public Int32? AfterLines { get ; set; }
  
  /// <summary>
  /// Automatically Determine Spacing Below Paragraph
  /// </summary>
  public Boolean? AfterAutoSpacing { get ; set; }
  
  /// <summary>
  /// Spacing Between Lines in Paragraph
  /// </summary>
  public String? Line { get ; set; }
  
  /// <summary>
  /// Type of Spacing Between Lines
  /// </summary>
  public LineSpacingRuleKind? LineRule { get ; set; }
  
}
