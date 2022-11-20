namespace DocumentModel.Wordprocessing;

/// <summary>
/// Run Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IColor))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEastAsianLayout))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEmphasis))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFitText))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRunFonts))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IKern))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFontSize))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFontSizeComplexScript))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILanguages))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBold))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBoldComplexScript))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IItalic))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IItalicComplexScript))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICaps))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISmallCaps))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStrike))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDoubleStrike))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IOutline))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IShadow))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEmboss))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IImprint))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INoProof))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISnapToGrid))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IVanish))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IWebHidden))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISpecVanish))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IShading))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISpacing))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPosition))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITextEffect))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICharacterScale))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IUnderline))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IVerticalTextAlignment))]
public interface IRunPropertiesBaseStyle // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// RunFonts.
  /// </summary>
  public IRunFonts? RunFonts { get ; set; }
  
  /// <summary>
  /// Bold.
  /// </summary>
  public DocumentModel.Wordprocessing.IBold? Bold { get ; set; }
  
  /// <summary>
  /// BoldComplexScript.
  /// </summary>
  public IBoldComplexScript? BoldComplexScript { get ; set; }
  
  /// <summary>
  /// Italic.
  /// </summary>
  public DocumentModel.Wordprocessing.IItalic? Italic { get ; set; }
  
  /// <summary>
  /// ItalicComplexScript.
  /// </summary>
  public IItalicComplexScript? ItalicComplexScript { get ; set; }
  
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
  public DocumentModel.Wordprocessing.IStrike? Strike { get ; set; }
  
  /// <summary>
  /// DoubleStrike.
  /// </summary>
  public IDoubleStrike? DoubleStrike { get ; set; }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public DocumentModel.Wordprocessing.IOutline? Outline { get ; set; }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public DocumentModel.Wordprocessing.IShadow? Shadow { get ; set; }
  
  /// <summary>
  /// Emboss.
  /// </summary>
  public IEmboss? Emboss { get ; set; }
  
  /// <summary>
  /// Imprint.
  /// </summary>
  public IImprint? Imprint { get ; set; }
  
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
  public DocumentModel.Wordprocessing.IColor? Color { get ; set; }
  
  /// <summary>
  /// Spacing.
  /// </summary>
  public ISpacing? Spacing { get ; set; }
  
  /// <summary>
  /// CharacterScale.
  /// </summary>
  public ICharacterScale? CharacterScale { get ; set; }
  
  /// <summary>
  /// Kern.
  /// </summary>
  public IKern? Kern { get ; set; }
  
  /// <summary>
  /// Position.
  /// </summary>
  public DocumentModel.Wordprocessing.IPosition? Position { get ; set; }
  
  /// <summary>
  /// FontSize.
  /// </summary>
  public DocumentModel.Wordprocessing.IFontSize? FontSize { get ; set; }
  
  /// <summary>
  /// FontSizeComplexScript.
  /// </summary>
  public IFontSizeComplexScript? FontSizeComplexScript { get ; set; }
  
  /// <summary>
  /// Underline.
  /// </summary>
  public DocumentModel.Wordprocessing.IUnderline? Underline { get ; set; }
  
  /// <summary>
  /// TextEffect.
  /// </summary>
  public ITextEffect? TextEffect { get ; set; }
  
  /// <summary>
  /// Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorder? Border { get ; set; }
  
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
  public DocumentModel.Wordprocessing.IVerticalTextAlignment? VerticalTextAlignment { get ; set; }
  
  /// <summary>
  /// Emphasis.
  /// </summary>
  public IEmphasis? Emphasis { get ; set; }
  
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
