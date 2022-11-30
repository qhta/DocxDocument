namespace DocumentModel.Drawing;

/// <summary>
/// Effect Container.
/// </summary>
public interface IEffectContainer // : DocumentModel.Drawing.IEffectContainerType
{
  public DocumentModel.Drawing.IEffectContainer? EffectContainer { get ; set; }
  
  public DocumentModel.Drawing.IEffect? Effect { get ; set; }
  
  public DocumentModel.Drawing.IAlphaBiLevel? AlphaBiLevel { get ; set; }
  
  public System.Boolean? AlphaCeiling { get ; set; }
  
  public System.Boolean? AlphaFloor { get ; set; }
  
  public DocumentModel.Drawing.IAlphaInverse? AlphaInverse { get ; set; }
  
  public DocumentModel.Drawing.IAlphaModulationEffect? AlphaModulationEffect { get ; set; }
  
  public DocumentModel.Drawing.IAlphaModulationFixed? AlphaModulationFixed { get ; set; }
  
  public DocumentModel.Drawing.IAlphaOutset? AlphaOutset { get ; set; }
  
  public DocumentModel.Drawing.IAlphaReplace? AlphaReplace { get ; set; }
  
  public DocumentModel.Drawing.IBiLevel? BiLevel { get ; set; }
  
  public DocumentModel.Drawing.IBlend? Blend { get ; set; }
  
  public DocumentModel.Drawing.IBlur? Blur { get ; set; }
  
  public DocumentModel.Drawing.IColorChange? ColorChange { get ; set; }
  
  public DocumentModel.Drawing.IColorReplacement? ColorReplacement { get ; set; }
  
  public DocumentModel.Drawing.IDuotone? Duotone { get ; set; }
  
  public DocumentModel.Drawing.IFill? Fill { get ; set; }
  
  public DocumentModel.Drawing.IFillOverlay? FillOverlay { get ; set; }
  
  public DocumentModel.Drawing.IGlow? Glow { get ; set; }
  
  public System.Boolean? Grayscale { get ; set; }
  
  public DocumentModel.Drawing.IHsl? Hsl { get ; set; }
  
  public DocumentModel.Drawing.IInnerShadow? InnerShadow { get ; set; }
  
  public DocumentModel.Drawing.ILuminanceEffect? LuminanceEffect { get ; set; }
  
  public DocumentModel.Drawing.IOuterShadow? OuterShadow { get ; set; }
  
  public DocumentModel.Drawing.IPresetShadow? PresetShadow { get ; set; }
  
  public DocumentModel.Drawing.IReflection? Reflection { get ; set; }
  
  public DocumentModel.Drawing.IRelativeOffset? RelativeOffset { get ; set; }
  
  public DocumentModel.Drawing.ISoftEdge? SoftEdge { get ; set; }
  
  public DocumentModel.Drawing.ITintEffect? TintEffect { get ; set; }
  
  public DocumentModel.Drawing.ITransformEffect? TransformEffect { get ; set; }
  
}
