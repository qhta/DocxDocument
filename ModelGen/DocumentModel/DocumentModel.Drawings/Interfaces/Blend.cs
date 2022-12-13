namespace DocumentModel.Drawings;

/// <summary>
/// Blend Effect.
/// </summary>
public interface Blend
{
  /// <summary>
  /// Blend Mode
  /// </summary>
  public DocumentModel.Drawings.BlendMode? BlendMode { get ; set; }
  
  /// <summary>
  /// Effect to blend.
  /// </summary>
  public DocumentModel.Drawings.EffectContainer? EffectContainer { get ; set; }
  
}
