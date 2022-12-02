namespace DocumentModel.Drawing;

/// <summary>
/// Effect Container.
/// </summary>
public interface IEffectDag // : DocumentModel.Drawing.IEffectContainerType
{
  public Collection<IEffectContainer>? EffectContainers { get ; set; }
  
  public Collection<IEffect>? Effects { get ; set; }
  
  public Collection<IAlphaBiLevel>? AlphaBiLevels { get ; set; }
  
  public Collection<Boolean>? AlphaCeilings { get ; set; }
  
  public Collection<Boolean>? AlphaFloors { get ; set; }
  
  public Collection<IAlphaInverse>? AlphaInverses { get ; set; }
  
  public Collection<IAlphaModulationEffect>? AlphaModulationEffects { get ; set; }
  
  public Collection<IAlphaModulationFixed>? AlphaModulationFixeds { get ; set; }
  
  public Collection<IAlphaOutset>? AlphaOutsets { get ; set; }
  
  public Collection<IAlphaReplace>? AlphaReplaces { get ; set; }
  
  public Collection<IBiLevel>? BiLevels { get ; set; }
  
  public Collection<IBlend>? Blends { get ; set; }
  
  public Collection<IBlur>? Blurs { get ; set; }
  
  public Collection<IColorChange>? ColorChanges { get ; set; }
  
  public Collection<IColorReplacement>? ColorReplacements { get ; set; }
  
  public Collection<IDuotone>? Duotones { get ; set; }
  
  public Collection<IFill>? Fills { get ; set; }
  
  public Collection<IFillOverlay>? FillOverlaies { get ; set; }
  
  public Collection<IGlow>? Glows { get ; set; }
  
  public Collection<Boolean>? Grayscales { get ; set; }
  
  public Collection<IHsl>? Hsls { get ; set; }
  
  public Collection<IInnerShadow>? InnerShadows { get ; set; }
  
  public Collection<ILuminanceEffect>? LuminanceEffects { get ; set; }
  
  public Collection<IOuterShadow>? OuterShadows { get ; set; }
  
  public Collection<IPresetShadow>? PresetShadows { get ; set; }
  
  public Collection<IReflection>? Reflections { get ; set; }
  
  public Collection<IRelativeOffset>? RelativeOffsets { get ; set; }
  
  public Collection<ISoftEdge>? SoftEdges { get ; set; }
  
  public Collection<ITintEffect>? TintEffects { get ; set; }
  
  public Collection<ITransformEffect>? TransformEffects { get ; set; }
  
}
