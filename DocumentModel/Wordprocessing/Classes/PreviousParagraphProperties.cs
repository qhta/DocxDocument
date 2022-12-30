namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Level Associated Paragraph Properties.
/// </summary>
public partial class PreviousParagraphProperties
{
  /// <summary>
  /// ParagraphStyleId.
  /// </summary>
  public String? ParagraphStyleId { get; set; }
  
  /// <summary>
  /// KeepNext.
  /// </summary>
  public Boolean? KeepNext { get; set; }
  
  /// <summary>
  /// KeepLines.
  /// </summary>
  public Boolean? KeepLines { get; set; }
  
  /// <summary>
  /// PageBreakBefore.
  /// </summary>
  public Boolean? PageBreakBefore { get; set; }
  
  /// <summary>
  /// FrameProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.FrameProperties? FrameProperties { get; set; }
  
  /// <summary>
  /// WidowControl.
  /// </summary>
  public Boolean? WidowControl { get; set; }
  
  /// <summary>
  /// NumberingProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.NumberingProperties? NumberingProperties { get; set; }
  
  /// <summary>
  /// SuppressLineNumbers.
  /// </summary>
  public Boolean? SuppressLineNumbers { get; set; }
  
  /// <summary>
  /// ParagraphBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.ParagraphBorders? ParagraphBorders { get; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.Shading? Shading { get; set; }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  public DocumentModel.Wordprocessing.Tabs? Tabs { get; set; }
  
  /// <summary>
  /// SuppressAutoHyphens.
  /// </summary>
  public Boolean? SuppressAutoHyphens { get; set; }
  
  /// <summary>
  /// Kinsoku.
  /// </summary>
  public Boolean? Kinsoku { get; set; }
  
  /// <summary>
  /// WordWrap.
  /// </summary>
  public Boolean? WordWrap { get; set; }
  
  /// <summary>
  /// OverflowPunctuation.
  /// </summary>
  public Boolean? OverflowPunctuation { get; set; }
  
  /// <summary>
  /// TopLinePunctuation.
  /// </summary>
  public Boolean? TopLinePunctuation { get; set; }
  
  /// <summary>
  /// AutoSpaceDE.
  /// </summary>
  public Boolean? AutoSpaceDE { get; set; }
  
  /// <summary>
  /// AutoSpaceDN.
  /// </summary>
  public Boolean? AutoSpaceDN { get; set; }
  
  /// <summary>
  /// BiDi.
  /// </summary>
  public Boolean? BiDi { get; set; }
  
  /// <summary>
  /// AdjustRightIndent.
  /// </summary>
  public Boolean? AdjustRightIndent { get; set; }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  public Boolean? SnapToGrid { get; set; }
  
  /// <summary>
  /// SpacingBetweenLines.
  /// </summary>
  public DocumentModel.Wordprocessing.SpacingBetweenLines? SpacingBetweenLines { get; set; }
  
  /// <summary>
  /// Indentation.
  /// </summary>
  public DocumentModel.Wordprocessing.Indentation? Indentation { get; set; }
  
  /// <summary>
  /// ContextualSpacing.
  /// </summary>
  public Boolean? ContextualSpacing { get; set; }
  
  /// <summary>
  /// MirrorIndents.
  /// </summary>
  public Boolean? MirrorIndents { get; set; }
  
  /// <summary>
  /// SuppressOverlap.
  /// </summary>
  public Boolean? SuppressOverlap { get; set; }
  
  /// <summary>
  /// Justification.
  /// </summary>
  public DocumentModel.Wordprocessing.JustificationKind? Justification { get; set; }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  public DocumentModel.Wordprocessing.TextDirectionKind? TextDirection { get; set; }
  
  /// <summary>
  /// TextAlignment.
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalTextAlignmentKind? TextAlignment { get; set; }
  
  /// <summary>
  /// TextBoxTightWrap.
  /// </summary>
  public DocumentModel.Wordprocessing.TextBoxTightWrapKind? TextBoxTightWrap { get; set; }
  
  /// <summary>
  /// OutlineLevel.
  /// </summary>
  public Int32? OutlineLevel { get; set; }
  
}
