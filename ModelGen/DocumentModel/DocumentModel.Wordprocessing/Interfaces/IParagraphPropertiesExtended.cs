namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Paragraph Properties.
/// </summary>
public interface IParagraphPropertiesExtended // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ParagraphStyleId.
  /// </summary>
  public IParagraphStyleId? ParagraphStyleId { get ; set; }
  
  /// <summary>
  /// KeepNext.
  /// </summary>
  public IKeepNext? KeepNext { get ; set; }
  
  /// <summary>
  /// KeepLines.
  /// </summary>
  public IKeepLines? KeepLines { get ; set; }
  
  /// <summary>
  /// PageBreakBefore.
  /// </summary>
  public IPageBreakBefore? PageBreakBefore { get ; set; }
  
  /// <summary>
  /// FrameProperties.
  /// </summary>
  public IFrameProperties? FrameProperties { get ; set; }
  
  /// <summary>
  /// WidowControl.
  /// </summary>
  public IWidowControl? WidowControl { get ; set; }
  
  /// <summary>
  /// NumberingProperties.
  /// </summary>
  public INumberingProperties? NumberingProperties { get ; set; }
  
  /// <summary>
  /// SuppressLineNumbers.
  /// </summary>
  public ISuppressLineNumbers? SuppressLineNumbers { get ; set; }
  
  /// <summary>
  /// ParagraphBorders.
  /// </summary>
  public IParagraphBorders? ParagraphBorders { get ; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public IShading? Shading { get ; set; }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  public ITabs? Tabs { get ; set; }
  
  /// <summary>
  /// SuppressAutoHyphens.
  /// </summary>
  public ISuppressAutoHyphens? SuppressAutoHyphens { get ; set; }
  
  /// <summary>
  /// Kinsoku.
  /// </summary>
  public IKinsoku? Kinsoku { get ; set; }
  
  /// <summary>
  /// WordWrap.
  /// </summary>
  public IWordWrap? WordWrap { get ; set; }
  
  /// <summary>
  /// OverflowPunctuation.
  /// </summary>
  public IOverflowPunctuation? OverflowPunctuation { get ; set; }
  
  /// <summary>
  /// TopLinePunctuation.
  /// </summary>
  public ITopLinePunctuation? TopLinePunctuation { get ; set; }
  
  /// <summary>
  /// AutoSpaceDE.
  /// </summary>
  public IAutoSpaceDE? AutoSpaceDE { get ; set; }
  
  /// <summary>
  /// AutoSpaceDN.
  /// </summary>
  public IAutoSpaceDN? AutoSpaceDN { get ; set; }
  
  /// <summary>
  /// BiDi.
  /// </summary>
  public IBiDi? BiDi { get ; set; }
  
  /// <summary>
  /// AdjustRightIndent.
  /// </summary>
  public IAdjustRightIndent? AdjustRightIndent { get ; set; }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  public ISnapToGrid? SnapToGrid { get ; set; }
  
  /// <summary>
  /// SpacingBetweenLines.
  /// </summary>
  public ISpacingBetweenLines? SpacingBetweenLines { get ; set; }
  
  /// <summary>
  /// Indentation.
  /// </summary>
  public Indentation? Indentation { get ; set; }
  
  /// <summary>
  /// ContextualSpacing.
  /// </summary>
  public IContextualSpacing? ContextualSpacing { get ; set; }
  
  /// <summary>
  /// MirrorIndents.
  /// </summary>
  public IMirrorIndents? MirrorIndents { get ; set; }
  
  /// <summary>
  /// SuppressOverlap.
  /// </summary>
  public ISuppressOverlap? SuppressOverlap { get ; set; }
  
  /// <summary>
  /// Justification.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.JustificationValues>? Justification { get ; set; }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues>? TextDirection { get ; set; }
  
  /// <summary>
  /// TextAlignment.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues>? TextAlignment { get ; set; }
  
  /// <summary>
  /// TextBoxTightWrap.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues>? TextBoxTightWrap { get ; set; }
  
  /// <summary>
  /// OutlineLevel.
  /// </summary>
  public IOutlineLevel? OutlineLevel { get ; set; }
  
  /// <summary>
  /// DivId.
  /// </summary>
  public IStringValue? DivId { get ; set; }
  
  /// <summary>
  /// ConditionalFormatStyle.
  /// </summary>
  public IConditionalFormatStyle? ConditionalFormatStyle { get ; set; }
  
}
