namespace DocumentModel.Drawing;

/// <summary>
/// Effect Container.
/// </summary>
public interface IEffectList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Blur Effect.
  /// </summary>
  public IBlur? Blur { get ; set; }
  
  /// <summary>
  /// FillOverlay.
  /// </summary>
  public IFillOverlay? FillOverlay { get ; set; }
  
  /// <summary>
  /// Glow.
  /// </summary>
  public IGlow? Glow { get ; set; }
  
  /// <summary>
  /// InnerShadow.
  /// </summary>
  public IInnerShadow? InnerShadow { get ; set; }
  
  /// <summary>
  /// OuterShadow.
  /// </summary>
  public IOuterShadow? OuterShadow { get ; set; }
  
  /// <summary>
  /// PresetShadow.
  /// </summary>
  public IPresetShadow? PresetShadow { get ; set; }
  
  /// <summary>
  /// Reflection.
  /// </summary>
  public IReflection? Reflection { get ; set; }
  
  /// <summary>
  /// SoftEdge.
  /// </summary>
  public ISoftEdge? SoftEdge { get ; set; }
  
}
