namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the TextCharacterPropertiesType Class.
/// </summary>
public partial class TextCharacterPropertiesType
{
  public Boolean? SmtClean { get; set; }
  
  public UInt32? SmtId { get; set; }
  
  
  /// <summary>
  ///   kumimoji
  /// </summary>
  public Boolean? Kumimoji { get; set; }
  
  
  /// <summary>
  ///   lang
  /// </summary>
  public String? Language { get; set; }
  
  
  /// <summary>
  ///   altLang
  /// </summary>
  public String? AlternativeLanguage { get; set; }
  
  
  /// <summary>
  ///   sz
  /// </summary>
  public Int32? FontSize { get; set; }
  
  
  /// <summary>
  ///   b
  /// </summary>
  public Boolean? Bold { get; set; }
  
  
  /// <summary>
  ///   i
  /// </summary>
  public Boolean? Italic { get; set; }
  
  
  /// <summary>
  ///   kern
  /// </summary>
  public Int32? Kerning { get; set; }
  
  
  /// <summary>
  ///   spc
  /// </summary>
  public Int32? Spacing { get; set; }
  
  
  /// <summary>
  ///   normalizeH
  /// </summary>
  public Boolean? NormalizeHeight { get; set; }
  
  
  /// <summary>
  ///   baseline
  /// </summary>
  public Int32? Baseline { get; set; }
  
  
  /// <summary>
  ///   noProof
  /// </summary>
  public Boolean? NoProof { get; set; }
  
  
  /// <summary>
  ///   dirty
  /// </summary>
  public Boolean? Dirty { get; set; }
  
  
  /// <summary>
  ///   err
  /// </summary>
  public Boolean? SpellingError { get; set; }
  
  
  /// <summary>
  ///   smtClean
  /// </summary>
  public Boolean? SmartTagClean { get; set; }
  
  
  /// <summary>
  ///   smtId
  /// </summary>
  public UInt32? SmartTagId { get; set; }
  
  
  /// <summary>
  ///   bmk
  /// </summary>
  public String? Bookmark { get; set; }
  
  
  /// <summary>
  ///   Outline.
  /// </summary>
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
