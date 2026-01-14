namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Base interface for all paragraph properties classes in a WordprocessingML document.
  /// Contains common properties for controlling paragraph formatting, layout, alignment, borders, spacing, indentation, and advanced typography features.
  /// </summary>
  public class BaseParagraphProperties: ModelElement
  {
    
    /// <summary>
    /// Indicates whether the paragraph should be kept on the same page as the next paragraph.
    /// </summary>
    public bool? KeepNext { get; set; }
    
    /// <summary>
    /// Indicates whether all lines in the paragraph should be kept together on the same page.
    /// </summary>
    public bool? KeepLines { get; set; }
    
    /// <summary>
    /// Indicates whether a page break should be inserted before the paragraph.
    /// </summary>
    public bool? PageBreakBefore { get; set; }
    
    /// <summary>
    /// Frame properties for the paragraph, specifying frame layout and positioning.
    /// </summary>
    public FrameProperties? FrameProperties { get; set; }
    
    /// <summary>
    /// Indicates whether widow and orphan control is enabled for the paragraph.
    /// </summary>
    public bool? WidowControl { get; set; }
    
    /// <summary>
    /// Numbering properties for the paragraph, specifying list and outline numbering.
    /// </summary>
    public NumberingProperties? NumberingProperties { get; set; }
    
    /// <summary>
    /// Indicates whether line numbers should be suppressed for the paragraph.
    /// </summary>
    public bool? SuppressLineNumbers { get; set; }
    
    /// <summary>
    /// Border settings for the paragraph, specifying borders on all sides and between paragraphs.
    /// </summary>
    public ParagraphBorders? ParagraphBorders { get; set; }
    
    /// <summary>
    /// Shading (background color and pattern) for the paragraph.
    /// </summary>
    public DMWD.Shading? Shading { get; set; }
    
    /// <summary>
    /// Tab stop settings for the paragraph.
    /// </summary>
    public Tabs? Tabs { get; set; }
    
    /// <summary>
    /// Indicates whether automatic hyphenation is suppressed for the paragraph.
    /// </summary>
    public bool? SuppressAutoHyphens { get; set; }
    
    /// <summary>
    /// Indicates whether kinsoku shori (line breaking rules for East Asian text) is enabled.
    /// </summary>
    public bool? Kinsoku { get; set; }
    
    /// <summary>
    /// Indicates whether word wrapping is enabled for the paragraph.
    /// </summary>
    public bool? WordWrap { get; set; }
    
    /// <summary>
    /// Indicates whether overflow punctuation is allowed at the end of a line.
    /// </summary>
    public bool? OverflowPunctuation { get; set; }
    
    /// <summary>
    /// Indicates whether top line punctuation is enabled for the paragraph.
    /// </summary>
    public bool? TopLinePunctuation { get; set; }
    
    /// <summary>
    /// Indicates whether automatic spacing is added between East Asian and Latin text.
    /// </summary>
    public bool? AutoSpaceDE { get; set; }
    
    /// <summary>
    /// Indicates whether automatic spacing is added between East Asian and numeric text.
    /// </summary>
    public bool? AutoSpaceDN { get; set; }
    
    /// <summary>
    /// Indicates whether the paragraph is formatted for bidirectional (right-to-left) text.
    /// </summary>
    public bool? BiDi { get; set; }
    
    /// <summary>
    /// Indicates whether the right indent should be automatically adjusted for the paragraph.
    /// </summary>
    public bool? AdjustRightIndent { get; set; }
    
    /// <summary>
    /// Indicates whether the paragraph should snap to the document grid.
    /// </summary>
    public bool? SnapToGrid { get; set; }
    
    /// <summary>
    /// Spacing settings between lines and paragraphs.
    /// </summary>
    public ParagraphSpacing? SpacingBetweenLines { get; set; }
    
    /// <summary>
    /// Indentation settings for the paragraph, including left, right, first line, and hanging indents.
    /// </summary>
    public Indentation? Indentation { get; set; }
    
    /// <summary>
    /// Indicates whether contextual spacing is enabled, allowing spacing to be determined by surrounding paragraphs.
    /// </summary>
    public bool? ContextualSpacing { get; set; }
    
    /// <summary>
    /// Indicates whether mirror indents are enabled for the paragraph (used for facing pages).
    /// </summary>
    public bool? MirrorIndents { get; set; }
    
    /// <summary>
    /// Indicates whether paragraph overlap is suppressed.
    /// </summary>
    public bool? SuppressOverlap { get; set; }
    
    /// <summary>
    /// Justification setting for the paragraph (e.g., left, right, center, both).
    /// </summary>
    public JustificationKind? Justification { get; set; }
    
    /// <summary>
    /// Text direction for the paragraph (e.g., left-to-right, right-to-left, top-to-bottom).
    /// </summary>
    public TextDirectionKind? TextDirection { get; set; }
    
    /// <summary>
    /// Vertical text alignment for the paragraph (e.g., baseline, top, center, bottom).
    /// </summary>
    public VerticalTextAlignmentKind? TextAlignment { get; set; }
    
    /// <summary>
    /// Text box tight wrap setting for the paragraph.
    /// </summary>
    public TextBoxTightWrapKind? TextBoxTightWrap { get; set; }
    
    /// <summary>
    /// Outline level for the paragraph, used for document structure and navigation.
    /// </summary>
    public Int32? OutlineLevel { get; set; }
  }