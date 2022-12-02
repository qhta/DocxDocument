namespace DocumentModel.Wordprocessing;

/// <summary>
/// Run Properties for the Paragraph Mark.
/// </summary>
public interface IParagraphMarkRunProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Inserted Paragraph.
  /// </summary>
  public ITrackChangeType? Inserted { get ; set; }
  
  /// <summary>
  /// Deleted Paragraph.
  /// </summary>
  public ITrackChangeType? Deleted { get ; set; }
  
  /// <summary>
  /// Move Source Paragraph.
  /// </summary>
  public ITrackChangeType? MoveFrom { get ; set; }
  
  /// <summary>
  /// Move Destination Paragraph.
  /// </summary>
  public ITrackChangeType? MoveTo { get ; set; }
  
  public ITrackChangeType? ConflictInsertion { get ; set; }
  
  public ITrackChangeType? ConflictDeletion { get ; set; }
  
  public String? RunStyle { get ; set; }
  
  public IRunFonts? RunFonts { get ; set; }
  
  public Boolean? Bold { get ; set; }
  
  public Boolean? BoldComplexScript { get ; set; }
  
  public Boolean? Italic { get ; set; }
  
  public Boolean? ItalicComplexScript { get ; set; }
  
  public Boolean? Caps { get ; set; }
  
  public Boolean? SmallCaps { get ; set; }
  
  public Boolean? Strike { get ; set; }
  
  public Boolean? DoubleStrike { get ; set; }
  
  public Boolean? Outline { get ; set; }
  
  public Boolean? Shadow { get ; set; }
  
  public Boolean? Emboss { get ; set; }
  
  public Boolean? Imprint { get ; set; }
  
  public Boolean? NoProof { get ; set; }
  
  public Boolean? SnapToGrid { get ; set; }
  
  public Boolean? Vanish { get ; set; }
  
  public Boolean? WebHidden { get ; set; }
  
  public IColor? Color { get ; set; }
  
  public Int32? Spacing { get ; set; }
  
  public Int32? CharacterScale { get ; set; }
  
  public UInt32? Kern { get ; set; }
  
  public String? Position { get ; set; }
  
  public String? FontSize { get ; set; }
  
  public String? FontSizeComplexScript { get ; set; }
  
  public HighlightColorKind? Highlight { get ; set; }
  
  public IUnderline? Underline { get ; set; }
  
  public TextEffectKind? TextEffect { get ; set; }
  
  public IBorderType? Border { get ; set; }
  
  public IShading? Shading { get ; set; }
  
  public IFitText? FitText { get ; set; }
  
  public VerticalPositionKind? VerticalTextAlignment { get ; set; }
  
  public Boolean? RightToLeftText { get ; set; }
  
  public Boolean? ComplexScript { get ; set; }
  
  public EmphasisMarkKind? Emphasis { get ; set; }
  
  public ILanguageType? Languages { get ; set; }
  
  public IEastAsianLayout? EastAsianLayout { get ; set; }
  
  public Boolean? SpecVanish { get ; set; }
  
  public IGlow? Glow { get ; set; }
  
  public IReflection? Reflection { get ; set; }
  
  public ITextOutlineEffect? TextOutlineEffect { get ; set; }
  
  public IFillTextEffect? FillTextEffect { get ; set; }
  
  public IScene3D? Scene3D { get ; set; }
  
  public IProperties3D? Properties3D { get ; set; }
  
  public LigaturesKind? Ligatures { get ; set; }
  
  public NumberFormKind? NumberingFormat { get ; set; }
  
  public NumberSpacingKind? NumberSpacing { get ; set; }
  
  public IStylisticSets? StylisticSets { get ; set; }
  
  public OnOffKind? ContextualAlternatives { get ; set; }
  
  public Boolean? OfficeMath { get ; set; }
  
  public IParagraphMarkRunPropertiesChange? ParagraphMarkRunPropertiesChange { get ; set; }
  
}
