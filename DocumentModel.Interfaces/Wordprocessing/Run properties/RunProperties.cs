using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Run Properties interface for formatting text runs in WordprocessingML documents.
/// </summary>
/// <remarks>
///   <para>
///   RunProperties provides complete control over character-level formatting including
///   font name, size, style, color, spacing, effects, and Office 2010+ advanced typography features.
///   </para>
///   <para>
///   This interface corresponds to the DocumentFormat.OpenXml.Wordprocessing.RunProperties class
///   and contains all properties for comprehensive run formatting.
///   </para>
/// </remarks>
public interface RunProperties
{
  /// <summary>
  ///   Gets or sets the run style identifier.
  /// </summary>
  /// <remarks>
  ///   References a style defined in the document's styles part.
  /// </remarks>
  public string? RunStyle { get; set; }

  /// <summary>
  ///   Gets or sets the run fonts for different character ranges.
  /// </summary>
  /// <remarks>
  ///   Specifies fonts for ASCII, Far East, Complex Script, and other character ranges.
  /// </remarks>
  public RunFonts? RunFonts { get; set; }

  /// <summary>
  ///   Gets or sets whether the run text is bold.
  /// </summary>
  public bool? Bold { get; set; }

  /// <summary>
  ///   Gets or sets whether complex script text in the run is bold.
  /// </summary>
  public bool? BoldComplexScript { get; set; }

  /// <summary>
  ///   Gets or sets whether the run text is italic.
  /// </summary>
  public bool? Italic { get; set; }

  /// <summary>
  ///   Gets or sets whether complex script text in the run is italic.
  /// </summary>
  public bool? ItalicComplexScript { get; set; }

  /// <summary>
  ///   Gets or sets whether all text is formatted as capital letters.
  /// </summary>
  /// <remarks>
  ///   Only affects display, not the actual character values.
  /// </remarks>
  public bool? Caps { get; set; }

  /// <summary>
  ///   Gets or sets whether all text is formatted as small capital letters.
  /// </summary>
  /// <remarks>
  ///   Small caps are capital letters in a smaller font size.
  /// </remarks>
  public bool? SmallCaps { get; set; }

  /// <summary>
  ///   Gets or sets whether text has strikethrough.
  /// </summary>
  public bool? Strike { get; set; }

  /// <summary>
  ///   Gets or sets whether text has double strikethrough.
  /// </summary>
  public bool? DoubleStrike { get; set; }

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
  ///   Gets or sets whether text has imprint (engrave) effect.
  /// </summary>
  public bool? Imprint { get; set; }

  /// <summary>
  ///   Gets or sets whether to skip spell checking and grammar checking.
  /// </summary>
  public bool? NoProof { get; set; }

  /// <summary>
  ///   Gets or sets whether to snap text to document grid.
  /// </summary>
  public bool? SnapToGrid { get; set; }

  /// <summary>
  ///   Gets or sets whether text is hidden from display.
  /// </summary>
  public bool? Vanish { get; set; }

  /// <summary>
  ///   Gets or sets whether text is hidden in web page view.
  /// </summary>
  public bool? WebHidden { get; set; }

  /// <summary>
  ///   Gets or sets the text color.
  /// </summary>
  public Color? Color { get; set; }

  /// <summary>
  ///   Gets or sets the character spacing in twentieths of a point.
  /// </summary>
  /// <remarks>
  ///   Positive values expand spacing, negative values condense spacing.
  /// </remarks>
  public int? Spacing { get; set; }

  /// <summary>
  ///   Gets or sets the character width scaling percentage.
  /// </summary>
  /// <remarks>
  ///   100 is normal width. Values less than 100 condense, greater than 100 expand.
  /// </remarks>
  public int? CharacterScale { get; set; }

  /// <summary>
  ///   Gets or sets the minimum font size for automatic kerning in half-points.
  /// </summary>
  public uint? Kern { get; set; }

  /// <summary>
  ///   Gets or sets the text position relative to baseline.
  /// </summary>
  /// <remarks>
  ///   Positive values raise text, negative values lower text.
  ///   Value is in half-points.
  /// </remarks>
  public string? Position { get; set; }

  /// <summary>
  ///   Gets or sets the font size in half-points.
  /// </summary>
  public string? FontSize { get; set; }

  /// <summary>
  ///   Gets or sets the font size for complex script text in half-points.
  /// </summary>
  public string? FontSizeComplexScript { get; set; }

  /// <summary>
  ///   Gets or sets the highlight color.
  /// </summary>
  public HighlightColorKind? Highlight { get; set; }

  /// <summary>
  ///   Gets or sets the underline style and color.
  /// </summary>
  public Underline? Underline { get; set; }

  /// <summary>
  ///   Gets or sets the animated text effect.
  /// </summary>
  public TextEffectKind? TextEffect { get; set; }

  /// <summary>
  ///   Gets or sets the border for the run.
  /// </summary>
  public BorderType? Border { get; set; }

  /// <summary>
  ///   Gets or sets the shading (background) for the run.
  /// </summary>
  public Shading? Shading { get; set; }

  /// <summary>
  ///   Gets or sets the fit text properties.
  /// </summary>
  /// <remarks>
  ///   Specifies fixed width for text, adjusting character width to fit.
  /// </remarks>
  public FitText? FitText { get; set; }

  /// <summary>
  ///   Gets or sets the vertical text alignment (subscript/superscript).
  /// </summary>
  public VerticalPositionKind? VerticalTextAlignment { get; set; }

  /// <summary>
  ///   Gets or sets whether text direction is right-to-left.
  /// </summary>
  public bool? RightToLeftText { get; set; }

  /// <summary>
  ///   Gets or sets whether text uses complex script formatting.
  /// </summary>
  public bool? ComplexScript { get; set; }

  /// <summary>
  ///   Gets or sets the emphasis mark type.
  /// </summary>
  public EmphasisMarkKind? Emphasis { get; set; }

  /// <summary>
  ///   Gets or sets the language settings for spell checking and grammar.
  /// </summary>
  public LanguageType? Languages { get; set; }

  /// <summary>
  ///   Gets or sets the East Asian typography settings.
  /// </summary>
  /// <remarks>
  ///   Includes two lines in one and vertical text settings.
  /// </remarks>
  public EastAsianLayout? EastAsianLayout { get; set; }

  /// <summary>
  ///   Gets or sets whether text is always hidden (for paragraph marks).
  /// </summary>
  /// <remarks>
  ///   Used to hide paragraph marks while still applying paragraph formatting.
  /// </remarks>
  public bool? SpecVanish { get; set; }

  /// <summary>
  ///   Gets or sets the glow effect (Office 2010+).
  /// </summary>
  public DMWD.Glow? Glow { get; set; }

  /// <summary>
  ///   Gets or sets the shadow effect (Office 2010+).
  /// </summary>
  public DMWD.Shadow? Shadow14 { get; set; }

  /// <summary>
  ///   Gets or sets the reflection effect (Office 2010+).
  /// </summary>
  public DMWD.Reflection? Reflection { get; set; }

  /// <summary>
  ///   Gets or sets the text outline effect (Office 2010+).
  /// </summary>
  public DMWD.TextOutlineEffect? TextOutlineEffect { get; set; }

  /// <summary>
  ///   Gets or sets the text fill effect (Office 2010+).
  /// </summary>
  public FillTextEffect? FillTextEffect { get; set; }

  /// <summary>
  ///   Gets or sets the 3D scene properties (Office 2010+).
  /// </summary>
  public DMWD.Scene3D? Scene3D { get; set; }

  /// <summary>
  ///   Gets or sets the 3D text properties (Office 2010+).
  /// </summary>
  public DMWD.Properties3D? Properties3D { get; set; }

  /// <summary>
  ///   Gets or sets the OpenType ligatures setting (Office 2010+).
  /// </summary>
  /// <remarks>
  ///   Controls which ligatures are used in OpenType fonts.
  /// </remarks>
  public LigaturesKind? Ligatures { get; set; }

  /// <summary>
  ///   Gets or sets the number form for OpenType fonts (Office 2010+).
  /// </summary>
  /// <remarks>
  ///   Specifies lining or old-style numerals.
  /// </remarks>
  public NumberFormKind? NumberingFormat { get; set; }

  /// <summary>
  ///   Gets or sets the number spacing for OpenType fonts (Office 2010+).
  /// </summary>
  /// <remarks>
  ///   Specifies proportional or tabular spacing for numbers.
  /// </remarks>
  public NumberSpacingKind? NumberSpacing { get; set; }

  /// <summary>
  ///   Gets or sets the stylistic sets collection (Office 2010+).
  /// </summary>
  /// <remarks>
  ///   OpenType fonts may include alternate glyph sets.
  /// </remarks>
  public StylisticSets? StylisticSets { get; set; }

  /// <summary>
  ///   Gets or sets whether to use contextual alternates (Office 2010+).
  /// </summary>
  /// <remarks>
  ///   OpenType feature that adjusts glyphs based on surrounding characters.
  /// </remarks>
  public OnOffKind? ContextualAlternatives { get; set; }

  /// <summary>
  ///   Gets or sets the run properties change tracking information.
  /// </summary>
  /// <remarks>
  ///   Records the previous state of run properties when changes are tracked.
  /// </remarks>
  public RunPropertiesChange? RunPropertiesChange { get; set; }
}