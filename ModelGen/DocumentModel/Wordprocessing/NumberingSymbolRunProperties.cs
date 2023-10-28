namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of run properties applied to the glyph used to represent the physical location of the paragraph mark for this paragraph. This paragraph mark, being a physical character in the document, can be formatted, and therefore shall be capable of representing this formatting like any other character in the document.
/// </summary>
public partial class NumberingSymbolRunProperties
{
  
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
  
}
