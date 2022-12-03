namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Run Properties for the Paragraph Mark.
/// </summary>
public interface PreviousParagraphMarkRunProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Inserted Paragraph.
  /// </summary>
  public TrackChangeType? Inserted { get ; set; }
  
  /// <summary>
  /// Deleted Paragraph.
  /// </summary>
  public TrackChangeType? Deleted { get ; set; }
  
  /// <summary>
  /// Move Source Paragraph.
  /// </summary>
  public TrackChangeType? MoveFrom { get ; set; }
  
  /// <summary>
  /// Move Destination Paragraph.
  /// </summary>
  public TrackChangeType? MoveTo { get ; set; }
  
  public TrackChangeType? ConflictInsertion { get ; set; }
  
  public TrackChangeType? ConflictDeletion { get ; set; }
  
  public Collection<String>? RunStyles { get ; set; }
  
  public Collection<RunFonts>? RunFontses { get ; set; }
  
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
  
  public Collection<Color>? Colors { get ; set; }
  
  public Collection<Int32>? Spacings { get ; set; }
  
  public Collection<Int32>? CharacterScales { get ; set; }
  
  public Collection<UInt32>? Kerns { get ; set; }
  
  public Collection<String>? Positions { get ; set; }
  
  public Collection<String>? FontSizes { get ; set; }
  
  public Collection<String>? FontSizeComplexScripts { get ; set; }
  
  public Collection<HighlightColorKind>? Highlights { get ; set; }
  
  public Collection<Underline>? Underlines { get ; set; }
  
  public Collection<TextEffectKind>? TextEffects { get ; set; }
  
  public Collection<BorderType>? Borders { get ; set; }
  
  public Collection<Shading>? Shadings { get ; set; }
  
  public Collection<FitText>? FitTexts { get ; set; }
  
  public Collection<VerticalPositionKind>? VerticalTextAlignments { get ; set; }
  
  public Collection<Boolean>? RightToLeftTexts { get ; set; }
  
  public Collection<Boolean>? ComplexScripts { get ; set; }
  
  public Collection<EmphasisMarkKind>? Emphasises { get ; set; }
  
  public Collection<LanguageType>? Languageses { get ; set; }
  
  public Collection<EastAsianLayout>? EastAsianLayouts { get ; set; }
  
  public Collection<Boolean>? SpecVanishs { get ; set; }
  
  public Collection<Glow>? Glows { get ; set; }
  
  public Collection<Reflection>? Reflections { get ; set; }
  
  public Collection<TextOutlineEffect>? TextOutlineEffects { get ; set; }
  
  public Collection<FillTextEffect>? FillTextEffects { get ; set; }
  
  public Collection<Scene3D>? Scene3Ds { get ; set; }
  
  public Collection<Properties3D>? Properties3Ds { get ; set; }
  
  public Collection<LigaturesKind>? Ligatureses { get ; set; }
  
  public Collection<NumberFormKind>? NumberingFormats { get ; set; }
  
  public Collection<NumberSpacingKind>? NumberSpacings { get ; set; }
  
  public Collection<StylisticSets>? StylisticSetses { get ; set; }
  
  public Collection<OnOffKind>? ContextualAlternativeses { get ; set; }
  
  public Collection<Boolean>? OfficeMaths { get ; set; }
  
}
