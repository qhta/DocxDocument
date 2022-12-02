namespace DocumentModel.Drawing;

/// <summary>
/// Blend Effect.
/// </summary>
public interface IBlend // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Blend Mode
  /// </summary>
  public BlendMode? BlendMode { get ; set; }
  
  /// <summary>
  /// Effect to blend.
  /// </summary>
  public IEffectContainer? EffectContainer { get ; set; }
  
}
