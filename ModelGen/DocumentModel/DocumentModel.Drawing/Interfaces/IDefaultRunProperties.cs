namespace DocumentModel.Drawing;

/// <summary>
/// Default Text Run Properties.
/// </summary>
public interface IDefaultRunProperties // : DocumentModel.Drawing.ITextCharacterPropertiesType
{
  public DocumentModel.Drawing.IOutline? Outline { get ; set; }
  
  public System.Boolean? NoFill { get ; set; }
  
  public DocumentModel.Drawing.ISolidFill? SolidFill { get ; set; }
  
  public DocumentModel.Drawing.IGradientFill? GradientFill { get ; set; }
  
  public DocumentModel.Drawing.IBlipFill? BlipFill { get ; set; }
  
  public DocumentModel.Drawing.IPatternFill? PatternFill { get ; set; }
  
  public System.Boolean? GroupFill { get ; set; }
  
  public DocumentModel.Drawing.IEffectList? EffectList { get ; set; }
  
  public DocumentModel.Drawing.IEffectDag? EffectDag { get ; set; }
  
  public DocumentModel.Drawing.IHighlight? Highlight { get ; set; }
  
  public System.Boolean? UnderlineFollowsText { get ; set; }
  
  public DocumentModel.Drawing.IUnderline? Underline { get ; set; }
  
  public System.Boolean? UnderlineFillText { get ; set; }
  
  public DocumentModel.Drawing.IUnderlineFill? UnderlineFill { get ; set; }
  
  public DocumentModel.Drawing.ITextFontType? LatinFont { get ; set; }
  
  public DocumentModel.Drawing.ITextFontType? EastAsianFont { get ; set; }
  
  public DocumentModel.Drawing.ITextFontType? ComplexScriptFont { get ; set; }
  
  public DocumentModel.Drawing.ITextFontType? SymbolFont { get ; set; }
  
  public DocumentModel.Drawing.IHyperlinkOnClick? HyperlinkOnClick { get ; set; }
  
  public DocumentModel.Drawing.IHyperlinkOnMouseOver? HyperlinkOnMouseOver { get ; set; }
  
  public System.Boolean? RightToLeft { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
