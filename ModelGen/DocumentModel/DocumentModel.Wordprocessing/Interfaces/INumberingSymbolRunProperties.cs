namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Symbol Run Properties.
/// </summary>
public interface INumberingSymbolRunProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RunFonts.
  /// </summary>
  public DocumentModel.Wordprocessing.IRunFonts? RunFonts { get ; set; }
  
  /// <summary>
  /// Bold.
  /// </summary>
  public System.Boolean? Bold { get ; set; }
  
  /// <summary>
  /// BoldComplexScript.
  /// </summary>
  public System.Boolean? BoldComplexScript { get ; set; }
  
  /// <summary>
  /// Italic.
  /// </summary>
  public System.Boolean? Italic { get ; set; }
  
  /// <summary>
  /// ItalicComplexScript.
  /// </summary>
  public System.Boolean? ItalicComplexScript { get ; set; }
  
  /// <summary>
  /// Caps.
  /// </summary>
  public System.Boolean? Caps { get ; set; }
  
  /// <summary>
  /// SmallCaps.
  /// </summary>
  public System.Boolean? SmallCaps { get ; set; }
  
  /// <summary>
  /// Strike.
  /// </summary>
  public System.Boolean? Strike { get ; set; }
  
  /// <summary>
  /// DoubleStrike.
  /// </summary>
  public System.Boolean? DoubleStrike { get ; set; }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public System.Boolean? Outline { get ; set; }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public System.Boolean? Shadow { get ; set; }
  
  /// <summary>
  /// Emboss.
  /// </summary>
  public System.Boolean? Emboss { get ; set; }
  
  /// <summary>
  /// Imprint.
  /// </summary>
  public System.Boolean? Imprint { get ; set; }
  
  /// <summary>
  /// NoProof.
  /// </summary>
  public System.Boolean? NoProof { get ; set; }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  public System.Boolean? SnapToGrid { get ; set; }
  
  /// <summary>
  /// Vanish.
  /// </summary>
  public System.Boolean? Vanish { get ; set; }
  
  /// <summary>
  /// WebHidden.
  /// </summary>
  public System.Boolean? WebHidden { get ; set; }
  
  /// <summary>
  /// Color.
  /// </summary>
  public DocumentModel.Wordprocessing.IColor? Color { get ; set; }
  
  /// <summary>
  /// Spacing.
  /// </summary>
  public System.Int32? Spacing { get ; set; }
  
  /// <summary>
  /// CharacterScale.
  /// </summary>
  public System.Int32? CharacterScale { get ; set; }
  
  /// <summary>
  /// Kern.
  /// </summary>
  public System.UInt32? Kern { get ; set; }
  
  /// <summary>
  /// Position.
  /// </summary>
  public System.String? Position { get ; set; }
  
  /// <summary>
  /// FontSize.
  /// </summary>
  public System.String? FontSize { get ; set; }
  
  /// <summary>
  /// FontSizeComplexScript.
  /// </summary>
  public System.String? FontSizeComplexScript { get ; set; }
  
  /// <summary>
  /// Underline.
  /// </summary>
  public DocumentModel.Wordprocessing.IUnderline? Underline { get ; set; }
  
  /// <summary>
  /// TextEffect.
  /// </summary>
  public DocumentModel.Wordprocessing.TextEffectKind? TextEffect { get ; set; }
  
  /// <summary>
  /// Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? Border { get ; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.IShading? Shading { get ; set; }
  
  /// <summary>
  /// FitText.
  /// </summary>
  public DocumentModel.Wordprocessing.IFitText? FitText { get ; set; }
  
  /// <summary>
  /// VerticalTextAlignment.
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalPositionKind? VerticalTextAlignment { get ; set; }
  
  /// <summary>
  /// RightToLeftText.
  /// </summary>
  public System.Boolean? RightToLeftText { get ; set; }
  
  /// <summary>
  /// ComplexScript.
  /// </summary>
  public System.Boolean? ComplexScript { get ; set; }
  
  /// <summary>
  /// Emphasis.
  /// </summary>
  public DocumentModel.Wordprocessing.EmphasisMarkKind? Emphasis { get ; set; }
  
  /// <summary>
  /// Languages.
  /// </summary>
  public DocumentModel.Wordprocessing.ILanguageType? Languages { get ; set; }
  
  /// <summary>
  /// EastAsianLayout.
  /// </summary>
  public DocumentModel.Wordprocessing.IEastAsianLayout? EastAsianLayout { get ; set; }
  
  /// <summary>
  /// SpecVanish.
  /// </summary>
  public System.Boolean? SpecVanish { get ; set; }
  
}
