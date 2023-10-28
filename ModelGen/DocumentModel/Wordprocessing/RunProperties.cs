namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of run properties which shall be applied to the contents of the parent run after all style formatting has been applied to the text. These properties are defined as direct formatting, since they are directly applied to the run and supersede any formatting from styles.
/// </summary>
public partial class RunProperties
{
  
  /// <summary>
  ///   RunStyle.
  /// </summary>
  public DMW.RunStyle? RunStyle { get; set; }
  
  
  /// <summary>
  ///   RunFonts.
  /// </summary>
  public DMW.RunFonts? RunFonts { get; set; }
  
  
  /// <summary>
  ///   Bold.
  /// </summary>
  public DMW.Bold? Bold { get; set; }
  
  
  /// <summary>
  ///   BoldComplexScript.
  /// </summary>
  public DMW.BoldComplexScript? BoldComplexScript { get; set; }
  
  
  /// <summary>
  ///   Italic.
  /// </summary>
  public DMW.Italic? Italic { get; set; }
  
  
  /// <summary>
  ///   ItalicComplexScript.
  /// </summary>
  public DMW.ItalicComplexScript? ItalicComplexScript { get; set; }
  
  
  /// <summary>
  ///   Caps.
  /// </summary>
  public DMW.Caps? Caps { get; set; }
  
  
  /// <summary>
  ///   SmallCaps.
  /// </summary>
  public DMW.SmallCaps? SmallCaps { get; set; }
  
  
  /// <summary>
  ///   Strike.
  /// </summary>
  public DMW.Strike? Strike { get; set; }
  
  
  /// <summary>
  ///   DoubleStrike.
  /// </summary>
  public DMW.DoubleStrike? DoubleStrike { get; set; }
  
  
  /// <summary>
  ///   Outline.
  /// </summary>
  public DMW.Outline? Outline { get; set; }
  
  
  /// <summary>
  ///   Shadow.
  /// </summary>
  public DMW.Shadow? Shadow { get; set; }
  
  
  /// <summary>
  ///   Emboss.
  /// </summary>
  public DMW.Emboss? Emboss { get; set; }
  
  
  /// <summary>
  ///   Imprint.
  /// </summary>
  public DMW.Imprint? Imprint { get; set; }
  
  
  /// <summary>
  ///   NoProof.
  /// </summary>
  public DMW.NoProof? NoProof { get; set; }
  
  
  /// <summary>
  ///   SnapToGrid.
  /// </summary>
  public DMW.SnapToGrid? SnapToGrid { get; set; }
  
  
  /// <summary>
  ///   Vanish.
  /// </summary>
  public DMW.Vanish? Vanish { get; set; }
  
  
  /// <summary>
  ///   WebHidden.
  /// </summary>
  public DMW.WebHidden? WebHidden { get; set; }
  
  
  /// <summary>
  ///   Color.
  /// </summary>
  public DMW.Color? Color { get; set; }
  
  
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
  public DMW.FontSize? FontSize { get; set; }
  
  
  /// <summary>
  ///   FontSizeComplexScript.
  /// </summary>
  public DMW.FontSizeComplexScript? FontSizeComplexScript { get; set; }
  
  
  /// <summary>
  ///   Highlight.
  /// </summary>
  public DMW.HighlightColorKind? Highlight { get; set; }
  
  
  /// <summary>
  ///   Underline.
  /// </summary>
  public DMW.Underline? Underline { get; set; }
  
  
  /// <summary>
  ///   TextEffect.
  /// </summary>
  public DMW.TextEffectKind? TextEffect { get; set; }
  
  
  /// <summary>
  ///   Border.
  /// </summary>
  public DMW.Border? Border { get; set; }
  
  
  /// <summary>
  ///   Shading.
  /// </summary>
  public DMW.Shading? Shading { get; set; }
  
  
  /// <summary>
  ///   FitText.
  /// </summary>
  public DMW.FitText? FitText { get; set; }
  
  
  /// <summary>
  ///   VerticalTextAlignment.
  /// </summary>
  public DMW.VerticalPositionKind? VerticalTextAlignment { get; set; }
  
  
  /// <summary>
  ///   RightToLeftText.
  /// </summary>
  public DMW.RightToLeftText? RightToLeftText { get; set; }
  
  
  /// <summary>
  ///   ComplexScript.
  /// </summary>
  public DMW.ComplexScript? ComplexScript { get; set; }
  
  
  /// <summary>
  ///   Emphasis.
  /// </summary>
  public DMW.EmphasisMarkKind? Emphasis { get; set; }
  
  
  /// <summary>
  ///   Languages.
  /// </summary>
  public DMW.Languages? Languages { get; set; }
  
  
  /// <summary>
  ///   EastAsianLayout.
  /// </summary>
  public DMW.EastAsianLayout? EastAsianLayout { get; set; }
  
  
  /// <summary>
  ///   SpecVanish.
  /// </summary>
  public DMW.SpecVanish? SpecVanish { get; set; }
  
  
  /// <summary>
  ///   Glow, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW10.Glow? Glow { get; set; }
  
  
  /// <summary>
  ///   Shadow14, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW10.Shadow? Shadow14 { get; set; }
  
  
  /// <summary>
  ///   Reflection, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW10.Reflection? Reflection { get; set; }
  
  
  /// <summary>
  ///   TextOutlineEffect, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW10.TextOutlineEffect? TextOutlineEffect { get; set; }
  
  
  /// <summary>
  ///   FillTextEffect, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW10.FillTextEffect? FillTextEffect { get; set; }
  
  
  /// <summary>
  ///   Scene3D, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW10.Scene3D? Scene3D { get; set; }
  
  
  /// <summary>
  ///   Properties3D, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW10.Properties3D? Properties3D { get; set; }
  
  
  /// <summary>
  ///   Ligatures, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW10.LigaturesKind? Ligatures { get; set; }
  
  
  /// <summary>
  ///   NumberingFormat, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW10.NumberFormKind? NumberingFormat { get; set; }
  
  
  /// <summary>
  ///   NumberSpacing, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW10.NumberSpacingKind? NumberSpacing { get; set; }
  
  
  /// <summary>
  ///   StylisticSets, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW10.StylisticSets? StylisticSets { get; set; }
  
  
  /// <summary>
  ///   ContextualAlternatives, this property is only available in Office 2010 and later..
  /// </summary>
  public DMW10.ContextualAlternatives? ContextualAlternatives { get; set; }
  
  
  /// <summary>
  ///   RunPropertiesChange.
  /// </summary>
  public DMW.RunPropertiesChange? RunPropertiesChange { get; set; }
  
}
