namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of run properties applied to the glyph used to represent the physical location of the paragraph mark for this paragraph. This paragraph mark, being a physical character in the document, can be formatted, and therefore shall be capable of representing this formatting like any other character in the document.
/// </summary>
public partial class ParagraphMarkRunProperties
{
  
  /// <summary>
  ///   Inserted Paragraph.
  /// </summary>
  public DMW.Inserted? Inserted { get; set; }
  
  
  /// <summary>
  ///   Deleted Paragraph.
  /// </summary>
  public DMW.Deleted? Deleted { get; set; }
  
  
  /// <summary>
  ///   Move Source Paragraph.
  /// </summary>
  public DMW.MoveFrom? MoveFrom { get; set; }
  
  
  /// <summary>
  ///   Move Destination Paragraph.
  /// </summary>
  public DMW.MoveTo? MoveTo { get; set; }
  
  public DMW10.ConflictInsertion? ConflictInsertion { get; set; }
  
  public DMW10.ConflictDeletion? ConflictDeletion { get; set; }
  
  public DMW.RunStyle? RunStyle { get; set; }
  
  public DMW.RunFonts? RunFonts { get; set; }
  
  public DMW.Bold? Bold { get; set; }
  
  public DMW.BoldComplexScript? BoldComplexScript { get; set; }
  
  public DMW.Italic? Italic { get; set; }
  
  public DMW.ItalicComplexScript? ItalicComplexScript { get; set; }
  
  public DMW.Caps? Caps { get; set; }
  
  public DMW.SmallCaps? SmallCaps { get; set; }
  
  public DMW.Strike? Strike { get; set; }
  
  public DMW.DoubleStrike? DoubleStrike { get; set; }
  
  public DMW.Outline? Outline { get; set; }
  
  public DMW.Shadow? Shadow { get; set; }
  
  public DMW.Emboss? Emboss { get; set; }
  
  public DMW.Imprint? Imprint { get; set; }
  
  public DMW.NoProof? NoProof { get; set; }
  
  public DMW.SnapToGrid? SnapToGrid { get; set; }
  
  public DMW.Vanish? Vanish { get; set; }
  
  public DMW.WebHidden? WebHidden { get; set; }
  
  public DMW.Color? Color { get; set; }
  
  public Int32? Spacing { get; set; }
  
  public Int64? CharacterScale { get; set; }
  
  public UInt32? Kern { get; set; }
  
  public String? Position { get; set; }
  
  public DMW.FontSize? FontSize { get; set; }
  
  public DMW.FontSizeComplexScript? FontSizeComplexScript { get; set; }
  
  public DMW.HighlightColorKind? Highlight { get; set; }
  
  public DMW.Underline? Underline { get; set; }
  
  public DMW.TextEffectKind? TextEffect { get; set; }
  
  public DMW.Border? Border { get; set; }
  
  public DMW.Shading? Shading { get; set; }
  
  public DMW.FitText? FitText { get; set; }
  
  public DMW.VerticalPositionKind? VerticalTextAlignment { get; set; }
  
  public DMW.RightToLeftText? RightToLeftText { get; set; }
  
  public DMW.ComplexScript? ComplexScript { get; set; }
  
  public DMW.EmphasisMarkKind? Emphasis { get; set; }
  
  public DMW.Languages? Languages { get; set; }
  
  public DMW.EastAsianLayout? EastAsianLayout { get; set; }
  
  public DMW.SpecVanish? SpecVanish { get; set; }
  
  public DMW10.Glow? Glow { get; set; }
  
  public DMW10.Reflection? Reflection { get; set; }
  
  public DMW10.TextOutlineEffect? TextOutlineEffect { get; set; }
  
  public DMW10.FillTextEffect? FillTextEffect { get; set; }
  
  public DMW10.Scene3D? Scene3D { get; set; }
  
  public DMW10.Properties3D? Properties3D { get; set; }
  
  public DMW10.LigaturesKind? Ligatures { get; set; }
  
  public DMW10.NumberFormKind? NumberingFormat { get; set; }
  
  public DMW10.NumberSpacingKind? NumberSpacing { get; set; }
  
  public DMW10.StylisticSets? StylisticSets { get; set; }
  
  public DMW10.ContextualAlternatives? ContextualAlternatives { get; set; }
  
  public DMW.OfficeMath? OfficeMath { get; set; }
  
  public DMW.ParagraphMarkRunPropertiesChange? ParagraphMarkRunPropertiesChange { get; set; }
  
}
