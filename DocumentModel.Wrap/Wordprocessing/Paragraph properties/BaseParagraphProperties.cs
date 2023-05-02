namespace DocumentModel.Wordprocessing;

/// <summary>
///   Base class for all ParagraphProperties classes.
///   Contains common properties.
/// </summary>
public abstract class BaseParagraphProperties: ModelElement
{
  /// <summary>
  ///   KeepNext.
  /// </summary>
  public bool? KeepNext { get; set; }

  /// <summary>
  ///   KeepLines.
  /// </summary>
  public bool? KeepLines { get; set; }

  /// <summary>
  ///   PageBreakBefore.
  /// </summary>
  public bool? PageBreakBefore { get; set; }

  /// <summary>
  ///   FrameProperties.
  /// </summary>
  public FrameProperties? FrameProperties { get; set; }

  /// <summary>
  ///   WidowControl.
  /// </summary>
  public bool? WidowControl { get; set; }

  /// <summary>
  ///   NumberingProperties.
  /// </summary>
  public NumberingProperties? NumberingProperties { get; set; }

  /// <summary>
  ///   SuppressLineNumbers.
  /// </summary>
  public bool? SuppressLineNumbers { get; set; }

  /// <summary>
  ///   ParagraphBorders.
  /// </summary>
  public ParagraphBorders? ParagraphBorders { get; set; }

  /// <summary>
  ///   Shading.
  /// </summary>
  public Shading? Shading { get; set; }

  /// <summary>
  ///   Tabs.
  /// </summary>
  public Tabs? Tabs { get; set; }

  /// <summary>
  ///   SuppressAutoHyphens.
  /// </summary>
  public bool? SuppressAutoHyphens { get; set; }

  /// <summary>
  ///   Kinsoku.
  /// </summary>
  public bool? Kinsoku { get; set; }

  /// <summary>
  ///   WordWrap.
  /// </summary>
  public bool? WordWrap { get; set; }

  /// <summary>
  ///   OverflowPunctuation.
  /// </summary>
  public bool? OverflowPunctuation { get; set; }

  /// <summary>
  ///   TopLinePunctuation.
  /// </summary>
  public bool? TopLinePunctuation { get; set; }

  /// <summary>
  ///   AutoSpaceDE.
  /// </summary>
  public bool? AutoSpaceDE { get; set; }

  /// <summary>
  ///   AutoSpaceDN.
  /// </summary>
  public bool? AutoSpaceDN { get; set; }

  /// <summary>
  ///   BiDi.
  /// </summary>
  public bool? BiDi { get; set; }

  /// <summary>
  ///   AdjustRightIndent.
  /// </summary>
  public bool? AdjustRightIndent { get; set; }

  /// <summary>
  ///   SnapToGrid.
  /// </summary>
  public bool? SnapToGrid { get; set; }

  /// <summary>
  ///   SpacingBetweenLines.
  /// </summary>
  public SpacingBetweenLines? SpacingBetweenLines { get; set; }

  /// <summary>
  ///   Indentation.
  /// </summary>
  public Indentation? Indentation { get; set; }

  /// <summary>
  ///   ContextualSpacing.
  /// </summary>
  public bool? ContextualSpacing { get; set; }

  /// <summary>
  ///   MirrorIndents.
  /// </summary>
  public bool? MirrorIndents { get; set; }

  /// <summary>
  ///   SuppressOverlap.
  /// </summary>
  public bool? SuppressOverlap { get; set; }

  /// <summary>
  ///   Justification.
  /// </summary>
  public JustificationKind? Justification { get; set; }

  /// <summary>
  ///   TextDirection.
  /// </summary>
  public TextDirectionKind? TextDirection { get; set; }

  /// <summary>
  ///   TextAlignment.
  /// </summary>
  public VerticalTextAlignmentKind? TextAlignment { get; set; }

  /// <summary>
  ///   TextBoxTightWrap.
  /// </summary>
  public TextBoxTightWrapKind? TextBoxTightWrap { get; set; }

  /// <summary>
  ///   OutlineLevel.
  /// </summary>
  public Int32? OutlineLevel { get; set; }
}