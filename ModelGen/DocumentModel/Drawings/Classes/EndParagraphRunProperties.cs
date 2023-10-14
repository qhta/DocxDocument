namespace DocumentModel.Drawings;


/// <summary>
///   End Paragraph Run Properties.
/// </summary>
public partial class EndParagraphRunProperties
{
  public DocumentModel.Drawings.Outline? Outline { get; set; }
  
  public DocumentModel.Drawings.NoFill? NoFill { get; set; }
  
  public DocumentModel.Drawings.SolidFill? SolidFill { get; set; }
  
  public DocumentModel.Drawings.GradientFill? GradientFill { get; set; }
  
  public DocumentModel.Drawings.BlipFill? BlipFill { get; set; }
  
  public DocumentModel.Drawings.PatternFill? PatternFill { get; set; }
  
  public DocumentModel.Drawings.GroupFill? GroupFill { get; set; }
  
  public DocumentModel.Drawings.EffectList? EffectList { get; set; }
  
  public DocumentModel.Drawings.EffectDag? EffectDag { get; set; }
  
  public DocumentModel.Drawings.Highlight? Highlight { get; set; }
  
  public DocumentModel.Drawings.UnderlineFollowsText? UnderlineFollowsText { get; set; }
  
  public DocumentModel.Drawings.Underline? Underline { get; set; }
  
  public DocumentModel.Drawings.UnderlineFillText? UnderlineFillText { get; set; }
  
  public DocumentModel.Drawings.UnderlineFill? UnderlineFill { get; set; }
  
  public DocumentModel.Drawings.LatinFont? LatinFont { get; set; }
  
  public DocumentModel.Drawings.EastAsianFont? EastAsianFont { get; set; }
  
  public DocumentModel.Drawings.ComplexScriptFont? ComplexScriptFont { get; set; }
  
  public DocumentModel.Drawings.SymbolFont? SymbolFont { get; set; }
  
  public DocumentModel.Drawings.HyperlinkOnClick? HyperlinkOnClick { get; set; }
  
  public DocumentModel.Drawings.HyperlinkOnMouseOver? HyperlinkOnMouseOver { get; set; }
  
  public Boolean? RightToLeft { get; set; }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
