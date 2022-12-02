namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Run Properties for the Paragraph Mark.
/// </summary>
public interface IPreviousParagraphMarkRunProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Inserted Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.ITrackChangeType? Inserted { get ; set; }
  
  /// <summary>
  /// Deleted Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.ITrackChangeType? Deleted { get ; set; }
  
  /// <summary>
  /// Move Source Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.ITrackChangeType? MoveFrom { get ; set; }
  
  /// <summary>
  /// Move Destination Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.ITrackChangeType? MoveTo { get ; set; }
  
  public DocumentModel.Wordprocessing.ITrackChangeType? ConflictInsertion { get ; set; }
  
  public DocumentModel.Wordprocessing.ITrackChangeType? ConflictDeletion { get ; set; }
  
  public System.String? RunStyle { get ; set; }
  
  public DocumentModel.Wordprocessing.IRunFonts? RunFonts { get ; set; }
  
  public System.Boolean? Bold { get ; set; }
  
  public System.Boolean? BoldComplexScript { get ; set; }
  
  public System.Boolean? Italic { get ; set; }
  
  public System.Boolean? ItalicComplexScript { get ; set; }
  
  public System.Boolean? Caps { get ; set; }
  
  public System.Boolean? SmallCaps { get ; set; }
  
  public System.Boolean? Strike { get ; set; }
  
  public System.Boolean? DoubleStrike { get ; set; }
  
  public System.Boolean? Outline { get ; set; }
  
  public System.Boolean? Shadow { get ; set; }
  
  public System.Boolean? Emboss { get ; set; }
  
  public System.Boolean? Imprint { get ; set; }
  
  public System.Boolean? NoProof { get ; set; }
  
  public System.Boolean? SnapToGrid { get ; set; }
  
  public System.Boolean? Vanish { get ; set; }
  
  public System.Boolean? WebHidden { get ; set; }
  
  public DocumentModel.Wordprocessing.IColor? Color { get ; set; }
  
  public System.Int32? Spacing { get ; set; }
  
  public System.Int32? CharacterScale { get ; set; }
  
  public System.UInt32? Kern { get ; set; }
  
  public System.String? Position { get ; set; }
  
  public System.String? FontSize { get ; set; }
  
  public System.String? FontSizeComplexScript { get ; set; }
  
  public DocumentModel.Wordprocessing.HighlightColorKind? Highlight { get ; set; }
  
  public DocumentModel.Wordprocessing.IUnderline? Underline { get ; set; }
  
  public DocumentModel.Wordprocessing.TextEffectKind? TextEffect { get ; set; }
  
  public DocumentModel.Wordprocessing.IBorderType? Border { get ; set; }
  
  public DocumentModel.Wordprocessing.IShading? Shading { get ; set; }
  
  public DocumentModel.Wordprocessing.IFitText? FitText { get ; set; }
  
  public DocumentModel.Wordprocessing.VerticalPositionKind? VerticalTextAlignment { get ; set; }
  
  public System.Boolean? RightToLeftText { get ; set; }
  
  public System.Boolean? ComplexScript { get ; set; }
  
  public DocumentModel.Wordprocessing.EmphasisMarkKind? Emphasis { get ; set; }
  
  public DocumentModel.Wordprocessing.ILanguageType? Languages { get ; set; }
  
  public DocumentModel.Wordprocessing.IEastAsianLayout? EastAsianLayout { get ; set; }
  
  public System.Boolean? SpecVanish { get ; set; }
  
  public DocumentModel.Wordprocessing.IGlow? Glow { get ; set; }
  
  public DocumentModel.Wordprocessing.IReflection? Reflection { get ; set; }
  
  public DocumentModel.Wordprocessing.ITextOutlineEffect? TextOutlineEffect { get ; set; }
  
  public DocumentModel.Wordprocessing.IFillTextEffect? FillTextEffect { get ; set; }
  
  public DocumentModel.Wordprocessing.IScene3D? Scene3D { get ; set; }
  
  public DocumentModel.Wordprocessing.IProperties3D? Properties3D { get ; set; }
  
  public DocumentModel.Wordprocessing.LigaturesKind? Ligatures { get ; set; }
  
  public DocumentModel.Wordprocessing.NumberFormKind? NumberingFormat { get ; set; }
  
  public DocumentModel.Wordprocessing.NumberSpacingKind? NumberSpacing { get ; set; }
  
  public DocumentModel.Wordprocessing.IStylisticSets? StylisticSets { get ; set; }
  
  public DocumentModel.Wordprocessing.OnOffKind? ContextualAlternatives { get ; set; }
  
  public System.Boolean? OfficeMath { get ; set; }
  
}
