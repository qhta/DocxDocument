namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the TextCharacterPropertiesType Class.
/// </summary>
public interface TextCharacterPropertiesType
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public Boolean? SmtClean { get ; set; }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public UInt32? SmtId { get ; set; }
  
  /// <summary>
  /// kumimoji
  /// </summary>
  public Boolean? Kumimoji { get ; set; }
  
  /// <summary>
  /// lang
  /// </summary>
  public String? Language { get ; set; }
  
  /// <summary>
  /// altLang
  /// </summary>
  public String? AlternativeLanguage { get ; set; }
  
  /// <summary>
  /// sz
  /// </summary>
  public Int32? FontSize { get ; set; }
  
  /// <summary>
  /// b
  /// </summary>
  public Boolean? Bold { get ; set; }
  
  /// <summary>
  /// i
  /// </summary>
  public Boolean? Italic { get ; set; }
  
  /// <summary>
  /// u
  /// </summary>
  public DocumentModel.Drawings.TextUnderlineKind? Underline { get ; set; }
  
  /// <summary>
  /// strike
  /// </summary>
  public DocumentModel.Drawings.TextStrikeKind? Strike { get ; set; }
  
  /// <summary>
  /// kern
  /// </summary>
  public Int32? Kerning { get ; set; }
  
  /// <summary>
  /// cap
  /// </summary>
  public DocumentModel.Drawings.TextCapsKind? Capital { get ; set; }
  
  /// <summary>
  /// spc
  /// </summary>
  public Int32? Spacing { get ; set; }
  
  /// <summary>
  /// normalizeH
  /// </summary>
  public Boolean? NormalizeHeight { get ; set; }
  
  /// <summary>
  /// baseline
  /// </summary>
  public Int32? Baseline { get ; set; }
  
  /// <summary>
  /// noProof
  /// </summary>
  public Boolean? NoProof { get ; set; }
  
  /// <summary>
  /// dirty
  /// </summary>
  public Boolean? Dirty { get ; set; }
  
  /// <summary>
  /// err
  /// </summary>
  public Boolean? SpellingError { get ; set; }
  
  /// <summary>
  /// smtClean
  /// </summary>
  public Boolean? SmartTagClean { get ; set; }
  
  /// <summary>
  /// smtId
  /// </summary>
  public UInt32? SmartTagId { get ; set; }
  
  /// <summary>
  /// bmk
  /// </summary>
  public String? Bookmark { get ; set; }
  
  /// <summary>
  /// Outline.
  /// </summary>
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
