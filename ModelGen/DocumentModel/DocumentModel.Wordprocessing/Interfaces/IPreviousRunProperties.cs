namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Run Properties.
/// </summary>
public interface IPreviousRunProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<String>? RunStyles { get ; set; }
  
  public Collection<IRunFonts>? RunFontses { get ; set; }
  
  public Collection<Boolean>? Bolds { get ; set; }
  
  public Collection<Boolean>? BoldComplexScripts { get ; set; }
  
  public Collection<Boolean>? Italics { get ; set; }
  
  public Collection<Boolean>? ItalicComplexScripts { get ; set; }
  
  public Collection<Boolean>? Capses { get ; set; }
  
  public Collection<Boolean>? SmallCapses { get ; set; }
  
  public Collection<Boolean>? Strikes { get ; set; }
  
  public Collection<Boolean>? DoubleStrikes { get ; set; }
  
  public Collection<Boolean>? Outlines { get ; set; }
  
  public Collection<Boolean>? Shadows { get ; set; }
  
  public Collection<Boolean>? Embosses { get ; set; }
  
  public Collection<Boolean>? Imprints { get ; set; }
  
  public Collection<Boolean>? NoProofs { get ; set; }
  
  public Collection<Boolean>? SnapToGrids { get ; set; }
  
  public Collection<Boolean>? Vanishs { get ; set; }
  
  public Collection<Boolean>? WebHiddens { get ; set; }
  
  public Collection<IColor>? Colors { get ; set; }
  
  public Collection<Int32>? Spacings { get ; set; }
  
  public Collection<Int32>? CharacterScales { get ; set; }
  
  public Collection<UInt32>? Kerns { get ; set; }
  
  public Collection<String>? Positions { get ; set; }
  
  public Collection<String>? FontSizes { get ; set; }
  
  public Collection<String>? FontSizeComplexScripts { get ; set; }
  
  public Collection<HighlightColorKind>? Highlights { get ; set; }
  
  public Collection<IUnderline>? Underlines { get ; set; }
  
  public Collection<TextEffectKind>? TextEffects { get ; set; }
  
  public Collection<IBorderType>? Borders { get ; set; }
  
  public Collection<IShading>? Shadings { get ; set; }
  
  public Collection<IFitText>? FitTexts { get ; set; }
  
  public Collection<VerticalPositionKind>? VerticalTextAlignments { get ; set; }
  
  public Collection<Boolean>? RightToLeftTexts { get ; set; }
  
  public Collection<Boolean>? ComplexScripts { get ; set; }
  
  public Collection<EmphasisMarkKind>? Emphasises { get ; set; }
  
  public Collection<ILanguageType>? Languageses { get ; set; }
  
  public Collection<IEastAsianLayout>? EastAsianLayouts { get ; set; }
  
  public Collection<Boolean>? SpecVanishs { get ; set; }
  
  public Collection<IGlow>? Glows { get ; set; }
  
  public Collection<IReflection>? Reflections { get ; set; }
  
  public Collection<ITextOutlineEffect>? TextOutlineEffects { get ; set; }
  
  public Collection<IFillTextEffect>? FillTextEffects { get ; set; }
  
  public Collection<IScene3D>? Scene3Ds { get ; set; }
  
  public Collection<IProperties3D>? Properties3Ds { get ; set; }
  
  public Collection<LigaturesKind>? Ligatureses { get ; set; }
  
  public Collection<NumberFormKind>? NumberingFormats { get ; set; }
  
  public Collection<NumberSpacingKind>? NumberSpacings { get ; set; }
  
  public Collection<IStylisticSets>? StylisticSetses { get ; set; }
  
  public Collection<OnOffKind>? ContextualAlternativeses { get ; set; }
  
}
