namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of run properties which shall be applied to the contents of the parent run after all style formatting has been applied to the text. These properties are defined as direct formatting, since they are directly applied to the run and supersede any formatting from styles.
/// </summary>
public partial class RunProperties
{
  
  /// <summary>
  ///   RunStyle.
  /// </summary>
  public String? RunStyle { get; set; }
  
  
  /// <summary>
  ///   RunFonts.
  /// </summary>
  public DocumentModel.Wordprocessing.RunFonts? RunFonts { get; set; }
  
  
  /// <summary>
  ///   Bold.
  /// </summary>
  public Boolean? Bold { get; set; }
  
  
  /// <summary>
  ///   BoldComplexScript.
  /// </summary>
  public Boolean? BoldComplexScript { get; set; }
  
  
  /// <summary>
  ///   Italic.
  /// </summary>
  public Boolean? Italic { get; set; }
  
  
  /// <summary>
  ///   ItalicComplexScript.
  /// </summary>
  public Boolean? ItalicComplexScript { get; set; }
  
  
  /// <summary>
  ///   Caps.
  /// </summary>
  public Boolean? Caps { get; set; }
  
  
  /// <summary>
  ///   SmallCaps.
  /// </summary>
  public Boolean? SmallCaps { get; set; }
  
  
  /// <summary>
  ///   Strike.
  /// </summary>
  public Boolean? Strike { get; set; }
  
  
  /// <summary>
  ///   DoubleStrike.
  /// </summary>
  public Boolean? DoubleStrike { get; set; }
  
  
  /// <summary>
  ///   Outline.
  /// </summary>
  public Boolean? Outline { get; set; }
  
  
  /// <summary>
  ///   Shadow.
  /// </summary>
  public Boolean? Shadow { get; set; }
  
  
  /// <summary>
  ///   Emboss.
  /// </summary>
  public Boolean? Emboss { get; set; }
  
  
  /// <summary>
  ///   Imprint.
  /// </summary>
  public Boolean? Imprint { get; set; }
  
  
  /// <summary>
  ///   NoProof.
  /// </summary>
  public Boolean? NoProof { get; set; }
  
  
  /// <summary>
  ///   SnapToGrid.
  /// </summary>
  public Boolean? SnapToGrid { get; set; }
  
  
  /// <summary>
  ///   Vanish.
  /// </summary>
  public Boolean? Vanish { get; set; }
  
  
  /// <summary>
  ///   WebHidden.
  /// </summary>
  public Boolean? WebHidden { get; set; }
  
  
  /// <summary>
  ///   Color.
  /// </summary>
  public DocumentModel.Wordprocessing.Color? Color { get; set; }
  
  
  /// <summary>
  ///   Spacing.
  /// </summary>
  public Int32? Spacing { get; set; }
  
  
  /// <summary>
  ///   CharacterScale.
  /// </summary>
  public Int64? CharacterScale { get; set; }
  
  
  /// <summary>
  ///   Kern.
  /// </summary>
  public UInt32? Kern { get; set; }
  
  
  /// <summary>
  ///   Position.
  /// </summary>
  public String? Position { get; set; }
  
  
  /// <summary>
  ///   FontSize.
  /// </summary>
  public String? FontSize { get; set; }
  
  
  /// <summary>
  ///   FontSizeComplexScript.
  /// </summary>
  public String? FontSizeComplexScript { get; set; }
  
  
  /// <summary>
  ///   Highlight.
  /// </summary>
  public DocumentModel.Wordprocessing.HighlightColorValues? Highlight { get; set; }
  
  
  /// <summary>
  ///   Underline.
  /// </summary>
  public DocumentModel.Wordprocessing.Underline? Underline { get; set; }
  
  
  /// <summary>
  ///   TextEffect.
  /// </summary>
  public DocumentModel.Wordprocessing.TextEffectValues? TextEffect { get; set; }
  
  
  /// <summary>
  ///   Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? Border { get; set; }
  
  
  /// <summary>
  ///   Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.Shading? Shading { get; set; }
  
  
  /// <summary>
  ///   FitText.
  /// </summary>
  public DocumentModel.Wordprocessing.FitText? FitText { get; set; }
  
  
  /// <summary>
  ///   VerticalTextAlignment.
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalPositionValues? VerticalTextAlignment { get; set; }
  
  
  /// <summary>
  ///   RightToLeftText.
  /// </summary>
  public Boolean? RightToLeftText { get; set; }
  
  
  /// <summary>
  ///   ComplexScript.
  /// </summary>
  public Boolean? ComplexScript { get; set; }
  
  
  /// <summary>
  ///   Emphasis.
  /// </summary>
  public DocumentModel.Wordprocessing.EmphasisMarkValues? Emphasis { get; set; }
  
  
  /// <summary>
  ///   Languages.
  /// </summary>
  public DocumentModel.Wordprocessing.LanguageType? Languages { get; set; }
  
  
  /// <summary>
  ///   EastAsianLayout.
  /// </summary>
  public DocumentModel.Wordprocessing.EastAsianLayout? EastAsianLayout { get; set; }
  
  
  /// <summary>
  ///   SpecVanish.
  /// </summary>
  public Boolean? SpecVanish { get; set; }
  
  
  /// <summary>
  ///   Glow, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.Glow? Glow { get; set; }
  
  
  /// <summary>
  ///   Shadow14, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.Shadow? Shadow14 { get; set; }
  
  
  /// <summary>
  ///   Reflection, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.Reflection? Reflection { get; set; }
  
  
  /// <summary>
  ///   TextOutlineEffect, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.TextOutlineEffect? TextOutlineEffect { get; set; }
  
  
  /// <summary>
  ///   FillTextEffect, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.FillTextEffect? FillTextEffect { get; set; }
  
  
  /// <summary>
  ///   Scene3D, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.Scene3D? Scene3D { get; set; }
  
  
  /// <summary>
  ///   Properties3D, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.Properties3D? Properties3D { get; set; }
  
  
  /// <summary>
  ///   Ligatures, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.LigaturesValues? Ligatures { get; set; }
  
  
  /// <summary>
  ///   NumberingFormat, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.NumberFormValues? NumberingFormat { get; set; }
  
  
  /// <summary>
  ///   NumberSpacing, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.NumberSpacingValues? NumberSpacing { get; set; }
  
  
  /// <summary>
  ///   StylisticSets, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.StylisticSets? StylisticSets { get; set; }
  
  
  /// <summary>
  ///   ContextualAlternatives, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffValues? ContextualAlternatives { get; set; }
  
  
  /// <summary>
  ///   RunPropertiesChange.
  /// </summary>
  public DocumentModel.Wordprocessing.RunPropertiesChange? RunPropertiesChange { get; set; }
  
}
