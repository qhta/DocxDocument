namespace DocumentModel.Wordprocessing;

/// <summary>
/// Run Properties.
/// </summary>
public interface IStyleRunProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RunFonts.
  /// </summary>
  public IRunFonts? RunFonts { get ; set; }
  
  /// <summary>
  /// Bold.
  /// </summary>
  public Boolean? Bold { get ; set; }
  
  /// <summary>
  /// BoldComplexScript.
  /// </summary>
  public Boolean? BoldComplexScript { get ; set; }
  
  /// <summary>
  /// Italic.
  /// </summary>
  public Boolean? Italic { get ; set; }
  
  /// <summary>
  /// ItalicComplexScript.
  /// </summary>
  public Boolean? ItalicComplexScript { get ; set; }
  
  /// <summary>
  /// Caps.
  /// </summary>
  public Boolean? Caps { get ; set; }
  
  /// <summary>
  /// SmallCaps.
  /// </summary>
  public Boolean? SmallCaps { get ; set; }
  
  /// <summary>
  /// Strike.
  /// </summary>
  public Boolean? Strike { get ; set; }
  
  /// <summary>
  /// DoubleStrike.
  /// </summary>
  public Boolean? DoubleStrike { get ; set; }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public Boolean? Outline { get ; set; }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public Boolean? Shadow { get ; set; }
  
  /// <summary>
  /// Emboss.
  /// </summary>
  public Boolean? Emboss { get ; set; }
  
  /// <summary>
  /// Imprint.
  /// </summary>
  public Boolean? Imprint { get ; set; }
  
  /// <summary>
  /// NoProof.
  /// </summary>
  public Boolean? NoProof { get ; set; }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  public Boolean? SnapToGrid { get ; set; }
  
  /// <summary>
  /// Vanish.
  /// </summary>
  public Boolean? Vanish { get ; set; }
  
  /// <summary>
  /// WebHidden.
  /// </summary>
  public Boolean? WebHidden { get ; set; }
  
  /// <summary>
  /// Color.
  /// </summary>
  public IColor? Color { get ; set; }
  
  /// <summary>
  /// Spacing.
  /// </summary>
  public Int32? Spacing { get ; set; }
  
  /// <summary>
  /// CharacterScale.
  /// </summary>
  public Int32? CharacterScale { get ; set; }
  
  /// <summary>
  /// Kern.
  /// </summary>
  public UInt32? Kern { get ; set; }
  
  /// <summary>
  /// Position.
  /// </summary>
  public String? Position { get ; set; }
  
  /// <summary>
  /// FontSize.
  /// </summary>
  public String? FontSize { get ; set; }
  
  /// <summary>
  /// FontSizeComplexScript.
  /// </summary>
  public String? FontSizeComplexScript { get ; set; }
  
  /// <summary>
  /// Underline.
  /// </summary>
  public IUnderline? Underline { get ; set; }
  
  /// <summary>
  /// TextEffect.
  /// </summary>
  public TextEffectKind? TextEffect { get ; set; }
  
  /// <summary>
  /// Border.
  /// </summary>
  public IBorderType? Border { get ; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public IShading? Shading { get ; set; }
  
  /// <summary>
  /// FitText.
  /// </summary>
  public IFitText? FitText { get ; set; }
  
  /// <summary>
  /// VerticalTextAlignment.
  /// </summary>
  public VerticalPositionKind? VerticalTextAlignment { get ; set; }
  
  /// <summary>
  /// Emphasis.
  /// </summary>
  public EmphasisMarkKind? Emphasis { get ; set; }
  
  /// <summary>
  /// Languages.
  /// </summary>
  public ILanguageType? Languages { get ; set; }
  
  /// <summary>
  /// EastAsianLayout.
  /// </summary>
  public IEastAsianLayout? EastAsianLayout { get ; set; }
  
  /// <summary>
  /// SpecVanish.
  /// </summary>
  public Boolean? SpecVanish { get ; set; }
  
  /// <summary>
  /// RunPropertiesChange.
  /// </summary>
  public IRunPropertiesChange? RunPropertiesChange { get ; set; }
  
}
