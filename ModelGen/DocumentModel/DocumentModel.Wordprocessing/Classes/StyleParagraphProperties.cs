namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Paragraph Properties.
/// </summary>
public class StyleParagraphProperties
{
  /// <summary>
  /// FrameProperties.
  /// </summary>
  public FrameProperties? FrameProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// NumberingProperties.
  /// </summary>
  public NumberingProperties? NumberingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ParagraphBorders.
  /// </summary>
  public ParagraphBorders? ParagraphBorders
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public Shading? Shading
  {
    get;
    set;
  }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  public Tabs? Tabs
  {
    get;
    set;
  }
  
  /// <summary>
  /// SpacingBetweenLines.
  /// </summary>
  public SpacingBetweenLines? SpacingBetweenLines
  {
    get;
    set;
  }
  
  /// <summary>
  /// Indentation.
  /// </summary>
  public Indentation? Indentation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Justification.
  /// </summary>
  public JustificationKind? Justification
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  public TextDirectionKind? TextDirection
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextAlignment.
  /// </summary>
  public VerticalTextAlignmentKind? TextAlignment
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextBoxTightWrap.
  /// </summary>
  public TextBoxTightWrapKind? TextBoxTightWrap
  {
    get;
    set;
  }
  
  /// <summary>
  /// ParagraphPropertiesChange.
  /// </summary>
  public ParagraphPropertiesChange? ParagraphPropertiesChange
  {
    get;
    set;
  }
  
}
