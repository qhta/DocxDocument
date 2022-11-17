namespace DocumentModel.Wordprocessing;

public interface IParagraphProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IParagraphStyleId? ParagraphStyleId { get ; set; }

  public IKeepNext? KeepNext { get ; set; }

  public IKeepLines? KeepLines { get ; set; }

  public IPageBreakBefore? PageBreakBefore { get ; set; }

  public IFrameProperties? FrameProperties { get ; set; }

  public IWidowControl? WidowControl { get ; set; }

  public INumberingProperties? NumberingProperties { get ; set; }

  public ISuppressLineNumbers? SuppressLineNumbers { get ; set; }

  public IParagraphBorders? ParagraphBorders { get ; set; }

  public IShading? Shading { get ; set; }

  public DocumentModel.Wordprocessing.ITabs? Tabs { get ; set; }

  public ISuppressAutoHyphens? SuppressAutoHyphens { get ; set; }

  public DocumentModel.Wordprocessing.IKinsoku? Kinsoku { get ; set; }

  public IWordWrap? WordWrap { get ; set; }

  public IOverflowPunctuation? OverflowPunctuation { get ; set; }

  public ITopLinePunctuation? TopLinePunctuation { get ; set; }

  public IAutoSpaceDE? AutoSpaceDE { get ; set; }

  public IAutoSpaceDN? AutoSpaceDN { get ; set; }

  public IBiDi? BiDi { get ; set; }

  public IAdjustRightIndent? AdjustRightIndent { get ; set; }

  public ISnapToGrid? SnapToGrid { get ; set; }

  public ISpacingBetweenLines? SpacingBetweenLines { get ; set; }

  public IIndentation? Indentation { get ; set; }

  public IContextualSpacing? ContextualSpacing { get ; set; }

  public IMirrorIndents? MirrorIndents { get ; set; }

  public ISuppressOverlap? SuppressOverlap { get ; set; }

  public DocumentModel.Wordprocessing.IJustification? Justification { get ; set; }

  public ITextDirection? TextDirection { get ; set; }

  public ITextAlignment? TextAlignment { get ; set; }

  public ITextBoxTightWrap? TextBoxTightWrap { get ; set; }

  public IOutlineLevel? OutlineLevel { get ; set; }

  public IDivId? DivId { get ; set; }

  public IConditionalFormatStyle? ConditionalFormatStyle { get ; set; }

  public IParagraphMarkRunProperties? ParagraphMarkRunProperties { get ; set; }

  public DocumentModel.Wordprocessing.ISectionProperties? SectionProperties { get ; set; }

  public IParagraphPropertiesChange? ParagraphPropertiesChange { get ; set; }

}
