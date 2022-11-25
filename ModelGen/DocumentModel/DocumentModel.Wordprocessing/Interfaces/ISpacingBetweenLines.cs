namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SpacingBetweenLines Class.
/// </summary>
public interface ISpacingBetweenLines // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Spacing Above Paragraph
  /// </summary>
  public System.String? Before { get ; set; }
  
  /// <summary>
  /// Spacing Above Paragraph IN Line Units
  /// </summary>
  public System.Int32? BeforeLines { get ; set; }
  
  /// <summary>
  /// Automatically Determine Spacing Above Paragraph
  /// </summary>
  public System.Boolean? BeforeAutoSpacing { get ; set; }
  
  /// <summary>
  /// Spacing Below Paragraph
  /// </summary>
  public System.String? After { get ; set; }
  
  /// <summary>
  /// Spacing Below Paragraph in Line Units
  /// </summary>
  public System.Int32? AfterLines { get ; set; }
  
  /// <summary>
  /// Automatically Determine Spacing Below Paragraph
  /// </summary>
  public System.Boolean? AfterAutoSpacing { get ; set; }
  
  /// <summary>
  /// Spacing Between Lines in Paragraph
  /// </summary>
  public System.String? Line { get ; set; }
  
  /// <summary>
  /// Type of Spacing Between Lines
  /// </summary>
  public DocumentModel.Wordprocessing.LineSpacingRuleKind? LineRule { get ; set; }
  
}
