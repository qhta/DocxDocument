namespace DocumentModel.Wordprocessing;

/// <summary>
/// Run Properties.
/// </summary>
public partial interface RunProperties
{
  /// <summary>
  /// RunStyle.
  /// </summary>
  public String? RunStyle { get; set; }
  
  /// <summary>
  /// RunFonts.
  /// </summary>
  public DocumentModel.Wordprocessing.RunFonts? RunFonts { get; set; }
  
  /// <summary>
  /// Bold.
  /// </summary>
  public Boolean? Bold { get; set; }
  
  /// <summary>
  /// BoldComplexScript.
  /// </summary>
  public Boolean? BoldComplexScript { get; set; }
  
  /// <summary>
  /// Italic.
  /// </summary>
  public Boolean? Italic { get; set; }
  
  /// <summary>
  /// ItalicComplexScript.
  /// </summary>
  public Boolean? ItalicComplexScript { get; set; }
  
  /// <summary>
  /// Caps.
  /// </summary>
  public Boolean? Caps { get; set; }
  
  /// <summary>
  /// SmallCaps.
  /// </summary>
  public Boolean? SmallCaps { get; set; }
  
  /// <summary>
  /// Strike.
  /// </summary>
  public Boolean? Strike { get; set; }
  
  /// <summary>
  /// DoubleStrike.
  /// </summary>
  public Boolean? DoubleStrike { get; set; }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public Boolean? Outline { get; set; }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public Boolean? Shadow { get; set; }
  
  /// <summary>
  /// Emboss.
  /// </summary>
  public Boolean? Emboss { get; set; }
  
  /// <summary>
  /// Imprint.
  /// </summary>
  public Boolean? Imprint { get; set; }
  
  /// <summary>
  /// NoProof.
  /// </summary>
  public Boolean? NoProof { get; set; }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  public Boolean? SnapToGrid { get; set; }
  
  /// <summary>
  /// Vanish.
  /// </summary>
  public Boolean? Vanish { get; set; }
  
  /// <summary>
  /// WebHidden.
  /// </summary>
  public Boolean? WebHidden { get; set; }
  
  /// <summary>
  /// Color.
  /// </summary>
  public DocumentModel.Wordprocessing.Color? Color { get; set; }
  
  /// <summary>
  /// Spacing.
  /// </summary>
  public Int32? Spacing { get; set; }
  
  /// <summary>
  /// CharacterScale.
  /// </summary>
  public Int32? CharacterScale { get; set; }
  
  /// <summary>
  /// Kern.
  /// </summary>
  public UInt32? Kern { get; set; }
  
  /// <summary>
  /// Position.
  /// </summary>
  public String? Position { get; set; }
  
  /// <summary>
  /// FontSize.
  /// </summary>
  public String? FontSize { get; set; }
  
  /// <summary>
  /// FontSizeComplexScript.
  /// </summary>
  public String? FontSizeComplexScript { get; set; }
  
  /// <summary>
  /// Highlight.
  /// </summary>
  public DocumentModel.Wordprocessing.HighlightColorKind? Highlight { get; set; }
  
  /// <summary>
  /// Underline.
  /// </summary>
  public DocumentModel.Wordprocessing.Underline? Underline { get; set; }
  
  /// <summary>
  /// TextEffect.
  /// </summary>
  public DocumentModel.Wordprocessing.TextEffectKind? TextEffect { get; set; }
  
  /// <summary>
  /// Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? Border { get; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.Shading? Shading { get; set; }
  
  /// <summary>
  /// FitText.
  /// </summary>
  public DocumentModel.Wordprocessing.FitText? FitText { get; set; }
  
  /// <summary>
  /// VerticalTextAlignment.
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalPositionKind? VerticalTextAlignment { get; set; }
  
  /// <summary>
  /// RightToLeftText.
  /// </summary>
  public Boolean? RightToLeftText { get; set; }
  
  /// <summary>
  /// ComplexScript.
  /// </summary>
  public Boolean? ComplexScript { get; set; }
  
  /// <summary>
  /// Emphasis.
  /// </summary>
  public DocumentModel.Wordprocessing.EmphasisMarkKind? Emphasis { get; set; }
  
  /// <summary>
  /// Languages.
  /// </summary>
  public DocumentModel.Wordprocessing.LanguageType? Languages { get; set; }
  
  /// <summary>
  /// EastAsianLayout.
  /// </summary>
  public DocumentModel.Wordprocessing.EastAsianLayout? EastAsianLayout { get; set; }
  
  /// <summary>
  /// SpecVanish.
  /// </summary>
  public Boolean? SpecVanish { get; set; }
  
  /// <summary>
  /// Glow, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.Glow? Glow { get; set; }
  
  /// <summary>
  /// Shadow14, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.Shadow2? Shadow14 { get; set; }
  
  /// <summary>
  /// Reflection, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.Reflection? Reflection { get; set; }
  
  /// <summary>
  /// TextOutlineEffect, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.TextOutlineEffect? TextOutlineEffect { get; set; }
  
  /// <summary>
  /// FillTextEffect, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.FillTextEffect? FillTextEffect { get; set; }
  
  /// <summary>
  /// Scene3D, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.Scene3D? Scene3D { get; set; }
  
  /// <summary>
  /// Properties3D, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.Properties3D? Properties3D { get; set; }
  
  /// <summary>
  /// Ligatures, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.LigaturesKind? Ligatures { get; set; }
  
  /// <summary>
  /// NumberingFormat, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.NumberFormKind? NumberingFormat { get; set; }
  
  /// <summary>
  /// NumberSpacing, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.NumberSpacingKind? NumberSpacing { get; set; }
  
  /// <summary>
  /// StylisticSets, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.StylisticSets? StylisticSets { get; set; }
  
  /// <summary>
  /// ContextualAlternatives, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffKind? ContextualAlternatives { get; set; }
  
  /// <summary>
  /// RunPropertiesChange.
  /// </summary>
  public DocumentModel.Wordprocessing.RunPropertiesChange? RunPropertiesChange { get; set; }
  
}
