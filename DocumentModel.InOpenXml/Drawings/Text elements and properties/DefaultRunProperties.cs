namespace DocumentModel.Drawings;

/// <summary>
///   Represents default formatting properties for text runs, including outline, fill, effects, highlight, underline, font, hyperlink, and text direction settings.
/// </summary>
public class DefaultRunProperties : ModelElement<DXD.DefaultRunProperties>, IExtendableElement
{
  /// <summary>
  ///   Outline properties for the text run.
  /// </summary>
  public LineProperties? Outline { get; set; }

  /// <summary>
  ///   Fill properties for the text run.
  /// </summary>
  public Fill? Fill { get; set; }

  /// <summary>
  ///   List of effects applied to the text run.
  /// </summary>
  public EffectList? EffectList { get; set; }

  /// <summary>
  ///   Effect DAG (Directed Acyclic Graph) for advanced effect composition.
  /// </summary>
  public EffectDag? EffectDag { get; set; }

  /// <summary>
  ///   Highlight effect for the text run.
  /// </summary>
  public Highlight? Highlight { get; set; }

  /// <summary>
  ///   Indicates whether underline follows the text color.
  /// </summary>
  public bool? UnderlineFollowsText { get; set; }

  /// <summary>
  ///   Underline properties for the text run.
  /// </summary>
  public LineProperties? Underline { get; set; }

  /// <summary>
  ///   Indicates whether underline uses the text fill.
  /// </summary>
  public bool? UnderlineFillText { get; set; }

  /// <summary>
  ///   Fill properties for the underline.
  /// </summary>
  public Fill? UnderlineFill { get; set; }

  /// <summary>
  ///   Font settings for Latin text.
  /// </summary>
  public TextFontType? LatinFont { get; set; }

  /// <summary>
  ///   Font settings for East Asian text.
  /// </summary>
  public TextFontType? EastAsianFont { get; set; }

  /// <summary>
  ///   Font settings for complex script text.
  /// </summary>
  public TextFontType? ComplexScriptFont { get; set; }

  /// <summary>
  ///   Font settings for symbol text.
  /// </summary>
  public TextFontType? SymbolFont { get; set; }

  /// <summary>
  ///   Hyperlink action triggered on click.
  /// </summary>
  public HyperlinkOnClick? HyperlinkOnClick { get; set; }

  /// <summary>
  ///   Hyperlink action triggered on mouse over.
  /// </summary>
  public HyperlinkOnMouseOver? HyperlinkOnMouseOver { get; set; }

  /// <summary>
  ///   Indicates whether the text direction is right-to-left.
  /// </summary>
  public bool? RightToLeft { get; set; }

  /// <summary>
  /// List of extension properties for additional or future extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}