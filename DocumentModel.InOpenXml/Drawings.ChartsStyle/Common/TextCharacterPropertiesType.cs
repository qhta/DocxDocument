namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
/// Describes character-level formatting properties for text in chart elements, including font, style, language, effects, and hyperlinks.
/// </summary>
public class TextCharacterPropertiesType
{
  /// <summary>
  /// Indicates if the smart tag is clean (backwards compatibility).
  /// </summary>
  public bool? SmtClean { get; set; }

  /// <summary>
  /// Identifier for the smart tag (backwards compatibility).
  /// </summary>
  public UInt32? SmtId { get; set; }

  /// <summary>
  /// Indicates if the text uses kumimoji (grouped characters).
  /// </summary>
  public bool? Kumimoji { get; set; }

  /// <summary>
  /// Language code for the text.
  /// </summary>
  public string? Language { get; set; }

  /// <summary>
  /// Alternative language code for the text.
  /// </summary>
  public string? AlternativeLanguage { get; set; }

  /// <summary>
  /// Font size for the text.
  /// </summary>
  public Int32? FontSize { get; set; }

  /// <summary>
  /// Indicates if the text is bold.
  /// </summary>
  public bool? Bold { get; set; }

  /// <summary>
  /// Indicates if the text is italic.
  /// </summary>
  public bool? Italic { get; set; }

  /// <summary>
  /// Underline style for the text.
  /// </summary>
  public TextUnderline? Underline { get; set; }

  /// <summary>
  /// Strike-through style for the text.
  /// </summary>
  public TextStrike? Strike { get; set; }

  /// <summary>
  /// Kerning value for the text.
  /// </summary>
  public Int32? Kerning { get; set; }

  /// <summary>
  /// Capitalization style for the text.
  /// </summary>
  public TextCaps? Capital { get; set; }

  /// <summary>
  /// Spacing value between characters.
  /// </summary>
  public Int32? Spacing { get; set; }

  /// <summary>
  /// Indicates if the text height is normalized.
  /// </summary>
  public bool? NormalizeHeight { get; set; }

  /// <summary>
  /// Baseline offset for the text.
  /// </summary>
  public Int32? Baseline { get; set; }

  /// <summary>
  /// Indicates if proofing is disabled for the text.
  /// </summary>
  public bool? NoProof { get; set; }

  /// <summary>
  /// Indicates if the text is marked as dirty (needs reprocessing).
  /// </summary>
  public bool? Dirty { get; set; }

  /// <summary>
  /// Indicates if the text contains a spelling error.
  /// </summary>
  public bool? SpellingError { get; set; }

  /// <summary>
  /// Indicates if the smart tag is clean (alternative property).
  /// </summary>
  public bool? SmartTagClean { get; set; }

  /// <summary>
  /// Identifier for the smart tag (alternative property).
  /// </summary>
  public UInt32? SmartTagId { get; set; }

  /// <summary>
  /// Bookmark name associated with the text.
  /// </summary>
  public string? Bookmark { get; set; }

  /// <summary>
  /// Outline properties for the text.
  /// </summary>
  public LineProperties? Outline { get; set; }

  /// <summary>
  /// Fill properties for the text.
  /// </summary>
  public Fill? Fill { get; set; }

  /// <summary>
  /// List of effects applied to the text.
  /// </summary>
  public EffectList? EffectList { get; set; }

  /// <summary>
  /// Effect DAG (Directed Acyclic Graph) for advanced text effects.
  /// </summary>
  public EffectDag? EffectDag { get; set; }

  /// <summary>
  /// Highlight formatting for the text.
  /// </summary>
  public Highlight? Highlight { get; set; }

  /// <summary>
  /// Indicates if underline follows the text formatting.
  /// </summary>
  public bool? UnderlineFollowsText { get; set; }

  /// <summary>
  /// Indicates if underline uses the text fill.
  /// </summary>
  public bool? UnderlineFillText { get; set; }

  /// <summary>
  /// Fill properties for the underline.
  /// </summary>
  public Fill? UnderlineFill { get; set; }

  /// <summary>
  /// Latin font settings for the text.
  /// </summary>
  public TextFontType? LatinFont { get; set; }

  /// <summary>
  /// East Asian font settings for the text.
  /// </summary>
  public TextFontType? EastAsianFont { get; set; }

  /// <summary>
  /// Complex script font settings for the text.
  /// </summary>
  public TextFontType? ComplexScriptFont { get; set; }

  /// <summary>
  /// Symbol font settings for the text.
  /// </summary>
  public TextFontType? SymbolFont { get; set; }

  /// <summary>
  /// Hyperlink settings for click events.
  /// </summary>
  public HyperlinkOnClick? HyperlinkOnClick { get; set; }

  /// <summary>
  /// Hyperlink settings for mouse-over events.
  /// </summary>
  public HyperlinkOnMouseOver? HyperlinkOnMouseOver { get; set; }

  /// <summary>
  /// Indicates if the text is rendered right-to-left.
  /// </summary>
  public bool? RightToLeft { get; set; }

  /// <summary>
  /// Extension list for additional character properties.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}