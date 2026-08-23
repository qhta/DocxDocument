using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.Drawings;

/// <summary>
///   Represents formatting properties applied to the last run in a paragraph, including outline, fill, effects, highlight, underline, font, hyperlink, and text direction settings.
/// </summary>
[OpenXmlType(typeof(DXD.EndParagraphRunProperties))]
[DataContract]
[XmlRoot("EndParagraphRunProperties", Namespace = "DocumentModel.Drawings")]
public partial class EndParagraphRunProperties: ModelElement<DXD.EndParagraphRunProperties>, IExtendableElement
{
  /// <summary>
  ///   Outline properties for the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.EndParagraphRunProperties.Outline))]
  public LineProperties? Outline
  {
    get => _Outline ??= GetProperty<LineProperties?>(GetUpdatableElement()?.Outline);
    set => UpdateField(ref _Outline, value, nameof(Outline));
  }

  private LineProperties? _Outline;

  /// <summary>
  ///   Fill properties for the text.
  /// </summary>
  public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

  private Fill? _Fill;

  /// <summary>
  ///   List of effects applied to the text.
  /// </summary>
  public EffectList? EffectList { get => _EffectList; set => UpdateField(ref _EffectList, value, nameof(EffectList)); }

  private EffectList? _EffectList;

  /// <summary>
  ///   Effect DAG (Directed Acyclic Graph) for advanced effect composition.
  /// </summary>
  public EffectDag? EffectDag { get => _EffectDag; set => UpdateField(ref _EffectDag, value, nameof(EffectDag)); }

  private EffectDag? _EffectDag;

  /// <summary>
  ///   Highlight effect for the text.
  /// </summary>
  public Highlight? Highlight { get => _Highlight; set => UpdateField(ref _Highlight, value, nameof(Highlight)); }

  private Highlight? _Highlight;

  /// <summary>
  ///   Indicates whether underline follows the text color.
  /// </summary>
  public bool? UnderlineFollowsText
  {
    get => _UnderlineFollowsText;
    set => UpdateField(ref _UnderlineFollowsText, value, nameof(UnderlineFollowsText));
  }

  private bool? _UnderlineFollowsText;

  /// <summary>
  ///   Underline properties for the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.EndParagraphRunProperties.Underline))]
  public LineProperties? Underline
  {
    get => _Underline ??= GetProperty<LineProperties?>(GetUpdatableElement()?.Underline);
    set => UpdateField(ref _Underline, value, nameof(Underline));
  }

  private LineProperties? _Underline;

  /// <summary>
  ///   Indicates whether underline uses the text fill.
  /// </summary>
  public bool? UnderlineFillText
  {
    get => _UnderlineFillText;
    set => UpdateField(ref _UnderlineFillText, value, nameof(UnderlineFillText));
  }

  private bool? _UnderlineFillText;

  /// <summary>
  ///   Fill properties for the underline.
  /// </summary>
  public Fill? UnderlineFill
  {
    get => _UnderlineFill;
    set => UpdateField(ref _UnderlineFill, value, nameof(UnderlineFill));
  }

  private Fill? _UnderlineFill;

  /// <summary>
  ///   TextFormat settings for Latin text.
  /// </summary>
  public TextFontType? LatinFont { get => _LatinFont; set => UpdateField(ref _LatinFont, value, nameof(LatinFont)); }

  private TextFontType? _LatinFont;

  /// <summary>
  ///   TextFormat settings for East Asian text.
  /// </summary>
  public TextFontType? EastAsianFont
  {
    get => _EastAsianFont;
    set => UpdateField(ref _EastAsianFont, value, nameof(EastAsianFont));
  }

  private TextFontType? _EastAsianFont;

  /// <summary>
  ///   TextFormat settings for complex script text.
  /// </summary>
  public TextFontType? ComplexScriptFont
  {
    get => _ComplexScriptFont;
    set => UpdateField(ref _ComplexScriptFont, value, nameof(ComplexScriptFont));
  }

  private TextFontType? _ComplexScriptFont;

  /// <summary>
  ///   TextFormat settings for symbol text.
  /// </summary>
  public TextFontType? SymbolFont
  {
    get => _SymbolFont;
    set => UpdateField(ref _SymbolFont, value, nameof(SymbolFont));
  }

  private TextFontType? _SymbolFont;

  /// <summary>
  ///   Hyperlink action triggered on click.
  /// </summary>
  public HyperlinkOnClick? HyperlinkOnClick
  {
    get => _HyperlinkOnClick;
    set => UpdateField(ref _HyperlinkOnClick, value, nameof(HyperlinkOnClick));
  }

  private HyperlinkOnClick? _HyperlinkOnClick;

  /// <summary>
  ///   Hyperlink action triggered on mouse over.
  /// </summary>
  public HyperlinkOnMouseOver? HyperlinkOnMouseOver
  {
    get => _HyperlinkOnMouseOver;
    set => UpdateField(ref _HyperlinkOnMouseOver, value, nameof(HyperlinkOnMouseOver));
  }

  private HyperlinkOnMouseOver? _HyperlinkOnMouseOver;

  /// <summary>
  ///   Indicates whether the text direction is right-to-left.
  /// </summary>
  public bool? RightToLeft { get => _RightToLeft; set => UpdateField(ref _RightToLeft, value, nameof(RightToLeft)); }

  private bool? _RightToLeft;

  /// <summary>
  /// List of extension properties for additional or future extensibility.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList;
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private ExtensionList? _ExtensionList;
}