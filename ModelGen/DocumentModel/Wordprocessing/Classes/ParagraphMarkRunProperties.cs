namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of run properties applied to the glyph used to represent the physical location of the paragraph mark for this paragraph. This paragraph mark, being a physical character in the document, can be formatted, and therefore shall be capable of representing this formatting like any other character in the document.
/// </summary>
public partial class ParagraphMarkRunProperties
{
  
  /// <summary>
  ///   Inserted Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.Inserted? Inserted { get; set; }
  
  
  /// <summary>
  ///   Deleted Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.Deleted? Deleted { get; set; }
  
  
  /// <summary>
  ///   Move Source Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.MoveFrom? MoveFrom { get; set; }
  
  
  /// <summary>
  ///   Move Destination Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.MoveTo? MoveTo { get; set; }
  
  public DocumentModel.Wordprocessing.ConflictInsertion? ConflictInsertion { get; set; }
  
  public DocumentModel.Wordprocessing.ConflictDeletion? ConflictDeletion { get; set; }
  
  public DocumentModel.Wordprocessing.RunStyle? RunStyle { get; set; }
  
  public DocumentModel.Wordprocessing.RunFonts? RunFonts { get; set; }
  
  public DocumentModel.Wordprocessing.Bold? Bold { get; set; }
  
  public DocumentModel.Wordprocessing.BoldComplexScript? BoldComplexScript { get; set; }
  
  public DocumentModel.Wordprocessing.Italic? Italic { get; set; }
  
  public DocumentModel.Wordprocessing.ItalicComplexScript? ItalicComplexScript { get; set; }
  
  public DocumentModel.Wordprocessing.Caps? Caps { get; set; }
  
  public DocumentModel.Wordprocessing.SmallCaps? SmallCaps { get; set; }
  
  public DocumentModel.Wordprocessing.Strike? Strike { get; set; }
  
  public DocumentModel.Wordprocessing.DoubleStrike? DoubleStrike { get; set; }
  
  public DocumentModel.Wordprocessing.Outline? Outline { get; set; }
  
  public DocumentModel.Wordprocessing.Shadow? Shadow { get; set; }
  
  public DocumentModel.Wordprocessing.Emboss? Emboss { get; set; }
  
  public DocumentModel.Wordprocessing.Imprint? Imprint { get; set; }
  
  public DocumentModel.Wordprocessing.NoProof? NoProof { get; set; }
  
  public DocumentModel.Wordprocessing.SnapToGrid? SnapToGrid { get; set; }
  
  public DocumentModel.Wordprocessing.Vanish? Vanish { get; set; }
  
  public DocumentModel.Wordprocessing.WebHidden? WebHidden { get; set; }
  
  public DocumentModel.Wordprocessing.Color? Color { get; set; }
  
  public Int32? Spacing { get; set; }
  
  public Int64? CharacterScale { get; set; }
  
  public UInt32? Kern { get; set; }
  
  public String? Position { get; set; }
  
  public DocumentModel.Wordprocessing.FontSize? FontSize { get; set; }
  
  public DocumentModel.Wordprocessing.FontSizeComplexScript? FontSizeComplexScript { get; set; }
  
  public DocumentModel.Wordprocessing.HighlightColorKind? Highlight { get; set; }
  
  public DocumentModel.Wordprocessing.Underline? Underline { get; set; }
  
  public DocumentModel.Wordprocessing.TextEffectKind? TextEffect { get; set; }
  
  public DocumentModel.Wordprocessing.Border? Border { get; set; }
  
  public DocumentModel.Wordprocessing.Shading? Shading { get; set; }
  
  public DocumentModel.Wordprocessing.FitText? FitText { get; set; }
  
  public DocumentModel.Wordprocessing.VerticalPositionKind? VerticalTextAlignment { get; set; }
  
  public DocumentModel.Wordprocessing.RightToLeftText? RightToLeftText { get; set; }
  
  public DocumentModel.Wordprocessing.ComplexScript? ComplexScript { get; set; }
  
  public DocumentModel.Wordprocessing.EmphasisMarkKind? Emphasis { get; set; }
  
  public DocumentModel.Wordprocessing.Languages? Languages { get; set; }
  
  public DocumentModel.Wordprocessing.EastAsianLayout? EastAsianLayout { get; set; }
  
  public DocumentModel.Wordprocessing.SpecVanish? SpecVanish { get; set; }
  
  public DocumentModel.Wordprocessing.Glow? Glow { get; set; }
  
  public DocumentModel.Wordprocessing.Shadow? Shadow { get; set; }
  
  public DocumentModel.Wordprocessing.Reflection? Reflection { get; set; }
  
  public DocumentModel.Wordprocessing.TextOutlineEffect? TextOutlineEffect { get; set; }
  
  public DocumentModel.Wordprocessing.FillTextEffect? FillTextEffect { get; set; }
  
  public DocumentModel.Wordprocessing.Scene3D? Scene3D { get; set; }
  
  public DocumentModel.Wordprocessing.Properties3D? Properties3D { get; set; }
  
  public DocumentModel.Wordprocessing.LigaturesKind? Ligatures { get; set; }
  
  public DocumentModel.Wordprocessing.NumberFormKind? NumberingFormat { get; set; }
  
  public DocumentModel.Wordprocessing.NumberSpacingKind? NumberSpacing { get; set; }
  
  public DocumentModel.Wordprocessing.StylisticSets? StylisticSets { get; set; }
  
  public DocumentModel.Wordprocessing.ContextualAlternatives? ContextualAlternatives { get; set; }
  
  public DocumentModel.Wordprocessing.OfficeMath? OfficeMath { get; set; }
  
  public DocumentModel.Wordprocessing.ParagraphMarkRunPropertiesChange? ParagraphMarkRunPropertiesChange { get; set; }
  
}
