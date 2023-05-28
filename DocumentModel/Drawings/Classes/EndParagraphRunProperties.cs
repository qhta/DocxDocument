namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   End Paragraph Run Properties.
/// </summary>
public class EndParagraphRunProperties: ModelElement
{
  public LineProperties? Outline { get; set; }

  public Fill? Fill { get; set; }

  public EffectList? EffectList { get; set; }

  public EffectDag? EffectDag { get; set; }

  public Highlight? Highlight { get; set; }

  public bool? UnderlineFollowsText { get; set; }

  public LineProperties? Underline { get; set; }

  public bool? UnderlineFillText { get; set; }

  public Fill? UnderlineFill { get; set; }

  public TextFontType? LatinFont { get; set; }

  public TextFontType? EastAsianFont { get; set; }

  public TextFontType? ComplexScriptFont { get; set; }

  public TextFontType? SymbolFont { get; set; }

  public HyperlinkOnClick? HyperlinkOnClick { get; set; }

  public HyperlinkOnMouseOver? HyperlinkOnMouseOver { get; set; }

  public bool? RightToLeft { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}