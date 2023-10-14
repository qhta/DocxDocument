namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of run properties applied to the glyph used to represent the physical location of the paragraph mark for this paragraph. This paragraph mark, being a physical character in the document, can be formatted, and therefore shall be capable of representing this formatting like any other character in the document.
/// </summary>
public partial class StyleRunProperties
{
  
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
  ///   RunPropertiesChange.
  /// </summary>
  public DocumentModel.Wordprocessing.RunPropertiesChange? RunPropertiesChange { get; set; }
  
}
