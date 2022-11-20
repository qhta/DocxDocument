namespace DocumentModel.Drawing;

/// <summary>
/// Blend Effect.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectContainer))]
public interface IBlend // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Blend Mode
  /// </summary>
  public BlendModeValues? BlendMode { get ; set; }
  
  /// <summary>
  /// Effect to blend.
  /// </summary>
  public IEffectContainer? EffectContainer { get ; set; }
  
}
