namespace DocumentModel.Drawing;

/// <summary>
/// Defines the TextCharacterPropertiesType Class.
/// </summary>
public interface ITextCharacterPropertiesType // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public TextUnderlineKind? Underline { get ; set; }
  
  /// <summary>
  /// strike
  /// </summary>
  public TextStrikeKind? Strike { get ; set; }
  
  /// <summary>
  /// kern
  /// </summary>
  public Int32? Kerning { get ; set; }
  
  /// <summary>
  /// cap
  /// </summary>
  public TextCapsKind? Capital { get ; set; }
  
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
