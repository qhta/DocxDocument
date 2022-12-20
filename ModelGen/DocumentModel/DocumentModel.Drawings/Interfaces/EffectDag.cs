namespace DocumentModel.Drawings;

/// <summary>
/// Effect Container.
/// </summary>
public partial interface EffectDag
{
  public DocumentModel.Drawings.EffectContainer? EffectContainer { get; set; }
  
  public DocumentModel.Drawings.Effect? Effect { get; set; }
  
  public DocumentModel.Drawings.AlphaBiLevel? AlphaBiLevel { get; set; }
  
  public Boolean? AlphaCeiling { get; set; }
  
  public Boolean? AlphaFloor { get; set; }
  
  public DocumentModel.Drawings.AlphaInverse? AlphaInverse { get; set; }
  
  public DocumentModel.Drawings.AlphaModulationEffect? AlphaModulationEffect { get; set; }
  
  public DocumentModel.Drawings.AlphaModulationFixed? AlphaModulationFixed { get; set; }
  
  public DocumentModel.Drawings.AlphaOutset? AlphaOutset { get; set; }
  
  public DocumentModel.Drawings.AlphaReplace? AlphaReplace { get; set; }
  
  public DocumentModel.Drawings.BiLevel? BiLevel { get; set; }
  
  public DocumentModel.Drawings.Blend? Blend { get; set; }
  
  public DocumentModel.Drawings.Blur? Blur { get; set; }
  
  public DocumentModel.Drawings.ColorChange? ColorChange { get; set; }
  
  public DocumentModel.Drawings.ColorReplacement? ColorReplacement { get; set; }
  
  public DocumentModel.Drawings.Duotone? Duotone { get; set; }
  
  public DocumentModel.Drawings.Fill? Fill { get; set; }
  
  public DocumentModel.Drawings.FillOverlay? FillOverlay { get; set; }
  
  public DocumentModel.Drawings.Glow? Glow { get; set; }
  
  public Boolean? Grayscale { get; set; }
  
  public DocumentModel.Drawings.Hsl? Hsl { get; set; }
  
  public DocumentModel.Drawings.InnerShadow? InnerShadow { get; set; }
  
  public DocumentModel.Drawings.LuminanceEffect? LuminanceEffect { get; set; }
  
  public DocumentModel.Drawings.OuterShadow? OuterShadow { get; set; }
  
  public DocumentModel.Drawings.PresetShadow? PresetShadow { get; set; }
  
  public DocumentModel.Drawings.Reflection? Reflection { get; set; }
  
  public DocumentModel.Drawings.RelativeOffset? RelativeOffset { get; set; }
  
  public DocumentModel.Drawings.SoftEdge? SoftEdge { get; set; }
  
  public DocumentModel.Drawings.TintEffect? TintEffect { get; set; }
  
  public DocumentModel.Drawings.TransformEffect? TransformEffect { get; set; }
  
}
