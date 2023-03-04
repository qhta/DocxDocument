namespace DocumentModel.Drawings;

/// <summary>
///   End Paragraph Run Properties.
/// </summary>
public class EndParagraphRunProperties
{
  public Outline? Outline { get; set; }

  public Boolean? NoFill { get; set; }

  public SolidFill? SolidFill { get; set; }

  public GradientFill? GradientFill { get; set; }

  public BlipFill? BlipFill { get; set; }

  public PatternFill? PatternFill { get; set; }

  public Boolean? GroupFill { get; set; }

  public EffectList? EffectList { get; set; }

  public EffectDag? EffectDag { get; set; }

  public Highlight? Highlight { get; set; }

  public Boolean? UnderlineFollowsText { get; set; }

  public Underline? Underline { get; set; }

  public Boolean? UnderlineFillText { get; set; }

  public UnderlineFill? UnderlineFill { get; set; }

  public TextFontType? LatinFont { get; set; }

  public TextFontType? EastAsianFont { get; set; }

  public TextFontType? ComplexScriptFont { get; set; }

  public TextFontType? SymbolFont { get; set; }

  public HyperlinkOnClick? HyperlinkOnClick { get; set; }

  public HyperlinkOnMouseOver? HyperlinkOnMouseOver { get; set; }

  public Boolean? RightToLeft { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}