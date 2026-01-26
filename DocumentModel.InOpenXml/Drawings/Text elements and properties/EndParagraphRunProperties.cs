using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.Drawings;
/// <summary>
///   Represents formatting properties applied to the last run in a paragraph, including outline, fill, effects, highlight, underline, font, hyperlink, and text direction settings.
/// </summary>
[OpenXmlType(typeof(DXD.EndParagraphRunProperties))]
public partial class EndParagraphRunProperties : ModelElement<DXD.EndParagraphRunProperties>, IExtendableElement
{
 /// <summary>
 ///   Outline properties for the text.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.EndParagraphRunProperties.Outline))]
 [OpenXmlElement(typeof(DXD.EndParagraphRunProperties))]
 public LineProperties? Outline { get => _Outline; set => UpdateField(ref _Outline, value, nameof(Outline)); }

 private LineProperties? _Outline;
 /// <summary>
 ///   Fill properties for the text.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EndParagraphRunProperties))]
 public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

 private Fill? _Fill;
 /// <summary>
 ///   List of effects applied to the text.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EndParagraphRunProperties))]
 public EffectList? EffectList { get => _EffectList; set => UpdateField(ref _EffectList, value, nameof(EffectList)); }

 private EffectList? _EffectList;
 /// <summary>
 ///   Effect DAG (Directed Acyclic Graph) for advanced effect composition.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EndParagraphRunProperties))]
 public EffectDag? EffectDag { get => _EffectDag; set => UpdateField(ref _EffectDag, value, nameof(EffectDag)); }

 private EffectDag? _EffectDag;
 /// <summary>
 ///   Highlight effect for the text.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EndParagraphRunProperties))]
 public Highlight? Highlight { get => _Highlight; set => UpdateField(ref _Highlight, value, nameof(Highlight)); }

 private Highlight? _Highlight;
 /// <summary>
 ///   Indicates whether underline follows the text color.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EndParagraphRunProperties))]
 public bool? UnderlineFollowsText { get => _UnderlineFollowsText; set => UpdateField(ref _UnderlineFollowsText, value, nameof(UnderlineFollowsText)); }

 private bool? _UnderlineFollowsText;
 /// <summary>
 ///   Underline properties for the text.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.EndParagraphRunProperties.Underline))]
 [OpenXmlElement(typeof(DXD.EndParagraphRunProperties))]
 public LineProperties? Underline { get => _Underline; set => UpdateField(ref _Underline, value, nameof(Underline)); }

 private LineProperties? _Underline;
 /// <summary>
 ///   Indicates whether underline uses the text fill.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EndParagraphRunProperties))]
 public bool? UnderlineFillText { get => _UnderlineFillText; set => UpdateField(ref _UnderlineFillText, value, nameof(UnderlineFillText)); }

 private bool? _UnderlineFillText;
 /// <summary>
 ///   Fill properties for the underline.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EndParagraphRunProperties))]
 public Fill? UnderlineFill { get => _UnderlineFill; set => UpdateField(ref _UnderlineFill, value, nameof(UnderlineFill)); }

 private Fill? _UnderlineFill;
 /// <summary>
 ///   Font settings for Latin text.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EndParagraphRunProperties))]
 public TextFontType? LatinFont { get => _LatinFont; set => UpdateField(ref _LatinFont, value, nameof(LatinFont)); }

 private TextFontType? _LatinFont;
 /// <summary>
 ///   Font settings for East Asian text.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EndParagraphRunProperties))]
 public TextFontType? EastAsianFont { get => _EastAsianFont; set => UpdateField(ref _EastAsianFont, value, nameof(EastAsianFont)); }

 private TextFontType? _EastAsianFont;
 /// <summary>
 ///   Font settings for complex script text.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EndParagraphRunProperties))]
 public TextFontType? ComplexScriptFont { get => _ComplexScriptFont; set => UpdateField(ref _ComplexScriptFont, value, nameof(ComplexScriptFont)); }

 private TextFontType? _ComplexScriptFont;
 /// <summary>
 ///   Font settings for symbol text.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EndParagraphRunProperties))]
 public TextFontType? SymbolFont { get => _SymbolFont; set => UpdateField(ref _SymbolFont, value, nameof(SymbolFont)); }

 private TextFontType? _SymbolFont;
 /// <summary>
 ///   Hyperlink action triggered on click.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EndParagraphRunProperties))]
 public HyperlinkOnClick? HyperlinkOnClick { get => _HyperlinkOnClick; set => UpdateField(ref _HyperlinkOnClick, value, nameof(HyperlinkOnClick)); }

 private HyperlinkOnClick? _HyperlinkOnClick;
 /// <summary>
 ///   Hyperlink action triggered on mouse over.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EndParagraphRunProperties))]
 public HyperlinkOnMouseOver? HyperlinkOnMouseOver { get => _HyperlinkOnMouseOver; set => UpdateField(ref _HyperlinkOnMouseOver, value, nameof(HyperlinkOnMouseOver)); }

 private HyperlinkOnMouseOver? _HyperlinkOnMouseOver;
 /// <summary>
 ///   Indicates whether the text direction is right-to-left.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EndParagraphRunProperties))]
 public bool? RightToLeft { get => _RightToLeft; set => UpdateField(ref _RightToLeft, value, nameof(RightToLeft)); }

 private bool? _RightToLeft;
 /// <summary>
 /// List of extension properties for additional or future extensibility.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EndParagraphRunProperties))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

 private ExtensionList? _ExtensionList;
}