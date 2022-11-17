namespace DocumentModel.Wordprocessing;

public interface IRunProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IRunStyle? RunStyle { get ; set; }

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

  public DocumentModel.Wordprocessing.IHighlight? Highlight { get ; set; }

  public DocumentModel.Wordprocessing.IUnderline? Underline { get ; set; }

  public ITextEffect? TextEffect { get ; set; }

  public DocumentModel.Wordprocessing.IBorder? Border { get ; set; }

  public IShading? Shading { get ; set; }

  public IFitText? FitText { get ; set; }

  public DocumentModel.Wordprocessing.IVerticalTextAlignment? VerticalTextAlignment { get ; set; }

  public IRightToLeftText? RightToLeftText { get ; set; }

  public IComplexScript? ComplexScript { get ; set; }

  public IEmphasis? Emphasis { get ; set; }

  public ILanguages? Languages { get ; set; }

  public IEastAsianLayout? EastAsianLayout { get ; set; }

  public ISpecVanish? SpecVanish { get ; set; }

  public DocumentModel.Office2010.Word.IGlow? Glow { get ; set; }

  public DocumentModel.Office2010.Word.IShadow? Shadow14 { get ; set; }

  public DocumentModel.Office2010.Word.IReflection? Reflection { get ; set; }

  public ITextOutlineEffect? TextOutlineEffect { get ; set; }

  public IFillTextEffect? FillTextEffect { get ; set; }

  public DocumentModel.Office2010.Word.IScene3D? Scene3D { get ; set; }

  public IProperties3D? Properties3D { get ; set; }

  public ILigatures? Ligatures { get ; set; }

  public DocumentModel.Office2010.Word.INumberingFormat? NumberingFormat { get ; set; }

  public INumberSpacing? NumberSpacing { get ; set; }

  public IStylisticSets? StylisticSets { get ; set; }

  public IContextualAlternatives? ContextualAlternatives { get ; set; }

  public IRunPropertiesChange? RunPropertiesChange { get ; set; }

}
