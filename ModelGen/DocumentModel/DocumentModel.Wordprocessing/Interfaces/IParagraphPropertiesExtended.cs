namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Paragraph Properties.
/// </summary>
public interface IParagraphPropertiesExtended // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ParagraphStyleId.
  /// </summary>
  public System.String? ParagraphStyleId { get ; set; }
  
  /// <summary>
  /// KeepNext.
  /// </summary>
  public System.Boolean? KeepNext { get ; set; }
  
  /// <summary>
  /// KeepLines.
  /// </summary>
  public System.Boolean? KeepLines { get ; set; }
  
  /// <summary>
  /// PageBreakBefore.
  /// </summary>
  public System.Boolean? PageBreakBefore { get ; set; }
  
  /// <summary>
  /// FrameProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.IFrameProperties? FrameProperties { get ; set; }
  
  /// <summary>
  /// WidowControl.
  /// </summary>
  public System.Boolean? WidowControl { get ; set; }
  
  /// <summary>
  /// NumberingProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.INumberingProperties? NumberingProperties { get ; set; }
  
  /// <summary>
  /// SuppressLineNumbers.
  /// </summary>
  public System.Boolean? SuppressLineNumbers { get ; set; }
  
  /// <summary>
  /// ParagraphBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.IParagraphBorders? ParagraphBorders { get ; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.IShading? Shading { get ; set; }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? Tabs { get ; set; }
  
  /// <summary>
  /// SuppressAutoHyphens.
  /// </summary>
  public System.Boolean? SuppressAutoHyphens { get ; set; }
  
  /// <summary>
  /// Kinsoku.
  /// </summary>
  public System.Boolean? Kinsoku { get ; set; }
  
  /// <summary>
  /// WordWrap.
  /// </summary>
  public System.Boolean? WordWrap { get ; set; }
  
  /// <summary>
  /// OverflowPunctuation.
  /// </summary>
  public System.Boolean? OverflowPunctuation { get ; set; }
  
  /// <summary>
  /// TopLinePunctuation.
  /// </summary>
  public System.Boolean? TopLinePunctuation { get ; set; }
  
  /// <summary>
  /// AutoSpaceDE.
  /// </summary>
  public System.Boolean? AutoSpaceDE { get ; set; }
  
  /// <summary>
  /// AutoSpaceDN.
  /// </summary>
  public System.Boolean? AutoSpaceDN { get ; set; }
  
  /// <summary>
  /// BiDi.
  /// </summary>
  public System.Boolean? BiDi { get ; set; }
  
  /// <summary>
  /// AdjustRightIndent.
  /// </summary>
  public System.Boolean? AdjustRightIndent { get ; set; }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  public System.Boolean? SnapToGrid { get ; set; }
  
  /// <summary>
  /// SpacingBetweenLines.
  /// </summary>
  public DocumentModel.Wordprocessing.ISpacingBetweenLines? SpacingBetweenLines { get ; set; }
  
  /// <summary>
  /// Indentation.
  /// </summary>
  public DocumentModel.Wordprocessing.IIndentation? Indentation { get ; set; }
  
  /// <summary>
  /// ContextualSpacing.
  /// </summary>
  public System.Boolean? ContextualSpacing { get ; set; }
  
  /// <summary>
  /// MirrorIndents.
  /// </summary>
  public System.Boolean? MirrorIndents { get ; set; }
  
  /// <summary>
  /// SuppressOverlap.
  /// </summary>
  public System.Boolean? SuppressOverlap { get ; set; }
  
  /// <summary>
  /// Justification.
  /// </summary>
  public DocumentModel.Wordprocessing.JustificationKind? Justification { get ; set; }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  public DocumentModel.Wordprocessing.TextDirectionKind? TextDirection { get ; set; }
  
  /// <summary>
  /// TextAlignment.
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalTextAlignmentKind? TextAlignment { get ; set; }
  
  /// <summary>
  /// TextBoxTightWrap.
  /// </summary>
  public DocumentModel.Wordprocessing.TextBoxTightWrapKind? TextBoxTightWrap { get ; set; }
  
  /// <summary>
  /// OutlineLevel.
  /// </summary>
  public System.Int32? OutlineLevel { get ; set; }
  
  /// <summary>
  /// DivId.
  /// </summary>
  public System.String? DivId { get ; set; }
  
  /// <summary>
  /// ConditionalFormatStyle.
  /// </summary>
  public DocumentModel.Wordprocessing.IConditionalFormatStyle? ConditionalFormatStyle { get ; set; }
  
}
