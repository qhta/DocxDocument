namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   End Paragraph Run Properties.
/// </summary>
public class EndParagraphRunProperties: ModelElement
{
  public Outline? Outline { get; set; }

  public bool? NoFill { get; set; }

  public SolidFill? SolidFill { get; set; }

  public GradientFill? GradientFill { get; set; }

  public BlipFill? BlipFill { get; set; }

  public PatternFill? PatternFill { get; set; }

  public bool? GroupFill { get; set; }

  public EffectList? EffectList { get; set; }

  public EffectDag? EffectDag { get; set; }

  public Highlight? Highlight { get; set; }

  public bool? UnderlineFollowsText { get; set; }

  public Underline? Underline { get; set; }

  public bool? UnderlineFillText { get; set; }

  public UnderlineFill? UnderlineFill { get; set; }

  public TextFontType? LatinFont { get; set; }

  public TextFontType? EastAsianFont { get; set; }

  public TextFontType? ComplexScriptFont { get; set; }

  public TextFontType? SymbolFont { get; set; }

  public HyperlinkOnClick? HyperlinkOnClick { get; set; }

  public HyperlinkOnMouseOver? HyperlinkOnMouseOver { get; set; }

  public bool? RightToLeft { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}