namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents all the formatting attributes for a paragraph.
/// </summary>
/// <remarks>
///   <para>
///   ParagraphFormat provides complete control over paragraph-level formatting including
///   alignment, indentation, spacing, borders, shading, tab stops, and numbering.
///   </para>
///   <para>
///   This interface corresponds to the Microsoft.Office.Interop.Word.ParagraphFormat interface
///   and provides comprehensive paragraph formatting capabilities.
///   </para>
/// </remarks>
public interface ParagraphFormat
{
  #region Alignment

  /// <summary>
  ///   Gets or sets the alignment for the paragraph.
  /// </summary>
  /// <remarks>
  ///   Specifies how text is aligned: left, center, right, or justified.
  /// </remarks>
  public ParagraphAlignmentKind? Alignment { get; set; }

  /// <summary>
  ///   Gets or sets the character unit left indent.
  /// </summary>
  public float CharacterUnitLeftIndent { get; set; }

  /// <summary>
  ///   Gets or sets the character unit right indent.
  /// </summary>
  public float CharacterUnitRightIndent { get; set; }

  /// <summary>
  ///   Gets or sets the character unit first line indent.
  /// </summary>
  public float CharacterUnitFirstLineIndent { get; set; }

  #endregion

  #region Indentation

  /// <summary>
  ///   Gets or sets the left indent value in points.
  /// </summary>
  public float LeftIndent { get; set; }

  /// <summary>
  ///   Gets or sets the right indent value in points.
  /// </summary>
  public float RightIndent { get; set; }

  /// <summary>
  ///   Gets or sets the first line indent or hanging indent value in points.
  /// </summary>
  /// <remarks>
  ///   Positive values create first line indents, negative values create hanging indents.
  /// </remarks>
  public float FirstLineIndent { get; set; }

  /// <summary>
  ///   Gets or sets whether to automatically adjust right indent when document grid is defined.
  /// </summary>
  public bool? AutoAdjustRightIndent { get; set; }

  /// <summary>
  ///   Gets or sets whether to use left/right indents or inside/outside indents for mirrored pages.
  /// </summary>
  public bool? MirrorIndents { get; set; }

  #endregion

  #region Line Spacing

  /// <summary>
  ///   Gets or sets the line spacing in points.
  /// </summary>
  /// <remarks>
  ///   The meaning depends on LineSpacingRule: For exact/at least, this is in points.
  ///   For multiple, multiply this value by 12 to get points.
  /// </remarks>
  public float LineSpacing { get; set; }

  /// <summary>
  ///   Gets or sets the line spacing rule.
  /// </summary>
  /// <remarks>
  ///   Specifies how LineSpacing is interpreted: single, 1.5 lines, double, at least, exactly, or multiple.
  /// </remarks>
  public LineSpacingRuleKind? LineSpacingRule { get; set; }

  /// <summary>
  ///   Gets or sets the line unit before the paragraph.
  /// </summary>
  public float LineUnitBefore { get; set; }

  /// <summary>
  ///   Gets or sets the line unit after the paragraph.
  /// </summary>
  public float LineUnitAfter { get; set; }

  #endregion

  #region Spacing Before/After

  /// <summary>
  ///   Gets or sets the spacing before the paragraph in points.
  /// </summary>
  public float SpaceBefore { get; set; }

  /// <summary>
  ///   Gets or sets the spacing after the paragraph in points.
  /// </summary>
  public float SpaceAfter { get; set; }

  /// <summary>
  ///   Gets or sets whether spacing before is automatically determined.
  /// </summary>
  public bool? SpaceBeforeAuto { get; set; }

  /// <summary>
  ///   Gets or sets whether spacing after is automatically determined.
  /// </summary>
  public bool? SpaceAfterAuto { get; set; }

  /// <summary>
  ///   Gets or sets whether to suppress spacing between paragraphs of the same style.
  /// </summary>
  public bool? NoSpaceBetweenParagraphsOfSameStyle { get; set; }

  #endregion

  #region Borders

  /// <summary>
  ///   Gets the collection of borders for the paragraph.
  /// </summary>
  public ParagraphBorders? Borders { get; }

  /// <summary>
  ///   Gets or sets the top border.
  /// </summary>
  public BorderType? TopBorder { get; set; }

  /// <summary>
  ///   Gets or sets the bottom border.
  /// </summary>
  public BorderType? BottomBorder { get; set; }

  /// <summary>
  ///   Gets or sets the left border.
  /// </summary>
  public BorderType? LeftBorder { get; set; }

  /// <summary>
  ///   Gets or sets the right border.
  /// </summary>
  public BorderType? RightBorder { get; set; }

  #endregion

  #region Shading

  /// <summary>
  ///   Gets the shading object for the paragraph.
  /// </summary>
  public DMWD.Shading? Shading { get; }

  /// <summary>
  ///   Gets or sets the background pattern color.
  /// </summary>
  public Color? BackgroundColor { get; set; }

  /// <summary>
  ///   Gets or sets the foreground pattern color.
  /// </summary>
  public Color? ForegroundColor { get; set; }

  #endregion

  #region Tab Stops

  /// <summary>
  ///   Gets the collection of custom tab stops.
  /// </summary>
  public Tabs? TabStops { get; }

  #endregion

  #region Page/Column Breaks

  /// <summary>
  ///   Gets or sets whether to insert a page break before the paragraph.
  /// </summary>
  public bool? PageBreakBefore { get; set; }

  /// <summary>
  ///   Gets or sets whether to prevent page break within the paragraph.
  /// </summary>
  public bool? KeepTogether { get; set; }

  /// <summary>
  ///   Gets or sets whether to keep the paragraph with the next paragraph.
  /// </summary>
  public bool? KeepWithNext { get; set; }

  /// <summary>
  ///   Gets or sets whether to apply widow/orphan control.
  /// </summary>
  public bool? WidowControl { get; set; }

  #endregion

  #region Hyphenation

  /// <summary>
  ///   Gets or sets whether to suppress automatic hyphenation.
  /// </summary>
  public bool? NoLineNumber { get; set; }

  /// <summary>
  ///   Gets or sets whether to disable hyphenation for the paragraph.
  /// </summary>
  public bool? Hyphenation { get; set; }

  #endregion

  #region Asian Typography

  /// <summary>
  ///   Gets or sets whether to use Asian rules for controlling first and last characters.
  /// </summary>
  public bool? FarEastLineBreakControl { get; set; }

  /// <summary>
  ///   Gets or sets whether words are allowed to break across lines in Asian languages.
  /// </summary>
  public bool? WordWrap { get; set; }

  /// <summary>
  ///   Gets or sets whether punctuation is allowed to extend beyond the margins.
  /// </summary>
  public bool? HangingPunctuation { get; set; }

  /// <summary>
  ///   Gets or sets whether to apply half-width characters.
  /// </summary>
  public bool? HalfWidthPunctuationOnTopOfLine { get; set; }

  /// <summary>
  ///   Gets or sets whether to automatically adjust spacing between Asian and Latin text.
  /// </summary>
  public bool? AddSpaceBetweenFarEastAndAlpha { get; set; }

  /// <summary>
  ///   Gets or sets whether to automatically adjust spacing between Asian text and numbers.
  /// </summary>
  public bool? AddSpaceBetweenFarEastAndDigit { get; set; }

  /// <summary>
  ///   Gets or sets the base line alignment.
  /// </summary>
  public BaselineAlignmentKind? BaseLineAlignment { get; set; }

  #endregion

  #region Text Direction and BiDi

  /// <summary>
  ///   Gets or sets the reading order for the paragraph.
  /// </summary>
  public TextDirectionKind? ReadingOrder { get; set; }

  /// <summary>
  ///   Gets or sets the text flow direction.
  /// </summary>
  public TextDirectionKind? TextDirection { get; set; }

  #endregion

  #region Outline Level

  /// <summary>
  ///   Gets or sets the outline level for the paragraph (1-9, or body text).
  /// </summary>
  /// <remarks>
  ///   Outline levels are used for document navigation and table of contents generation.
  ///   Level 1 is the highest, Level 9 is the lowest. Body text has no outline level.
  /// </remarks>
  public OutlineLevelKind? OutlineLevel { get; set; }

  #endregion

  #region Style

  /// <summary>
  ///   Gets or sets the style applied to the paragraph.
  /// </summary>
  public Style? Style { get; set; }

  #endregion

  #region Snapping and Grid

  /// <summary>
  ///   Gets or sets whether to snap to a grid of lines when laying out Asian characters.
  /// </summary>
  public bool? SnapToGrid { get; set; }

  #endregion

  #region Text Frame

  /// <summary>
  ///   Gets or sets whether the paragraph is formatted as a text frame.
  /// </summary>
  public bool? IsTextFrame { get; }

  /// <summary>
  ///   Gets the text frame properties if the paragraph is a text frame.
  /// </summary>
  public FrameProperties? TextFrame { get; }

  #endregion

  #region Methods

  /// <summary>
  ///   Clears all paragraph formatting and returns to default formatting.
  /// </summary>
  public void Reset();

  /// <summary>
  ///   Indents all lines in the paragraph except the first line.
  /// </summary>
  /// <param name="count">Number of characters to indent.</param>
  public void IndentCharWidth(short count);

  /// <summary>
  ///   Indents the first line of the paragraph.
  /// </summary>
  /// <param name="count">Number of characters to indent.</param>
  public void IndentFirstLineCharWidth(short count);

  /// <summary>
  ///   Opens the Paragraph dialog box (in automation scenarios).
  /// </summary>
  public void OpenOrCloseUp();

  /// <summary>
  ///   Adjusts spacing to be the same or different from following paragraph.
  /// </summary>
  public void OpenUp();

  /// <summary>
  ///   Closes up spacing with the next paragraph.
  /// </summary>
  public void CloseUp();

  /// <summary>
  ///   Removes spacing before the paragraph.
  /// </summary>
  public void Space1();

  /// <summary>
  ///   Sets line spacing to 1.5 lines.
  /// </summary>
  public void Space15();

  /// <summary>
  ///   Sets line spacing to double.
  /// </summary>
  public void Space2();

  /// <summary>
  ///   Adds a tab stop at the specified position.
  /// </summary>
  /// <param name="position">Position in points.</param>
  /// <param name="alignment">Tab alignment.</param>
  /// <param name="leader">Leader character.</param>
  public void TabAdd(float position, TabAlignmentKind? alignment = null, TabLeaderKind? leader = null);

  /// <summary>
  ///   Clears a tab stop at the specified position.
  /// </summary>
  /// <param name="position">Position in points.</param>
  public void TabDelete(float position);

  /// <summary>
  ///   Clears all custom tab stops.
  /// </summary>
  public void TabClearAll();

  #endregion

  #region Parent Properties

  /// <summary>
  ///   Gets the parent Range object.
  /// </summary>
  public Range? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }

  /// <summary>
  ///   Gets the duplicate paragraph format object.
  /// </summary>
  public ParagraphFormat? Duplicate { get; }

  #endregion
}