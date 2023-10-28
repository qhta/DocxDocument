namespace DocumentModel.Drawings;


/// <summary>
///   Default Text Run Properties.
/// </summary>
public partial class DefaultRunProperties
{
  public DMD.Outline? Outline { get; set; }
  
  public DMD.NoFill? NoFill { get; set; }
  
  public DMD.SolidFill? SolidFill { get; set; }
  
  public DMD.GradientFill? GradientFill { get; set; }
  
  public DMD.BlipFill? BlipFill { get; set; }
  
  public DMD.PatternFill? PatternFill { get; set; }
  
  public DMD.GroupFill? GroupFill { get; set; }
  
  public DMD.EffectList? EffectList { get; set; }
  
  public DMD.EffectDag? EffectDag { get; set; }
  
  public DMD.Highlight? Highlight { get; set; }
  
  public DMD.UnderlineFollowsText? UnderlineFollowsText { get; set; }
  
  public DMD.Underline? Underline { get; set; }
  
  public DMD.UnderlineFillText? UnderlineFillText { get; set; }
  
  public DMD.UnderlineFill? UnderlineFill { get; set; }
  
  public DMD.LatinFont? LatinFont { get; set; }
  
  public DMD.EastAsianFont? EastAsianFont { get; set; }
  
  public DMD.ComplexScriptFont? ComplexScriptFont { get; set; }
  
  public DMD.SymbolFont? SymbolFont { get; set; }
  
  public DMD.HyperlinkOnClick? HyperlinkOnClick { get; set; }
  
  public DMD.HyperlinkOnMouseOver? HyperlinkOnMouseOver { get; set; }
  
  public Boolean? RightToLeft { get; set; }
  
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}
