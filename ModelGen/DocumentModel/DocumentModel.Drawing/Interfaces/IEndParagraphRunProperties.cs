namespace DocumentModel.Drawing;

/// <summary>
/// End Paragraph Run Properties.
/// </summary>
public interface IEndParagraphRunProperties // : DocumentModel.Drawing.ITextCharacterPropertiesType
{
  public IOutline? Outline { get ; set; }
  
  public Boolean? NoFill { get ; set; }
  
  public ISolidFill? SolidFill { get ; set; }
  
  public IGradientFill? GradientFill { get ; set; }
  
  public IBlipFill? BlipFill { get ; set; }
  
  public IPatternFill? PatternFill { get ; set; }
  
  public Boolean? GroupFill { get ; set; }
  
  public IEffectList? EffectList { get ; set; }
  
  public IEffectDag? EffectDag { get ; set; }
  
  public IHighlight? Highlight { get ; set; }
  
  public Boolean? UnderlineFollowsText { get ; set; }
  
  public IUnderline? Underline { get ; set; }
  
  public Boolean? UnderlineFillText { get ; set; }
  
  public IUnderlineFill? UnderlineFill { get ; set; }
  
  public ITextFontType? LatinFont { get ; set; }
  
  public ITextFontType? EastAsianFont { get ; set; }
  
  public ITextFontType? ComplexScriptFont { get ; set; }
  
  public ITextFontType? SymbolFont { get ; set; }
  
  public IHyperlinkOnClick? HyperlinkOnClick { get ; set; }
  
  public IHyperlinkOnMouseOver? HyperlinkOnMouseOver { get ; set; }
  
  public Boolean? RightToLeft { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
