namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of run properties which shall be applied to the contents of the parent run after all style formatting has been applied to the text. These properties are defined as direct formatting, since they are directly applied to the run and supersede any formatting from styles.
/// </summary>
public partial class RunProperties
{
  
  /// <summary>
  ///   RunStyle.
  /// </summary>
  public DocumentModel.Wordprocessing.RunStyle? RunStyle { get; set; }
  
  
  /// <summary>
  ///   RunFonts.
  /// </summary>
  public DocumentModel.Wordprocessing.RunFonts? RunFonts { get; set; }
  
  
  /// <summary>
  ///   Bold.
  /// </summary>
  public DocumentModel.Wordprocessing.Bold? Bold { get; set; }
  
  
  /// <summary>
  ///   BoldComplexScript.
  /// </summary>
  public DocumentModel.Wordprocessing.BoldComplexScript? BoldComplexScript { get; set; }
  
  
  /// <summary>
  ///   Italic.
  /// </summary>
  public DocumentModel.Wordprocessing.Italic? Italic { get; set; }
  
  
  /// <summary>
  ///   ItalicComplexScript.
  /// </summary>
  public DocumentModel.Wordprocessing.ItalicComplexScript? ItalicComplexScript { get; set; }
  
  
  /// <summary>
  ///   Caps.
  /// </summary>
  public DocumentModel.Wordprocessing.Caps? Caps { get; set; }
  
  
  /// <summary>
  ///   SmallCaps.
  /// </summary>
  public DocumentModel.Wordprocessing.SmallCaps? SmallCaps { get; set; }
  
  
  /// <summary>
  ///   Strike.
  /// </summary>
  public DocumentModel.Wordprocessing.Strike? Strike { get; set; }
  
  
  /// <summary>
  ///   DoubleStrike.
  /// </summary>
  public DocumentModel.Wordprocessing.DoubleStrike? DoubleStrike { get; set; }
  
  
  /// <summary>
  ///   Outline.
  /// </summary>
  public DocumentModel.Wordprocessing.Outline? Outline { get; set; }
  
  
  /// <summary>
  ///   Shadow.
  /// </summary>
  public DocumentModel.Wordprocessing.Shadow? Shadow { get; set; }
  
  
  /// <summary>
  ///   Emboss.
  /// </summary>
  public DocumentModel.Wordprocessing.Emboss? Emboss { get; set; }
  
  
  /// <summary>
  ///   Imprint.
  /// </summary>
  public DocumentModel.Wordprocessing.Imprint? Imprint { get; set; }
  
  
  /// <summary>
  ///   NoProof.
  /// </summary>
  public DocumentModel.Wordprocessing.NoProof? NoProof { get; set; }
  
  
  /// <summary>
  ///   SnapToGrid.
  /// </summary>
  public DocumentModel.Wordprocessing.SnapToGrid? SnapToGrid { get; set; }
  
  
  /// <summary>
  ///   Vanish.
  /// </summary>
  public DocumentModel.Wordprocessing.Vanish? Vanish { get; set; }
  
  
  /// <summary>
  ///   WebHidden.
  /// </summary>
  public DocumentModel.Wordprocessing.WebHidden? WebHidden { get; set; }
  
  
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
  public DocumentModel.Wordprocessing.FontSize? FontSize { get; set; }
  
  
  /// <summary>
  ///   FontSizeComplexScript.
  /// </summary>
  public DocumentModel.Wordprocessing.FontSizeComplexScript? FontSizeComplexScript { get; set; }
  
  
  /// <summary>
  ///   Highlight.
  /// </summary>
  public DocumentModel.Wordprocessing.HighlightColorKind? Highlight { get; set; }
  
  
  /// <summary>
  ///   Underline.
  /// </summary>
  public DocumentModel.Wordprocessing.Underline? Underline { get; set; }
  
  
  /// <summary>
  ///   TextEffect.
  /// </summary>
  public DocumentModel.Wordprocessing.TextEffectKind? TextEffect { get; set; }
  
  
  /// <summary>
  ///   Border.
  /// </summary>
  public DocumentModel.Wordprocessing.Border? Border { get; set; }
  
  
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
  public DocumentModel.Wordprocessing.VerticalPositionKind? VerticalTextAlignment { get; set; }
  
  
  /// <summary>
  ///   RightToLeftText.
  /// </summary>
  public DocumentModel.Wordprocessing.RightToLeftText? RightToLeftText { get; set; }
  
  
  /// <summary>
  ///   ComplexScript.
  /// </summary>
  public DocumentModel.Wordprocessing.ComplexScript? ComplexScript { get; set; }
  
  
  /// <summary>
  ///   Emphasis.
  /// </summary>
  public DocumentModel.Wordprocessing.EmphasisMarkKind? Emphasis { get; set; }
  
  
  /// <summary>
  ///   Languages.
  /// </summary>
  public DocumentModel.Wordprocessing.Languages? Languages { get; set; }
  
  
  /// <summary>
  ///   EastAsianLayout.
  /// </summary>
  public DocumentModel.Wordprocessing.EastAsianLayout? EastAsianLayout { get; set; }
  
  
  /// <summary>
  ///   SpecVanish.
  /// </summary>
  public DocumentModel.Wordprocessing.SpecVanish? SpecVanish { get; set; }
  
  
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
  public DocumentModel.Wordprocessing.LigaturesKind? Ligatures { get; set; }
  
  
  /// <summary>
  ///   NumberingFormat, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.NumberFormKind? NumberingFormat { get; set; }
  
  
  /// <summary>
  ///   NumberSpacing, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.NumberSpacingKind? NumberSpacing { get; set; }
  
  
  /// <summary>
  ///   StylisticSets, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.StylisticSets? StylisticSets { get; set; }
  
  
  /// <summary>
  ///   ContextualAlternatives, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.ContextualAlternatives? ContextualAlternatives { get; set; }
  
  
  /// <summary>
  ///   RunPropertiesChange.
  /// </summary>
  public DocumentModel.Wordprocessing.RunPropertiesChange? RunPropertiesChange { get; set; }
  
}
