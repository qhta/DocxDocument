namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Run Properties.
/// </summary>
public partial class PreviousRunProperties
{
  public String? RunStyle { get; set; }
  
  public DocumentModel.Wordprocessing.RunFonts? RunFonts { get; set; }
  
  public Boolean? Bold { get; set; }
  
  public Boolean? BoldComplexScript { get; set; }
  
  public Boolean? Italic { get; set; }
  
  public Boolean? ItalicComplexScript { get; set; }
  
  public Boolean? Caps { get; set; }
  
  public Boolean? SmallCaps { get; set; }
  
  public Boolean? Strike { get; set; }
  
  public Boolean? DoubleStrike { get; set; }
  
  public Boolean? Outline { get; set; }
  
  public Boolean? Shadow { get; set; }
  
  public Boolean? Emboss { get; set; }
  
  public Boolean? Imprint { get; set; }
  
  public Boolean? NoProof { get; set; }
  
  public Boolean? SnapToGrid { get; set; }
  
  public Boolean? Vanish { get; set; }
  
  public Boolean? WebHidden { get; set; }
  
  public DocumentModel.Wordprocessing.Color? Color { get; set; }
  
  public Int32? Spacing { get; set; }
  
  public Int32? CharacterScale { get; set; }
  
  public UInt32? Kern { get; set; }
  
  public String? Position { get; set; }
  
  public String? FontSize { get; set; }
  
  public String? FontSizeComplexScript { get; set; }
  
  public DocumentModel.Wordprocessing.HighlightColorKind? Highlight { get; set; }
  
  public DocumentModel.Wordprocessing.Underline? Underline { get; set; }
  
  public DocumentModel.Wordprocessing.TextEffectKind? TextEffect { get; set; }
  
  public DocumentModel.Wordprocessing.BorderType? Border { get; set; }
  
  public DocumentModel.Wordprocessing.Shading? Shading { get; set; }
  
  public DocumentModel.Wordprocessing.FitText? FitText { get; set; }
  
  public DocumentModel.Wordprocessing.VerticalPositionKind? VerticalTextAlignment { get; set; }
  
  public Boolean? RightToLeftText { get; set; }
  
  public Boolean? ComplexScript { get; set; }
  
  public DocumentModel.Wordprocessing.EmphasisMarkKind? Emphasis { get; set; }
  
  public DocumentModel.Wordprocessing.LanguageType? Languages { get; set; }
  
  public DocumentModel.Wordprocessing.EastAsianLayout? EastAsianLayout { get; set; }
  
  public Boolean? SpecVanish { get; set; }
  
  public DocumentModel.Wordprocessing.Glow? Glow { get; set; }
  
  public DocumentModel.Wordprocessing.Reflection? Reflection { get; set; }
  
  public DocumentModel.Wordprocessing.TextOutlineEffect? TextOutlineEffect { get; set; }
  
  public DocumentModel.Wordprocessing.FillTextEffect? FillTextEffect { get; set; }
  
  public DocumentModel.Wordprocessing.Scene3D? Scene3D { get; set; }
  
  public DocumentModel.Wordprocessing.Properties3D? Properties3D { get; set; }
  
  public DocumentModel.Wordprocessing.LigaturesKind? Ligatures { get; set; }
  
  public DocumentModel.Wordprocessing.NumberFormKind? NumberingFormat { get; set; }
  
  public DocumentModel.Wordprocessing.NumberSpacingKind? NumberSpacing { get; set; }
  
  public DocumentModel.Wordprocessing.StylisticSets? StylisticSets { get; set; }
  
  public DocumentModel.Wordprocessing.OnOffKind? ContextualAlternatives { get; set; }
  
}
