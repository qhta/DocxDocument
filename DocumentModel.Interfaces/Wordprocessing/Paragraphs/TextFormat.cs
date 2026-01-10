namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents all character formatting (font) attributes that can be applied to text.
/// </summary>
/// <remarks>
///   <para>
///   TextFormat provides complete control over character-level formatting including
///   font name, size, style, color, spacing, position, and effects.
///   </para>
///   <para>
///   This interface corresponds to the Microsoft.Office.Interop.Word.Font interface
///   and provides comprehensive text formatting capabilities.
///   </para>
/// </remarks>
public interface TextFormat
{
  #region Font Properties

  /// <summary>
  ///   Gets or sets the font name.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   Gets or sets the font name for ASCII characters.
  /// </summary>
  public string? NameASCII { get; set; }

  /// <summary>
  ///   Gets or sets the font name for Far East characters.
  /// </summary>
  public string? NameFarEast { get; set; }

  /// <summary>
  ///   Gets or sets the font name for other (non-ASCII, non-Far East) characters.
  /// </summary>
  public string? NameOther { get; set; }

  /// <summary>
  ///   Gets or sets the font name for bidirectional text.
  /// </summary>
  public string? NameBi { get; set; }

  #endregion

  #region Size

  /// <summary>
  ///   Gets or sets the font size in points.
  /// </summary>
  public float Size { get; set; }

  /// <summary>
  ///   Gets or sets the font size for bidirectional text in points.
  /// </summary>
  public float SizeBi { get; set; }

  /// <summary>
  ///   Increases the font size to the next available size.
  /// </summary>
  public void Grow();

  /// <summary>
  ///   Decreases the font size to the previous available size.
  /// </summary>
  public void Shrink();

  #endregion

  #region Style

  /// <summary>
  ///   Gets or sets whether text is bold.
  /// </summary>
  public bool? Bold { get; set; }

  /// <summary>
  ///   Gets or sets whether bidirectional text is bold.
  /// </summary>
  public bool? BoldBi { get; set; }

  /// <summary>
  ///   Gets or sets whether text is italic.
  /// </summary>
  public bool? Italic { get; set; }

  /// <summary>
  ///   Gets or sets whether bidirectional text is italic.
  /// </summary>
  public bool? ItalicBi { get; set; }

  /// <summary>
  ///   Gets or sets the underline type.
  /// </summary>
  public UnderlineKind? Underline { get; set; }

  /// <summary>
  ///   Gets or sets the underline color.
  /// </summary>
  public Color? UnderlineColor { get; set; }

  /// <summary>
  ///   Gets or sets whether text has strikethrough.
  /// </summary>
  public bool? StrikeThrough { get; set; }

  /// <summary>
  ///   Gets or sets whether text has double strikethrough.
  /// </summary>
  public bool? DoubleStrikeThrough { get; set; }

  /// <summary>
  ///   Gets or sets whether text is hidden.
  /// </summary>
  public bool? Hidden { get; set; }

  #endregion

  #region Color

  /// <summary>
  ///   Gets or sets the text color.
  /// </summary>
  /// <remarks>
  ///   Can be set using RGB values or Word color constants.
  /// </remarks>
  public Color? Color { get; set; }

  /// <summary>
  ///   Gets or sets the color index (for compatibility).
  /// </summary>
  public ColorIndexKind? ColorIndex { get; set; }

  #endregion

  #region Capitalization

  /// <summary>
  ///   Gets or sets whether all letters are formatted as capital letters.
  /// </summary>
  /// <remarks>
  ///   This only affects display, not the actual character values.
  /// </remarks>
  public bool? AllCaps { get; set; }

  /// <summary>
  ///   Gets or sets whether all letters are formatted as small capital letters.
  /// </summary>
  /// <remarks>
  ///   Small caps are capital letters that are slightly smaller than regular capitals.
  /// </remarks>
  public bool? SmallCaps { get; set; }

  #endregion

  #region Position and Spacing

  /// <summary>
  ///   Gets or sets the position of text relative to the baseline in points.
  /// </summary>
  /// <remarks>
  ///   Positive values raise text above the baseline, negative values lower it.
  /// </remarks>
  public float Position { get; set; }

  /// <summary>
  ///   Gets or sets the character spacing in points.
  /// </summary>
  /// <remarks>
  ///   Positive values expand spacing, negative values condense spacing.
  /// </remarks>
  public float Spacing { get; set; }

  /// <summary>
  ///   Gets or sets the character scaling percentage.
  /// </summary>
  /// <remarks>
  ///   100 is normal, less than 100 condenses characters, greater than 100 expands them.
  /// </remarks>
  public float Scaling { get; set; }

  /// <summary>
  ///   Gets or sets whether character kerning is enabled.
  /// </summary>
  public bool? Kerning { get; set; }

  /// <summary>
  ///   Gets or sets the minimum font size for automatic kerning.
  /// </summary>
  public float AutoKerning { get; set; }

  #endregion

  #region Subscript and Superscript

  /// <summary>
  ///   Gets or sets whether text is formatted as subscript.
  /// </summary>
  public bool? Subscript { get; set; }

  /// <summary>
  ///   Gets or sets whether text is formatted as superscript.
  /// </summary>
  public bool? Superscript { get; set; }

  #endregion

  #region Effects

  /// <summary>
  ///   Gets or sets whether text has outline effect.
  /// </summary>
  public bool? Outline { get; set; }

  /// <summary>
  ///   Gets or sets whether text has shadow effect.
  /// </summary>
  public bool? Shadow { get; set; }

  /// <summary>
  ///   Gets or sets whether text has emboss effect.
  /// </summary>
  public bool? Emboss { get; set; }

  /// <summary>
  ///   Gets or sets whether text has engrave (imprint) effect.
  /// </summary>
  public bool? Engrave { get; set; }

  /// <summary>
  ///   Gets or sets the animation effect.
  /// </summary>
  public TextEffectKind? Animation { get; set; }

  /// <summary>
  ///   Gets or sets the emphasis mark.
  /// </summary>
  public EmphasisMarkKind? EmphasisMark { get; set; }

  #endregion

  #region Highlighting

  /// <summary>
  ///   Gets or sets the highlight color.
  /// </summary>
  public HighlightColorKind? HighlightColor { get; set; }

  /// <summary>
  ///   Gets or sets the highlight color index.
  /// </summary>
  public ColorIndexKind? HighlightColorIndex { get; set; }

  #endregion

  #region Shading

  /// <summary>
  ///   Gets the shading object for background patterns and colors.
  /// </summary>
  public DMWD.Shading? Shading { get; }

  #endregion

  #region Borders

  /// <summary>
  ///   Gets the borders collection for character borders.
  /// </summary>
  public BorderType? Borders { get; }

  #endregion

  #region Asian Typography

  /// <summary>
  ///   Gets or sets whether to use two lines in one.
  /// </summary>
  /// <remarks>
  ///   Displays text in two rows within a single line.
  /// </remarks>
  public bool? TwoLinesInOne { get; set; }

  /// <summary>
  ///   Gets or sets the bracket character for two lines in one.
  /// </summary>
  public TwoLinesInOneBracketKind? TwoLinesInOneBracket { get; set; }

  /// <summary>
  ///   Gets or sets whether to use horizontal text within vertical text.
  /// </summary>
  public bool? Horizontal { get; set; }

  /// <summary>
  ///   Gets or sets whether to use vertical compressed text (tatechuyoko).
  /// </summary>
  public bool? VerticalCompressedText { get; set; }

  #endregion

  #region Language and Proofing

  /// <summary>
  ///   Gets or sets the language ID for the text.
  /// </summary>
  /// <remarks>
  ///   Determines which language to use for spell checking and grammar.
  /// </remarks>
  public int? LanguageID { get; set; }

  /// <summary>
  ///   Gets or sets the language ID for Far East text.
  /// </summary>
  public int? LanguageIDFarEast { get; set; }

  /// <summary>
  ///   Gets or sets the language ID for bidirectional text.
  /// </summary>
  public int? LanguageIDBi { get; set; }

  /// <summary>
  ///   Gets or sets whether to skip spell checking and grammar checking.
  /// </summary>
  public bool? NoProofing { get; set; }

  #endregion

  #region Ligatures and Number Forms

  /// <summary>
  ///   Gets or sets the ligatures setting.
  /// </summary>
  public LigaturesKind? Ligatures { get; set; }

  /// <summary>
  ///   Gets or sets the number form.
  /// </summary>
  public NumberFormKind? NumberForm { get; set; }

  /// <summary>
  ///   Gets or sets the number spacing.
  /// </summary>
  public NumberSpacingKind? NumberSpacing { get; set; }

  #endregion

  #region Stylistic Sets

  /// <summary>
  ///   Gets or sets the stylistic set.
  /// </summary>
  /// <remarks>
  ///   OpenType fonts may include alternate glyph shapes organized in stylistic sets.
  /// </remarks>
  public StylisticSetKind? StylisticSet { get; set; }

  #endregion

  #region Context Alternates

  /// <summary>
  ///   Gets or sets whether to use contextual alternates.
  /// </summary>
  /// <remarks>
  ///   OpenType fonts may adjust letter shapes based on surrounding letters.
  /// </remarks>
  public bool? ContextualAlternates { get; set; }

  #endregion

  #region Methods

  /// <summary>
  ///   Resets all formatting to default values.
  /// </summary>
  public void Reset();

  /// <summary>
  ///   Sets the font to a specific range of formatting.
  /// </summary>
  /// <param name="which">Which font properties to apply.</param>
  public void SetRange(FontPropertiesKind which);

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
  ///   Gets a duplicate of the current font object.
  /// </summary>
  public TextFormat? Duplicate { get; }

  #endregion
}