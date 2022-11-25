namespace DocumentModel.Drawing;

/// <summary>
/// Effect Container.
/// </summary>
public interface IEffectList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Blur Effect.
  /// </summary>
  public DocumentModel.Drawing.IBlur? Blur { get ; set; }
  
  /// <summary>
  /// FillOverlay.
  /// </summary>
  public DocumentModel.Drawing.IFillOverlay? FillOverlay { get ; set; }
  
  /// <summary>
  /// Glow.
  /// </summary>
  public DocumentModel.Drawing.IGlow? Glow { get ; set; }
  
  /// <summary>
  /// InnerShadow.
  /// </summary>
  public DocumentModel.Drawing.IInnerShadow? InnerShadow { get ; set; }
  
  /// <summary>
  /// OuterShadow.
  /// </summary>
  public DocumentModel.Drawing.IOuterShadow? OuterShadow { get ; set; }
  
  /// <summary>
  /// PresetShadow.
  /// </summary>
  public DocumentModel.Drawing.IPresetShadow? PresetShadow { get ; set; }
  
  /// <summary>
  /// Reflection.
  /// </summary>
  public DocumentModel.Drawing.IReflection? Reflection { get ; set; }
  
  /// <summary>
  /// SoftEdge.
  /// </summary>
  public DocumentModel.Drawing.ISoftEdge? SoftEdge { get ; set; }
  
}
