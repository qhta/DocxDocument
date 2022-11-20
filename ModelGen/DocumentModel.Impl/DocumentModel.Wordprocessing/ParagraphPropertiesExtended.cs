namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Paragraph Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IConditionalFormatStyle))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IOutlineLevel))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFrameProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IIndentation))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IJustification))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDivId))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INumberingProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IKeepNext))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IKeepLines))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPageBreakBefore))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IWidowControl))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISuppressLineNumbers))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISuppressAutoHyphens))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IKinsoku))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IWordWrap))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IOverflowPunctuation))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITopLinePunctuation))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IAutoSpaceDE))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IAutoSpaceDN))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBiDi))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IAdjustRightIndent))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISnapToGrid))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IContextualSpacing))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMirrorIndents))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISuppressOverlap))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IParagraphBorders))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IShading))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISpacingBetweenLines))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IParagraphStyleId))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITabs))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITextAlignment))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITextBoxTightWrap))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITextDirection))]
public class ParagraphPropertiesExtended: IParagraphPropertiesExtended
{
  /// <summary>
  /// ParagraphStyleId.
  /// </summary>
  public IParagraphStyleId? ParagraphStyleId
  {
    get;
    set;
  }
  
  /// <summary>
  /// KeepNext.
  /// </summary>
  public IKeepNext? KeepNext
  {
    get;
    set;
  }
  
  /// <summary>
  /// KeepLines.
  /// </summary>
  public IKeepLines? KeepLines
  {
    get;
    set;
  }
  
  /// <summary>
  /// PageBreakBefore.
  /// </summary>
  public IPageBreakBefore? PageBreakBefore
  {
    get;
    set;
  }
  
  /// <summary>
  /// FrameProperties.
  /// </summary>
  public IFrameProperties? FrameProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// WidowControl.
  /// </summary>
  public IWidowControl? WidowControl
  {
    get;
    set;
  }
  
  /// <summary>
  /// NumberingProperties.
  /// </summary>
  public INumberingProperties? NumberingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// SuppressLineNumbers.
  /// </summary>
  public ISuppressLineNumbers? SuppressLineNumbers
  {
    get;
    set;
  }
  
  /// <summary>
  /// ParagraphBorders.
  /// </summary>
  public IParagraphBorders? ParagraphBorders
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public IShading? Shading
  {
    get;
    set;
  }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  public DocumentModel.Wordprocessing.ITabs? Tabs
  {
    get;
    set;
  }
  
  /// <summary>
  /// SuppressAutoHyphens.
  /// </summary>
  public ISuppressAutoHyphens? SuppressAutoHyphens
  {
    get;
    set;
  }
  
  /// <summary>
  /// Kinsoku.
  /// </summary>
  public DocumentModel.Wordprocessing.IKinsoku? Kinsoku
  {
    get;
    set;
  }
  
  /// <summary>
  /// WordWrap.
  /// </summary>
  public IWordWrap? WordWrap
  {
    get;
    set;
  }
  
  /// <summary>
  /// OverflowPunctuation.
  /// </summary>
  public IOverflowPunctuation? OverflowPunctuation
  {
    get;
    set;
  }
  
  /// <summary>
  /// TopLinePunctuation.
  /// </summary>
  public ITopLinePunctuation? TopLinePunctuation
  {
    get;
    set;
  }
  
  /// <summary>
  /// AutoSpaceDE.
  /// </summary>
  public IAutoSpaceDE? AutoSpaceDE
  {
    get;
    set;
  }
  
  /// <summary>
  /// AutoSpaceDN.
  /// </summary>
  public IAutoSpaceDN? AutoSpaceDN
  {
    get;
    set;
  }
  
  /// <summary>
  /// BiDi.
  /// </summary>
  public IBiDi? BiDi
  {
    get;
    set;
  }
  
  /// <summary>
  /// AdjustRightIndent.
  /// </summary>
  public IAdjustRightIndent? AdjustRightIndent
  {
    get;
    set;
  }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  public ISnapToGrid? SnapToGrid
  {
    get;
    set;
  }
  
  /// <summary>
  /// SpacingBetweenLines.
  /// </summary>
  public ISpacingBetweenLines? SpacingBetweenLines
  {
    get;
    set;
  }
  
  /// <summary>
  /// Indentation.
  /// </summary>
  public IIndentation? Indentation
  {
    get;
    set;
  }
  
  /// <summary>
  /// ContextualSpacing.
  /// </summary>
  public IContextualSpacing? ContextualSpacing
  {
    get;
    set;
  }
  
  /// <summary>
  /// MirrorIndents.
  /// </summary>
  public IMirrorIndents? MirrorIndents
  {
    get;
    set;
  }
  
  /// <summary>
  /// SuppressOverlap.
  /// </summary>
  public ISuppressOverlap? SuppressOverlap
  {
    get;
    set;
  }
  
  /// <summary>
  /// Justification.
  /// </summary>
  public DocumentModel.Wordprocessing.IJustification? Justification
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  public ITextDirection? TextDirection
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextAlignment.
  /// </summary>
  public ITextAlignment? TextAlignment
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextBoxTightWrap.
  /// </summary>
  public ITextBoxTightWrap? TextBoxTightWrap
  {
    get;
    set;
  }
  
  /// <summary>
  /// OutlineLevel.
  /// </summary>
  public IOutlineLevel? OutlineLevel
  {
    get;
    set;
  }
  
  /// <summary>
  /// DivId.
  /// </summary>
  public IDivId? DivId
  {
    get;
    set;
  }
  
  /// <summary>
  /// ConditionalFormatStyle.
  /// </summary>
  public IConditionalFormatStyle? ConditionalFormatStyle
  {
    get;
    set;
  }
  
}
