namespace DocumentModel.Wordprocessing;

/// <summary>
/// Run Properties.
/// </summary>
public interface IRunPropertiesBaseStyle // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RunFonts.
  /// </summary>
  public IRunFonts? RunFonts { get ; set; }
  
  /// <summary>
  /// Bold.
  /// </summary>
  public IBold? Bold { get ; set; }
  
  /// <summary>
  /// BoldComplexScript.
  /// </summary>
  public IBoldComplexScript? BoldComplexScript { get ; set; }
  
  /// <summary>
  /// Italic.
  /// </summary>
  public Italic? Italic { get ; set; }
  
  /// <summary>
  /// ItalicComplexScript.
  /// </summary>
  public ItalicComplexScript? ItalicComplexScript { get ; set; }
  
  /// <summary>
  /// Caps.
  /// </summary>
  public ICaps? Caps { get ; set; }
  
  /// <summary>
  /// SmallCaps.
  /// </summary>
  public ISmallCaps? SmallCaps { get ; set; }
  
  /// <summary>
  /// Strike.
  /// </summary>
  public IStrike? Strike { get ; set; }
  
  /// <summary>
  /// DoubleStrike.
  /// </summary>
  public IDoubleStrike? DoubleStrike { get ; set; }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public IOutline? Outline { get ; set; }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public IShadow? Shadow { get ; set; }
  
  /// <summary>
  /// Emboss.
  /// </summary>
  public IEmboss? Emboss { get ; set; }
  
  /// <summary>
  /// Imprint.
  /// </summary>
  public Imprint? Imprint { get ; set; }
  
  /// <summary>
  /// NoProof.
  /// </summary>
  public INoProof? NoProof { get ; set; }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  public ISnapToGrid? SnapToGrid { get ; set; }
  
  /// <summary>
  /// Vanish.
  /// </summary>
  public IVanish? Vanish { get ; set; }
  
  /// <summary>
  /// WebHidden.
  /// </summary>
  public IWebHidden? WebHidden { get ; set; }
  
  /// <summary>
  /// Color.
  /// </summary>
  public IColor? Color { get ; set; }
  
  /// <summary>
  /// Spacing.
  /// </summary>
  public Int32Value? Spacing { get ; set; }
  
  /// <summary>
  /// CharacterScale.
  /// </summary>
  public IntegerValue? CharacterScale { get ; set; }
  
  /// <summary>
  /// Kern.
  /// </summary>
  public IUInt32Value? Kern { get ; set; }
  
  /// <summary>
  /// Position.
  /// </summary>
  public IStringValue? Position { get ; set; }
  
  /// <summary>
  /// FontSize.
  /// </summary>
  public IFontSize? FontSize { get ; set; }
  
  /// <summary>
  /// FontSizeComplexScript.
  /// </summary>
  public IFontSizeComplexScript? FontSizeComplexScript { get ; set; }
  
  /// <summary>
  /// Underline.
  /// </summary>
  public IUnderline? Underline { get ; set; }
  
  /// <summary>
  /// TextEffect.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.TextEffectValues>? TextEffect { get ; set; }
  
  /// <summary>
  /// Border.
  /// </summary>
  public IBorder? Border { get ; set; }
  
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
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues>? VerticalTextAlignment { get ; set; }
  
  /// <summary>
  /// Emphasis.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues>? Emphasis { get ; set; }
  
  /// <summary>
  /// Languages.
  /// </summary>
  public ILanguages? Languages { get ; set; }
  
  /// <summary>
  /// EastAsianLayout.
  /// </summary>
  public IEastAsianLayout? EastAsianLayout { get ; set; }
  
  /// <summary>
  /// SpecVanish.
  /// </summary>
  public ISpecVanish? SpecVanish { get ; set; }
  
}
