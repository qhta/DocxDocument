namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of paragraph properties which shall be applied to the contents of the parent paragraph after all style/numbering/table properties have been applied to the text. These properties are defined as direct formatting, since they are directly applied to the paragraph and supersede any formatting from styles.
/// </summary>
public partial class ParagraphProperties
{
  
  /// <summary>
  ///   ParagraphStyleId.
  /// </summary>
  public DocumentModel.Wordprocessing.ParagraphStyleId? ParagraphStyleId { get; set; }
  
  
  /// <summary>
  ///   KeepNext.
  /// </summary>
  public DocumentModel.Wordprocessing.KeepNext? KeepNext { get; set; }
  
  
  /// <summary>
  ///   KeepLines.
  /// </summary>
  public DocumentModel.Wordprocessing.KeepLines? KeepLines { get; set; }
  
  
  /// <summary>
  ///   PageBreakBefore.
  /// </summary>
  public DocumentModel.Wordprocessing.PageBreakBefore? PageBreakBefore { get; set; }
  
  
  /// <summary>
  ///   FrameProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.FrameProperties? FrameProperties { get; set; }
  
  
  /// <summary>
  ///   WidowControl.
  /// </summary>
  public DocumentModel.Wordprocessing.WidowControl? WidowControl { get; set; }
  
  
  /// <summary>
  ///   NumberingProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.NumberingProperties? NumberingProperties { get; set; }
  
  
  /// <summary>
  ///   SuppressLineNumbers.
  /// </summary>
  public DocumentModel.Wordprocessing.SuppressLineNumbers? SuppressLineNumbers { get; set; }
  
  
  /// <summary>
  ///   ParagraphBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.ParagraphBorders? ParagraphBorders { get; set; }
  
  
  /// <summary>
  ///   Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.Shading? Shading { get; set; }
  
  
  /// <summary>
  ///   Tabs.
  /// </summary>
  public DocumentModel.Wordprocessing.Tabs? Tabs { get; set; }
  
  
  /// <summary>
  ///   SuppressAutoHyphens.
  /// </summary>
  public DocumentModel.Wordprocessing.SuppressAutoHyphens? SuppressAutoHyphens { get; set; }
  
  
  /// <summary>
  ///   Kinsoku.
  /// </summary>
  public DocumentModel.Wordprocessing.Kinsoku? Kinsoku { get; set; }
  
  
  /// <summary>
  ///   WordWrap.
  /// </summary>
  public DocumentModel.Wordprocessing.WordWrap? WordWrap { get; set; }
  
  
  /// <summary>
  ///   OverflowPunctuation.
  /// </summary>
  public DocumentModel.Wordprocessing.OverflowPunctuation? OverflowPunctuation { get; set; }
  
  
  /// <summary>
  ///   TopLinePunctuation.
  /// </summary>
  public DocumentModel.Wordprocessing.TopLinePunctuation? TopLinePunctuation { get; set; }
  
  
  /// <summary>
  ///   AutoSpaceDE.
  /// </summary>
  public DocumentModel.Wordprocessing.AutoSpaceDE? AutoSpaceDE { get; set; }
  
  
  /// <summary>
  ///   AutoSpaceDN.
  /// </summary>
  public DocumentModel.Wordprocessing.AutoSpaceDN? AutoSpaceDN { get; set; }
  
  
  /// <summary>
  ///   BiDi.
  /// </summary>
  public DocumentModel.Wordprocessing.BiDi? BiDi { get; set; }
  
  
  /// <summary>
  ///   AdjustRightIndent.
  /// </summary>
  public DocumentModel.Wordprocessing.AdjustRightIndent? AdjustRightIndent { get; set; }
  
  
  /// <summary>
  ///   SnapToGrid.
  /// </summary>
  public DocumentModel.Wordprocessing.SnapToGrid? SnapToGrid { get; set; }
  
  
  /// <summary>
  ///   SpacingBetweenLines.
  /// </summary>
  public DocumentModel.Wordprocessing.SpacingBetweenLines? SpacingBetweenLines { get; set; }
  
  
  /// <summary>
  ///   Indentation.
  /// </summary>
  public DocumentModel.Wordprocessing.Indentation? Indentation { get; set; }
  
  
  /// <summary>
  ///   ContextualSpacing.
  /// </summary>
  public DocumentModel.Wordprocessing.ContextualSpacing? ContextualSpacing { get; set; }
  
  
  /// <summary>
  ///   MirrorIndents.
  /// </summary>
  public DocumentModel.Wordprocessing.MirrorIndents? MirrorIndents { get; set; }
  
  
  /// <summary>
  ///   SuppressOverlap.
  /// </summary>
  public DocumentModel.Wordprocessing.SuppressOverlap? SuppressOverlap { get; set; }
  
  
  /// <summary>
  ///   Justification.
  /// </summary>
  public DocumentModel.Wordprocessing.JustificationKind? Justification { get; set; }
  
  
  /// <summary>
  ///   TextDirection.
  /// </summary>
  public DocumentModel.Wordprocessing.TextDirectionKind? TextDirection { get; set; }
  
  
  /// <summary>
  ///   TextAlignment.
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalTextAlignmentKind? TextAlignment { get; set; }
  
  
  /// <summary>
  ///   TextBoxTightWrap.
  /// </summary>
  public DocumentModel.Wordprocessing.TextBoxTightWrapKind? TextBoxTightWrap { get; set; }
  
  
  /// <summary>
  ///   OutlineLevel.
  /// </summary>
  public DocumentModel.Wordprocessing.OutlineLevel? OutlineLevel { get; set; }
  
  
  /// <summary>
  ///   DivId.
  /// </summary>
  public String? DivId { get; set; }
  
  
  /// <summary>
  ///   ConditionalFormatStyle.
  /// </summary>
  public DocumentModel.Wordprocessing.ConditionalFormatStyle? ConditionalFormatStyle { get; set; }
  
  
  /// <summary>
  ///   Run Properties for the Paragraph Mark.
  /// </summary>
  public DocumentModel.Wordprocessing.ParagraphMarkRunProperties? ParagraphMarkRunProperties { get; set; }
  
  
  /// <summary>
  ///   Section Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.SectionProperties? SectionProperties { get; set; }
  
  
  /// <summary>
  ///   ParagraphPropertiesChange.
  /// </summary>
  public DocumentModel.Wordprocessing.ParagraphPropertiesChange? ParagraphPropertiesChange { get; set; }
  
}
