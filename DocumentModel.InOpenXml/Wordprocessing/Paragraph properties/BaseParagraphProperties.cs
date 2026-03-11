namespace DocumentModel.Wordprocessing;

/// <summary>
/// Base interface for all paragraph properties classes in a WordprocessingML document.
/// Contains common properties for controlling paragraph formatting, layout, alignment, borders, spacing, indentation, and advanced typography features.
/// </summary>
public abstract partial class BaseParagraphProperties<T>: ModelElement<T>//, IBaseParagraphProperties
  where T: DX.OpenXmlCompositeElement
{
  /// <summary>
  /// Indicates whether the paragraph should be kept on the same page as the next paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.KeepNext))]
  public bool? KeepNext { get => _KeepNext; set => UpdateField(ref _KeepNext, value, nameof(KeepNext)); }

  private bool? _KeepNext;

  /// <summary>
  /// Indicates whether all lines in the paragraph should be kept together on the same page.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.KeepLines))]
  public bool? KeepLines { get => _KeepLines; set => UpdateField(ref _KeepLines, value, nameof(KeepLines)); }

  private bool? _KeepLines;

  /// <summary>
  /// Indicates whether a page break should be inserted before the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.PageBreakBefore))]
  public bool? PageBreakBefore
  {
    get => _PageBreakBefore;
    set => UpdateField(ref _PageBreakBefore, value, nameof(PageBreakBefore));
  }

  private bool? _PageBreakBefore;

  /// <summary>
  /// Frame properties for the paragraph, specifying frame layout and positioning.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.FrameProperties))]
  public FrameProperties? FrameProperties
  {
    get => _FrameProperties;
    set => UpdateField(ref _FrameProperties, value, nameof(FrameProperties));
  }

  private FrameProperties? _FrameProperties;

  /// <summary>
  /// Indicates whether widow and orphan control is enabled for the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.WidowControl))]
  public bool? WidowControl
  {
    get => _WidowControl;
    set => UpdateField(ref _WidowControl, value, nameof(WidowControl));
  }

  private bool? _WidowControl;

  /// <summary>
  /// Indicates whether line numbers should be suppressed for the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.SuppressLineNumbers))]
  public bool? SuppressLineNumbers
  {
    get => _SuppressLineNumbers;
    set => UpdateField(ref _SuppressLineNumbers, value, nameof(SuppressLineNumbers));
  }

  private bool? _SuppressLineNumbers;

  /// <summary>
  /// Border settings for the paragraph, specifying borders on all sides and between paragraphs.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.ParagraphBorders))]
  public ParagraphBorders? Borders { get => _borders; set => UpdateField(ref _borders, value, nameof(Borders)); }

  private ParagraphBorders? _borders;

  /// <summary>
  /// Shading (background color and pattern) for the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.Shading))]
  public Shading? Shading { get => _Shading; set => UpdateField(ref _Shading, value, nameof(Shading)); }

  private Shading? _Shading;

  /// <summary>
  /// Tab stop settings for the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.Tabs))]
  public Tabs? Tabs { get => _Tabs; set => UpdateField(ref _Tabs, value, nameof(Tabs)); }

  private Tabs? _Tabs;

  /// <summary>
  /// Indicates whether automatic hyphenation is suppressed for the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.SuppressAutoHyphens))]
  public bool? SuppressAutoHyphens
  {
    get => _SuppressAutoHyphens;
    set => UpdateField(ref _SuppressAutoHyphens, value, nameof(SuppressAutoHyphens));
  }

  private bool? _SuppressAutoHyphens;

  /// <summary>
  /// Indicates whether kinsoku shori (line breaking rules for East Asian text) is enabled.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.Kinsoku))]
  public bool? Kinsoku { get => _Kinsoku; set => UpdateField(ref _Kinsoku, value, nameof(Kinsoku)); }

  private bool? _Kinsoku;

  /// <summary>
  /// Indicates whether word wrapping is enabled for the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.WordWrap))]
  public bool? WordWrap { get => _WordWrap; set => UpdateField(ref _WordWrap, value, nameof(WordWrap)); }

  private bool? _WordWrap;

  /// <summary>
  /// Indicates whether overflow punctuation is allowed at the end of a line.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.OverflowPunctuation))]
  public bool? OverflowPunctuation
  {
    get => _OverflowPunctuation;
    set => UpdateField(ref _OverflowPunctuation, value, nameof(OverflowPunctuation));
  }

  private bool? _OverflowPunctuation;

  /// <summary>
  /// Indicates whether top line punctuation is enabled for the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.TopLinePunctuation))]
  public bool? TopLinePunctuation
  {
    get => _TopLinePunctuation;
    set => UpdateField(ref _TopLinePunctuation, value, nameof(TopLinePunctuation));
  }

  private bool? _TopLinePunctuation;

  /// <summary>
  /// Indicates whether automatic spacing is added between East Asian and Latin text.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.AutoSpaceDE))]
  public bool? AutoSpaceDE { get => _AutoSpaceDE; set => UpdateField(ref _AutoSpaceDE, value, nameof(AutoSpaceDE)); }

  private bool? _AutoSpaceDE;

  /// <summary>
  /// Indicates whether automatic spacing is added between East Asian and numeric text.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.AutoSpaceDN))]
  public bool? AutoSpaceDN { get => _AutoSpaceDN; set => UpdateField(ref _AutoSpaceDN, value, nameof(AutoSpaceDN)); }

  private bool? _AutoSpaceDN;

  /// <summary>
  /// Indicates whether the paragraph is formatted for bidirectional (right-to-left) text.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.BiDi))]
  public bool? BiDi { get => _BiDi; set => UpdateField(ref _BiDi, value, nameof(BiDi)); }

  private bool? _BiDi;

  /// <summary>
  /// Indicates whether the right indent should be automatically adjusted for the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.AdjustRightIndent))]
  public bool? AdjustRightIndent
  {
    get => _AdjustRightIndent;
    set => UpdateField(ref _AdjustRightIndent, value, nameof(AdjustRightIndent));
  }

  private bool? _AdjustRightIndent;

  /// <summary>
  /// Indicates whether the paragraph should snap to the document grid.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.SnapToGrid))]
  public bool? SnapToGrid { get => _SnapToGrid; set => UpdateField(ref _SnapToGrid, value, nameof(SnapToGrid)); }

  private bool? _SnapToGrid;

  ///// <summary>
  ///// Spacing settings between lines and paragraphs.
  ///// </summary>
  //[OpenXmlProperty(nameof(DXW.ParagraphProperties.SpacingBetweenLines))]
  //public ParagraphSpacing? Spacing
  //{
  //  get => _spacing;
  //  set => UpdateField(ref _spacing, value, nameof(Spacing));
  //}

  //private ParagraphSpacing? _spacing;

  /// <summary>
  /// Spacing above the paragraph.
  /// </summary>
  [OpenXmlLoadData(nameof(LoadBefore))]
  [OpenXmlUpdateData(nameof(UpdateBefore))]
  public ParagraphSpacing? SpacingBefore
  {
    get => _spacingBefore;
    set => UpdateField(ref _spacingBefore, value, nameof(SpacingBefore));
  }

  private ParagraphSpacing? _spacingBefore;

  /// <summary>
  /// Spacing below the paragraph.
  /// </summary>
  [OpenXmlLoadData(nameof(LoadAfter))]
  [OpenXmlUpdateData(nameof(UpdateAfter))]
  public ParagraphSpacing? SpacingAfter
  {
    get => _spacingAfter;
    set => UpdateField(ref _spacingAfter, value, nameof(SpacingAfter));
  }

  private ParagraphSpacing? _spacingAfter;

  /// <summary>
  /// Spacing between lines within the paragraph.
  /// </summary>
  [OpenXmlLoadData(nameof(LoadInterlines))]
  [OpenXmlUpdateData(nameof(UpdateInterlines))]
  public Interline? SpacingInterline
  {
    get => _spacingInterline;
    set => UpdateField(ref _spacingInterline, value, nameof(SpacingInterline));
  }

  private Interline? _spacingInterline;

  /// <summary>
  /// Loads the spacing information that appears before a paragraph from the specified OpenXmlElement.
  /// </summary>
  /// <remarks>This method inspects the provided OpenXmlElement for spacing properties related to the space
  /// before a paragraph. If no relevant spacing information is present, the method performs no action.</remarks>
  /// <param name="openXmlElement">The OpenXmlElement instance from which
  /// to extract the 'before' paragraph spacing settings. Must not be null.</param>
  public void LoadBefore(DX.OpenXmlElement openXmlElement)
  {
    var paragraphSpacing = openXmlElement.GetType().GetProperty("SpacingBetweenLines")?.GetValue(openXmlElement);
    if (paragraphSpacing is DXW.SpacingBetweenLines source)
    {
      if (source.Before == null && source.BeforeLines == null && source.BeforeAutoSpacing == null) return;

      SpacingBefore = new ParagraphSpacing();
      SpacingBefore.FromOpenXml(source.Before, source.BeforeLines, source.BeforeAutoSpacing);
    }
  }

  /// <summary>
  /// Updates the spacing before a paragraph by setting the corresponding properties
  /// on the specified OpenXmlElement.
  /// </summary>
  /// <remarks>This method applies the values from the 'Before' property, if present, to the
  /// 'SpacingBetweenLines' property of the provided OpenXmlElement.
  /// If 'Before' is null, no changes are made.</remarks>
  /// <param name="openXmlElement">The OpenXmlElement to update with spacing information.
  /// Must not be null and should support a 'SpacingBetweenLines'
  /// property.</param>
  public void UpdateBefore(DX.OpenXmlElement openXmlElement)
  {
    if (SpacingBefore == null) return;

    var paragraphSpacing = openXmlElement.GetType().GetProperty("SpacingBetweenLines")?.GetValue(openXmlElement);
    if (paragraphSpacing is not DXW.SpacingBetweenLines target)
    {
      target = new DXW.SpacingBetweenLines();
      openXmlElement.GetType().GetProperty("SpacingBetweenLines")?.SetValue(openXmlElement, target);
    }
    var (sourceVal, sourceLines, sourceAutoSpacing) = SpacingBefore.ToOpenXml();
    if (sourceVal != null)
      target.Before = sourceVal;
    if (sourceLines != null)
      target.BeforeLines = sourceLines.Value;
    if (sourceAutoSpacing != null)
      target.BeforeAutoSpacing = sourceAutoSpacing.Value;
  }

  /// <summary>
  /// Loads the spacing information that appears after a paragraph from the specified OpenXmlElement.
  /// </summary>
  /// <remarks>This method inspects the provided OpenXmlElement for spacing properties related to the space
  /// after a paragraph. If no relevant spacing information is present, the method performs no action.</remarks>
  /// <param name="openXmlElement">The OpenXmlElement instance from which
  /// to extract the 'After' paragraph spacing settings. Must not be null.</param>
  public void LoadAfter(DX.OpenXmlElement openXmlElement)
  {
    var paragraphSpacing = openXmlElement.GetType().GetProperty("SpacingBetweenLines")?.GetValue(openXmlElement);
    if (paragraphSpacing is DXW.SpacingBetweenLines source)
    {
      if (source.After == null && source.AfterLines == null && source.AfterAutoSpacing == null) return;

      SpacingAfter = new ParagraphSpacing();
      SpacingAfter.FromOpenXml(source.After, source.AfterLines, source.AfterAutoSpacing);
    }
  }

  /// <summary>
  /// Updates the spacing after a paragraph by setting the corresponding properties
  /// on the specified OpenXmlElement.
  /// </summary>
  /// <remarks>This method applies the values from the 'After' property, if present, to the
  /// 'SpacingBetweenLines' property of the provided OpenXmlElement.
  /// If 'After' is null, no changes are made.</remarks>
  /// <param name="openXmlElement">The OpenXmlElement to update with spacing information.
  /// Must not be null and should support a 'SpacingBetweenLines'
  /// property.</param>
  public void UpdateAfter(DX.OpenXmlElement openXmlElement)
  {
    if (SpacingAfter == null) return;

    var paragraphSpacing = openXmlElement.GetType().GetProperty("SpacingBetweenLines")?.GetValue(openXmlElement);
    if (paragraphSpacing is not DXW.SpacingBetweenLines target)
    {
      target = new DXW.SpacingBetweenLines();
      openXmlElement.GetType().GetProperty("SpacingBetweenLines")?.SetValue(openXmlElement, target);
    }
    var (sourceVal, sourceLines, sourceAutoSpacing) = SpacingAfter.ToOpenXml();
    if (sourceVal != null)
      target.After = sourceVal;
    if (sourceLines != null)
      target.AfterLines = sourceLines.Value;
    if (sourceAutoSpacing != null)
      target.AfterAutoSpacing = sourceAutoSpacing.Value;
  }

  /// <summary>
  /// Loads paragraph line spacing information from the specified OpenXmlElement and updates the Interlines property
  /// accordingly.
  /// </summary>
  /// <remarks>If the specified element does not contain line spacing information, the Interlines property is
  /// not modified.</remarks>
  /// <param name="openXmlElement">The OpenXmlElement instance from which to extract line spacing information. Must represent a paragraph element
  /// that may contain spacing settings.</param>
  public void LoadInterlines(DX.OpenXmlElement openXmlElement)
  {
    var paragraphSpacing = openXmlElement.GetType().GetProperty("SpacingBetweenLines")?.GetValue(openXmlElement);
    if (paragraphSpacing is DXW.SpacingBetweenLines source)
    {
      if (source.Line == null && source.LineRule == null) return;

      SpacingInterline = new Interline
      {
        Line = (source.Line?.Value) != null ? new Twips(source.Line.Value) : null,
        LineRule = source.LineRule?.GetEnumValue<DXW.LineSpacingRuleValues, LineSpacingRule>()
      };
    }
  }

  /// <summary>
  /// Updates the line spacing properties of the specified OpenXmlElement to match the current interline settings.
  /// </summary>
  /// <remarks>If the interline settings are not defined, this method performs no action. The method creates or
  /// updates the SpacingBetweenLines property on the provided element as needed.</remarks>
  /// <param name="openXmlElement">The OpenXmlElement whose line spacing properties will be updated. Must support a property named
  /// "SpacingBetweenLines" compatible with WordprocessingML.</param>
  public void UpdateInterlines(DX.OpenXmlElement openXmlElement)
  {
    if (SpacingInterline == null) return;

    var paragraphSpacing = openXmlElement.GetType().GetProperty("SpacingBetweenLines")?.GetValue(openXmlElement);
    if (paragraphSpacing is not DXW.SpacingBetweenLines target)
    {
      target = new DXW.SpacingBetweenLines();
      openXmlElement.GetType().GetProperty("SpacingBetweenLines")?.SetValue(openXmlElement, target);
    }
    if (SpacingInterline.Line != null)
      target.Line = SpacingInterline.Line.IntValue.ToString();
    if (SpacingInterline.LineRule != null)
      target.LineRule =
        EnumTypeConverter.CreateOpenXmlEnumValue<DXW.LineSpacingRuleValues, LineSpacingRule>(SpacingInterline.LineRule.Value);
  }

  /// <summary>
  /// Indicates whether contextual spacing is enabled, allowing spacing to be determined by surrounding paragraphs.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.ContextualSpacing))]
  public bool? SpacingByContext
  {
    get => _spacingByContext;
    set => UpdateField(ref _spacingByContext, value, nameof(SpacingByContext));
  }

  private bool? _spacingByContext;


  /// <summary>
  /// Indentation settings for the paragraph, including left, right, first line, and hanging indents.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.Indentation))]
  public Indentation? Indentation
  {
    get => _Indentation;
    set => UpdateField(ref _Indentation, value, nameof(Indentation));
  }

  private Indentation? _Indentation;

  /// <summary>
  /// Indicates whether mirror indents are enabled for the paragraph (used for facing pages).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.MirrorIndents))]
  public bool? MirrorIndents
  {
    get => _MirrorIndents;
    set => UpdateField(ref _MirrorIndents, value, nameof(MirrorIndents));
  }

  private bool? _MirrorIndents;

  /// <summary>
  /// Indicates whether paragraph overlap is suppressed.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.SuppressOverlap))]
  public bool? SuppressOverlap
  {
    get => _SuppressOverlap;
    set => UpdateField(ref _SuppressOverlap, value, nameof(SuppressOverlap));
  }

  private bool? _SuppressOverlap;

  /// <summary>
  /// Justification setting for the paragraph (e.g., left, right, center, both).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.Justification))]
  public Justification? Justification
  {
    get => _Justification;
    set => UpdateField(ref _Justification, value, nameof(Justification));
  }

  private Justification? _Justification;

  /// <summary>
  /// Text direction for the paragraph (e.g., left-to-right, right-to-left, top-to-bottom).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.TextDirection))]
  public TextDirection? TextDirection
  {
    get => _TextDirection;
    set => UpdateField(ref _TextDirection, value, nameof(TextDirection));
  }

  private TextDirection? _TextDirection;

  /// <summary>
  /// Vertical text alignment for the paragraph (e.g., baseline, top, center, bottom).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.TextAlignment))]
  public VerticalTextAlignment? VerticalTextAlignment
  {
    get => _verticalTextAlignment;
    set => UpdateField(ref _verticalTextAlignment, value, nameof(VerticalTextAlignment));
  }

  private VerticalTextAlignment? _verticalTextAlignment;

  /// <summary>
  /// Text box tight wrap setting for the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.TextBoxTightWrap))]
  public TextBoxTightWrap? TextBoxTightWrap
  {
    get => _TextBoxTightWrap;
    set => UpdateField(ref _TextBoxTightWrap, value, nameof(TextBoxTightWrap));
  }

  private TextBoxTightWrap? _TextBoxTightWrap;

  /// <summary>
  /// Outline level for the paragraph, used for document structure and navigation.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.OutlineLevel))]
  public OutlineLevel? OutlineLevel
  {
    get => _OutlineLevel;
    set => UpdateField(ref _OutlineLevel, value, nameof(OutlineLevel));
  }

  private OutlineLevel? _OutlineLevel;

  /// <summary>
  /// Numbering properties for the paragraph, specifying list and outline numbering.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphProperties.NumberingProperties))]
  public NumberingProperties? NumberingProperties
  {
    get => _NumberingProperties;
    set => UpdateField(ref _NumberingProperties, value, nameof(NumberingProperties));
  }

  private NumberingProperties? _NumberingProperties;
}

/// <summary>
/// Concrete class for BaseParagraphProperties.
/// </summary>
public class BaseParagraphProperties: BaseParagraphProperties<DXW.ParagraphPropertiesBaseStyle>
{
}