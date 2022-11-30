namespace DocumentModel.Drawing;

/// <summary>
/// Blend Effect.
/// </summary>
public interface IBlend // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Blend Mode
  /// </summary>
  public DocumentModel.Drawing.BlendMode? BlendMode { get ; set; }
  
  /// <summary>
  /// Effect to blend.
  /// </summary>
  public DocumentModel.Drawing.IEffectContainer? EffectContainer { get ; set; }
  
}
