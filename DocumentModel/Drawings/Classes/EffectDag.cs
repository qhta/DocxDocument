namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Effect Container.
/// </summary>
public class EffectDag: ModelElement
{
  public EffectContainer? EffectContainer { get; set; }

  public Effect? Effect { get; set; }

  public AlphaBiLevel? AlphaBiLevel { get; set; }

  public bool? AlphaCeiling { get; set; }

  public bool? AlphaFloor { get; set; }

  public AlphaInverse? AlphaInverse { get; set; }

  public AlphaModulationEffect? AlphaModulationEffect { get; set; }

  public AlphaModulationFixed? AlphaModulationFixed { get; set; }

  public AlphaOutset? AlphaOutset { get; set; }

  public AlphaReplace? AlphaReplace { get; set; }

  public BiLevel? BiLevel { get; set; }

  public Blend? Blend { get; set; }

  public Blur? Blur { get; set; }

  public ColorChange? ColorChange { get; set; }

  public ColorReplacement? ColorReplacement { get; set; }

  public Duotone? Duotone { get; set; }

  public Fill? Fill { get; set; }

  public FillOverlay? FillOverlay { get; set; }

  public Glow? Glow { get; set; }

  public Boolean Grayscale { get; set; }

  public Hsl? Hsl { get; set; }

  public InnerShadow? InnerShadow { get; set; }

  public LuminanceEffect? LuminanceEffect { get; set; }

  public OuterShadow? OuterShadow { get; set; }

  public PresetShadow? PresetShadow { get; set; }

  public Reflection? Reflection { get; set; }

  public RelativeOffset? RelativeOffset { get; set; }

  public SoftEdge? SoftEdge { get; set; }

  public TintEffect? TintEffect { get; set; }

  public TransformEffect? TransformEffect { get; set; }
}