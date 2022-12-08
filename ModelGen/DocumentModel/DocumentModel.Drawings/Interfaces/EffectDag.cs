namespace DocumentModel.Drawings;

/// <summary>
/// Effect Container.
/// </summary>
public interface EffectDag
{
  public Collection<EffectContainer>? EffectContainers { get ; set; }
  
  public Collection<Effect>? Effects { get ; set; }
  
  public Collection<AlphaBiLevel>? AlphaBiLevels { get ; set; }
  
  public Collection<Boolean>? AlphaCeilings { get ; set; }
  
  public Collection<Boolean>? AlphaFloors { get ; set; }
  
  public Collection<AlphaInverse>? AlphaInverses { get ; set; }
  
  public Collection<AlphaModulationEffect>? AlphaModulationEffects { get ; set; }
  
  public Collection<AlphaModulationFixed>? AlphaModulationFixeds { get ; set; }
  
  public Collection<AlphaOutset>? AlphaOutsets { get ; set; }
  
  public Collection<AlphaReplace>? AlphaReplaces { get ; set; }
  
  public Collection<BiLevel>? BiLevels { get ; set; }
  
  public Collection<Blend>? Blends { get ; set; }
  
  public Collection<Blur>? Blurs { get ; set; }
  
  public Collection<ColorChange>? ColorChanges { get ; set; }
  
  public Collection<ColorReplacement>? ColorReplacements { get ; set; }
  
  public Collection<Duotone>? Duotones { get ; set; }
  
  public Collection<Fill>? Fills { get ; set; }
  
  public Collection<FillOverlay>? FillOverlaies { get ; set; }
  
  public Collection<Glow>? Glows { get ; set; }
  
  public Collection<Boolean>? Grayscales { get ; set; }
  
  public Collection<Hsl>? Hsls { get ; set; }
  
  public Collection<InnerShadow>? InnerShadows { get ; set; }
  
  public Collection<LuminanceEffect>? LuminanceEffects { get ; set; }
  
  public Collection<OuterShadow>? OuterShadows { get ; set; }
  
  public Collection<PresetShadow>? PresetShadows { get ; set; }
  
  public Collection<Reflection>? Reflections { get ; set; }
  
  public Collection<RelativeOffset>? RelativeOffsets { get ; set; }
  
  public Collection<SoftEdge>? SoftEdges { get ; set; }
  
  public Collection<TintEffect>? TintEffects { get ; set; }
  
  public Collection<TransformEffect>? TransformEffects { get ; set; }
  
}
