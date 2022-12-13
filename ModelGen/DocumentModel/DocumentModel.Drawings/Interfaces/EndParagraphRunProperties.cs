namespace DocumentModel.Drawings;

/// <summary>
/// End Paragraph Run Properties.
/// </summary>
public interface EndParagraphRunProperties
{
  public DocumentModel.Drawings.Outline? Outline { get ; set; }
  
  public Boolean? NoFill { get ; set; }
  
  public DocumentModel.Drawings.SolidFill? SolidFill { get ; set; }
  
  public DocumentModel.Drawings.GradientFill? GradientFill { get ; set; }
  
  public DocumentModel.Drawings.BlipFill? BlipFill { get ; set; }
  
  public DocumentModel.Drawings.PatternFill? PatternFill { get ; set; }
  
  public Boolean? GroupFill { get ; set; }
  
  public DocumentModel.Drawings.EffectList? EffectList { get ; set; }
  
  public DocumentModel.Drawings.EffectDag? EffectDag { get ; set; }
  
  public DocumentModel.Drawings.Highlight? Highlight { get ; set; }
  
  public Boolean? UnderlineFollowsText { get ; set; }
  
  public DocumentModel.Drawings.Underline? Underline { get ; set; }
  
  public Boolean? UnderlineFillText { get ; set; }
  
  public DocumentModel.Drawings.UnderlineFill? UnderlineFill { get ; set; }
  
  public DocumentModel.Drawings.TextFontType? LatinFont { get ; set; }
  
  public DocumentModel.Drawings.TextFontType? EastAsianFont { get ; set; }
  
  public DocumentModel.Drawings.TextFontType? ComplexScriptFont { get ; set; }
  
  public DocumentModel.Drawings.TextFontType? SymbolFont { get ; set; }
  
  public DocumentModel.Drawings.HyperlinkOnClick? HyperlinkOnClick { get ; set; }
  
  public DocumentModel.Drawings.HyperlinkOnMouseOver? HyperlinkOnMouseOver { get ; set; }
  
  public Boolean? RightToLeft { get ; set; }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
