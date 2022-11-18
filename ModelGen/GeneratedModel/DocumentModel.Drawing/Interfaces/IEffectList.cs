namespace DocumentModel.Drawing;

/// <summary>
/// Effect Container.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlur))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IFillOverlay))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGlow))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IInnerShadow))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IOuterShadow))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPresetShadow))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IReflection))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISoftEdge))]
public interface IEffectList // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  public DocumentModel.Drawing.IGlow? Glow { get ; set; }
  
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
  public DocumentModel.Drawing.IReflection? Reflection { get ; set; }
  
  /// <summary>
  /// SoftEdge.
  /// </summary>
  public ISoftEdge? SoftEdge { get ; set; }
  
}
