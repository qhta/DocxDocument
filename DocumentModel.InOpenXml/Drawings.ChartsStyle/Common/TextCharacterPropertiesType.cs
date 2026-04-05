namespace DocumentModel.Drawings.ChartsStyle;
/// <summary>
/// Describes character-level formatting properties for text in chart elements, including font, style, language, effects, and hyperlinks.
/// </summary>
[OpenXmlType(typeof(DXO13DCS.TextCharacterPropertiesType))]
public partial class TextCharacterPropertiesType: ModelElement<DXO13DCS.TextCharacterPropertiesType>
{
  /// <summary>
  /// Indicates if the smart tag is clean (backwards compatibility).
  /// </summary>
  [OpenXmlElement(typeof(DXD.Outline))]
  public bool? SmtClean { get => _SmtClean; set => UpdateField(ref _SmtClean, value, nameof(SmtClean)); }
  private bool? _SmtClean;
  /// <summary>
  /// Identifier for the smart tag (backwards compatibility).
  /// </summary>
  [OpenXmlElement(typeof(DXD.NoFill))]
  public UInt32? SmtId { get => _SmtId; set => UpdateField(ref _SmtId, value, nameof(SmtId)); }
  private UInt32? _SmtId;
  /// <summary>
  /// Indicates if the text uses kumimoji (grouped characters).
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.Kumimoji))]
  public bool? Kumimoji { get => _Kumimoji; set => UpdateField(ref _Kumimoji, value, nameof(Kumimoji)); }
  private bool? _Kumimoji;
  /// <summary>
  /// Language code for the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.Language))]
  public string? Language { get => _Language; set => UpdateField(ref _Language, value, nameof(Language)); }
  private string? _Language;
  /// <summary>
  /// Alternative language code for the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.AlternativeLanguage))]
  public string? AlternativeLanguage
  {
    get => _AlternativeLanguage;
    set => UpdateField(ref _AlternativeLanguage, value, nameof(AlternativeLanguage));
  }
  private string? _AlternativeLanguage;
  /// <summary>
  /// TextFormat size for the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.FontSize))]
  public Int32? FontSize { get => _FontSize; set => UpdateField(ref _FontSize, value, nameof(FontSize)); }
  private Int32? _FontSize;
  /// <summary>
  /// Indicates if the text is bold.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.Bold))]
  public bool? Bold { get => _Bold; set => UpdateField(ref _Bold, value, nameof(Bold)); }
  private bool? _Bold;
  /// <summary>
  /// Indicates if the text is italic.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.Italic))]
  public bool? Italic { get => _Italic; set => UpdateField(ref _Italic, value, nameof(Italic)); }
  private bool? _Italic;
  /// <summary>
  /// Underline style for the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.Underline))]
  public TextUnderline? Underline { get => _Underline; set => UpdateField(ref _Underline, value, nameof(Underline)); }
  private TextUnderline? _Underline;
  /// <summary>
  /// Strike-through style for the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.Strike))]
  public TextStrike? Strike { get => _Strike; set => UpdateField(ref _Strike, value, nameof(Strike)); }
  private TextStrike? _Strike;
  /// <summary>
  /// Kerning value for the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.Kerning))]
  public Int32? Kerning { get => _Kerning; set => UpdateField(ref _Kerning, value, nameof(Kerning)); }
  private Int32? _Kerning;
  /// <summary>
  /// Capitalization style for the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.Capital))]
  public TextCaps? Capital { get => _Capital; set => UpdateField(ref _Capital, value, nameof(Capital)); }
  private TextCaps? _Capital;
  /// <summary>
  /// Spacing value between characters.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.Spacing))]
  public Int32? Spacing { get => _Spacing; set => UpdateField(ref _Spacing, value, nameof(Spacing)); }
  private Int32? _Spacing;
  /// <summary>
  /// Indicates if the text height is normalized.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.NormalizeHeight))]
  public bool? NormalizeHeight
  {
    get => _NormalizeHeight;
    set => UpdateField(ref _NormalizeHeight, value, nameof(NormalizeHeight));
  }
  private bool? _NormalizeHeight;
  /// <summary>
  /// Baseline offset for the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.Baseline))]
  public Int32? Baseline { get => _Baseline; set => UpdateField(ref _Baseline, value, nameof(Baseline)); }
  private Int32? _Baseline;
  /// <summary>
  /// Indicates if proofing is disabled for the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.NoProof))]
  public bool? NoProof { get => _NoProof; set => UpdateField(ref _NoProof, value, nameof(NoProof)); }
  private bool? _NoProof;
  /// <summary>
  /// Indicates if the text is marked as dirty (needs reprocessing).
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.Dirty))]
  public bool? Dirty { get => _Dirty; set => UpdateField(ref _Dirty, value, nameof(Dirty)); }
  private bool? _Dirty;
  /// <summary>
  /// Indicates if the text contains a spelling error.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.SpellingError))]
  public bool? SpellingError
  {
    get => _SpellingError;
    set => UpdateField(ref _SpellingError, value, nameof(SpellingError));
  }
  private bool? _SpellingError;
  /// <summary>
  /// Indicates if the smart tag is clean (alternative property).
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.SmartTagClean))]
  public bool? SmartTagClean
  {
    get => _SmartTagClean;
    set => UpdateField(ref _SmartTagClean, value, nameof(SmartTagClean));
  }
  private bool? _SmartTagClean;
  /// <summary>
  /// Identifier for the smart tag (alternative property).
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.SmartTagId))]
  public UInt32? SmartTagId { get => _SmartTagId; set => UpdateField(ref _SmartTagId, value, nameof(SmartTagId)); }
  private UInt32? _SmartTagId;
  /// <summary>
  /// Bookmark name associated with the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.Bookmark))]
  public string? Bookmark { get => _Bookmark; set => UpdateField(ref _Bookmark, value, nameof(Bookmark)); }
  private string? _Bookmark;
  /// <summary>
  /// Outline properties for the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextCharacterPropertiesType.Outline))]
  public LineProperties? Outline { get => _Outline; set => UpdateField(ref _Outline, value, nameof(Outline)); }
  private LineProperties? _Outline;
  /// <summary>
  /// Fill properties for the text.
  /// </summary>
  [OpenXmlElement(typeof(DXD.NoFill))]
  public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }
  private Fill? _Fill;
  /// <summary>
  /// List of effects applied to the text.
  /// </summary>
  [OpenXmlElement(typeof(DXD.EffectList))]
  public EffectList? EffectList { get => _EffectList; set => UpdateField(ref _EffectList, value, nameof(EffectList)); }
  private EffectList? _EffectList;
  /// <summary>
  /// Effect DAG (Directed Acyclic Graph) for advanced text effects.
  /// </summary>
  [OpenXmlElement(typeof(DXD.EffectDag))]
  public EffectDag? EffectDag { get => _EffectDag; set => UpdateField(ref _EffectDag, value, nameof(EffectDag)); }
  private EffectDag? _EffectDag;
  /// <summary>
  /// Highlight formatting for the text.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Highlight))]
  public Highlight? Highlight { get => _Highlight; set => UpdateField(ref _Highlight, value, nameof(Highlight)); }
  private Highlight? _Highlight;
  /// <summary>
  /// Indicates if underline follows the text formatting.
  /// </summary>
  [OpenXmlElement(typeof(DXD.UnderlineFollowsText))]
  public bool? UnderlineFollowsText
  {
    get => _UnderlineFollowsText;
    set => UpdateField(ref _UnderlineFollowsText, value, nameof(UnderlineFollowsText));
  }
  private bool? _UnderlineFollowsText;
  /// <summary>
  /// Indicates if underline uses the text fill.
  /// </summary>
  [OpenXmlElement(typeof(DXD.UnderlineFillText))]
  public bool? UnderlineFillText
  {
    get => _UnderlineFillText;
    set => UpdateField(ref _UnderlineFillText, value, nameof(UnderlineFillText));
  }
  private bool? _UnderlineFillText;
  /// <summary>
  /// Fill properties for the underline.
  /// </summary>
  [OpenXmlElement(typeof(DXD.UnderlineFill))]
  public Fill? UnderlineFill
  {
    get => _UnderlineFill;
    set => UpdateField(ref _UnderlineFill, value, nameof(UnderlineFill));
  }
  private Fill? _UnderlineFill;
  /// <summary>
  /// Latin font settings for the text.
  /// </summary>
  [OpenXmlElement(typeof(DXD.LatinFont))]
  public TextFontType? LatinFont { get => _LatinFont; set => UpdateField(ref _LatinFont, value, nameof(LatinFont)); }
  private TextFontType? _LatinFont;
  /// <summary>
  /// East Asian font settings for the text.
  /// </summary>
  [OpenXmlElement(typeof(DXD.EastAsianFont))]
  public TextFontType? EastAsianFont
  {
    get => _EastAsianFont;
    set => UpdateField(ref _EastAsianFont, value, nameof(EastAsianFont));
  }
  private TextFontType? _EastAsianFont;
  /// <summary>
  /// Complex script font settings for the text.
  /// </summary>
  [OpenXmlElement(typeof(DXD.ComplexScriptFont))]
  public TextFontType? ComplexScriptFont
  {
    get => _ComplexScriptFont;
    set => UpdateField(ref _ComplexScriptFont, value, nameof(ComplexScriptFont));
  }
  private TextFontType? _ComplexScriptFont;
  /// <summary>
  /// Symbol font settings for the text.
  /// </summary>
  [OpenXmlElement(typeof(DXD.SymbolFont))]
  public TextFontType? SymbolFont
  {
    get => _SymbolFont;
    set => UpdateField(ref _SymbolFont, value, nameof(SymbolFont));
  }
  private TextFontType? _SymbolFont;
  /// <summary>
  /// Hyperlink settings for click events.
  /// </summary>
  [OpenXmlElement(typeof(DXD.HyperlinkOnClick))]
  public HyperlinkOnClick? HyperlinkOnClick
  {
    get => _HyperlinkOnClick;
    set => UpdateField(ref _HyperlinkOnClick, value, nameof(HyperlinkOnClick));
  }
  private HyperlinkOnClick? _HyperlinkOnClick;
  /// <summary>
  /// Hyperlink settings for mouse-over events.
  /// </summary>
  [OpenXmlElement(typeof(DXD.HyperlinkOnMouseOver))]
  public HyperlinkOnMouseOver? HyperlinkOnMouseOver
  {
    get => _HyperlinkOnMouseOver;
    set => UpdateField(ref _HyperlinkOnMouseOver, value, nameof(HyperlinkOnMouseOver));
  }
  private HyperlinkOnMouseOver? _HyperlinkOnMouseOver;
  /// <summary>
  /// Indicates if the text is rendered right-to-left.
  /// </summary>
  [OpenXmlElement(typeof(DXD.RightToLeft))]
  public bool? RightToLeft { get => _RightToLeft; set => UpdateField(ref _RightToLeft, value, nameof(RightToLeft)); }
  private bool? _RightToLeft;
  /// <summary>
  /// Extension list for additional character properties.
  /// </summary>
  [OpenXmlElement(typeof(DXD.ExtensionList))]
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList;
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }
  private ExtensionList? _ExtensionList;
}