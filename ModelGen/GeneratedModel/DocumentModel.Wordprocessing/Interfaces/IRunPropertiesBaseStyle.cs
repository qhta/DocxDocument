namespace DocumentModel.Wordprocessing;

public interface IRunPropertiesBaseStyle // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IRunFonts? RunFonts { get ; set; }
  
  public DocumentModel.Wordprocessing.IBold? Bold { get ; set; }
  
  public IBoldComplexScript? BoldComplexScript { get ; set; }
  
  public DocumentModel.Wordprocessing.IItalic? Italic { get ; set; }
  
  public IItalicComplexScript? ItalicComplexScript { get ; set; }
  
  public ICaps? Caps { get ; set; }
  
  public ISmallCaps? SmallCaps { get ; set; }
  
  public DocumentModel.Wordprocessing.IStrike? Strike { get ; set; }
  
  public IDoubleStrike? DoubleStrike { get ; set; }
  
  public DocumentModel.Wordprocessing.IOutline? Outline { get ; set; }
  
  public DocumentModel.Wordprocessing.IShadow? Shadow { get ; set; }
  
  public IEmboss? Emboss { get ; set; }
  
  public IImprint? Imprint { get ; set; }
  
  public INoProof? NoProof { get ; set; }
  
  public ISnapToGrid? SnapToGrid { get ; set; }
  
  public IVanish? Vanish { get ; set; }
  
  public IWebHidden? WebHidden { get ; set; }
  
  public DocumentModel.Wordprocessing.IColor? Color { get ; set; }
  
  public ISpacing? Spacing { get ; set; }
  
  public ICharacterScale? CharacterScale { get ; set; }
  
  public IKern? Kern { get ; set; }
  
  public DocumentModel.Wordprocessing.IPosition? Position { get ; set; }
  
  public DocumentModel.Wordprocessing.IFontSize? FontSize { get ; set; }
  
  public IFontSizeComplexScript? FontSizeComplexScript { get ; set; }
  
  public DocumentModel.Wordprocessing.IUnderline? Underline { get ; set; }
  
  public ITextEffect? TextEffect { get ; set; }
  
  public DocumentModel.Wordprocessing.IBorder? Border { get ; set; }
  
  public IShading? Shading { get ; set; }
  
  public IFitText? FitText { get ; set; }
  
  public DocumentModel.Wordprocessing.IVerticalTextAlignment? VerticalTextAlignment { get ; set; }
  
  public IEmphasis? Emphasis { get ; set; }
  
  public ILanguages? Languages { get ; set; }
  
  public IEastAsianLayout? EastAsianLayout { get ; set; }
  
  public ISpecVanish? SpecVanish { get ; set; }
  
}
